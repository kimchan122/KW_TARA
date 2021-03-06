using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Collections;

namespace Project.Forms
{
    public partial class FormTrain : Form
    {
        private Button currentButton;
        private bool isCollapsed;

        Dictionary<String, Hashtable> stationOfCity = new Dictionary<string, Hashtable>();
        Dictionary<String, String> cityCode;
        List<Hashtable> stationList = new List<Hashtable>();
        Hashtable trainSort = new Hashtable();

        int depBtnCount = 0;
        int arrBtnCount = 0;
        int sortBtnCount = 0;

        int numOfRow = 10;          // 한 페이지 결과 수.
        int pageNo = 1;             // 페이지 번호.
        String depPlaceId = "";     //출발지ID
        String arrPlaceId = "";     //도착지ID
        String depPlandTime = "";   //출발일
        String trainGradeCode = ""; //차량종류코드
        String depPlandTime_Round = "";

        public FormTrain()
        {
            InitializeComponent();
        }

        private void FormTrain_Load(object sender, EventArgs e)
        {
            LoadTheme();//테마 적용함수 로드
            flpnlDetail.Hide();
            lblDateToCome.Hide();
            lblDateToGo.Hide();
            goCalendar.Hide();
            comeCalendar.Hide();
            flpnlResult.Hide();
        }

        //부모 Form의 색상테마를 적용하는 함수	
        private void LoadTheme()
        {
            foreach (Control ctrls in this.Controls)
            {       //콘트롤 객체 탐색
                if (ctrls.GetType() == typeof(Button))
                {       //버튼일 경우
                    Button btn = (Button)ctrls;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Gainsboro;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                else if (ctrls.GetType() == typeof(Label))
                {   //라벨일 경우
                    Label lbl = (Label)ctrls;
                    lbl.ForeColor = ThemeColor.SecondaryColor;
                }
                /*
				 * 다른 컨트롤 객체들도 테마 적용하시려면 여기에 조건문을 추가하시면 됩니다.
				 *	ctrls.GetType()이 typeof(아이템 이름(ex.Panel, Textbox,...))과 일치하면
				 *	해당 아이템 객체 선언하시고
				 *	PrimaryColor나 SecondaryColor로 컬러 속성 변경하는 식입니다.
				 */
            }
        }

        private void btnWayToggle_RoundTrip_Click(object sender, EventArgs e)
        {
            ActivateButton(pnlWayToggle, sender);
        }

        private void btnWayToggle_Single_Click(object sender, EventArgs e)
        {
            ActivateButton(pnlWayToggle, sender);
        }

        private void btnTrainMenu_Destination_Click(object sender, EventArgs e)
        {
            clickedkMenu(sender);
            ClearPanelControls(tPnlCity);
            ClearPanelControls(tPnlStation);
            ClearPanelControls(tPnlSort);
            getStationInfo();
            flpnlDetail.Show();
            lblDateToCome.Hide();
            lblDateToGo.Hide();
            goCalendar.Hide();
            comeCalendar.Hide();
            flpnlResult.Hide();
        }

        private void clickedkMenu(object sender)
        {
            if (currentButton != sender)
            {
                Button thisButton = (Button)sender;
            }
            ActivateButton(pnlPlaneMenu, sender);

        }


        private void ActivateButton(Panel Area, object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                { //선택한 버튼과 다른 버튼이 인자로 들어왔으면
                    DisableButton(Area);  //버튼을 초기 상태로 되돌림

                    currentButton = (Button)btnSender;  //현재 버튼을 currentButton에 저장
                    currentButton.BackColor = ThemeColor.PrimaryColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                }
            }
        }
        //패널 내 모든 버튼들의 스타일을 원래대로 되돌리는 함수
        private void DisableButton(Panel Area)
        {
            foreach (Control previousBtn in Area.Controls)
            { //패널 내의 모든 콘트롤 객체 탐색
                if (previousBtn.GetType() == typeof(Button))
                {   //버튼이면 스타일 초기화
                    previousBtn.BackColor = Color.FromArgb(78, 78, 110);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                }
            }
        }

        private void tmrPanelMove_Tick(object sender/*Timer객체*/, EventArgs e)
        {
            //패널이 닫혀있으면
            if (isCollapsed)
            {
                flpnlDetail.Width += 20;    //패널 가로 크기 20pixel 증가
                if (flpnlDetail.Size == flpnlDetail.MaximumSize)    //MaximumSize는 속성에서 변경가능
                {//최대 크기에 도달하면
                    tmrPanelMove.Stop();    //타이머 정지
                    isCollapsed = false;    //패널 열려있음으로 상태 변경
                }
            }
            //패널이 열려있으면
            else
            {
                flpnlDetail.Width -= 20;
                if (flpnlDetail.Size == flpnlDetail.MinimumSize)
                {
                    tmrPanelMove.Stop();
                    isCollapsed = true;
                }
            }
        }




        //기차역을 클릭시 해당 기차역의 코드를 전역변수에 할당해주고 출,도착지에 해당 기차역을 표시.
        private void btn_StationClick(object sender, EventArgs e)
        {

            Button btnClicked = sender as Button;
            ActivateButton(tPnlStation, sender);


            foreach (var station in stationList)
            {
                foreach (var key in station.Keys)
                {
                    if (btnClicked.Text.Equals(station[key]))
                    {
                        if (btnTrainMenu_Departure.BackColor == ThemeColor.PrimaryColor)
                        {
                            btnTrainMenu_Departure.Text = btnTrainMenu_Departure.Text.Substring(0, 5);
                            btnTrainMenu_Departure.Text += " (" + btnClicked.Text + ") ";
                            depPlaceId = key.ToString();
                        }
                        else if (btnTrainMenu_Destination.BackColor == ThemeColor.PrimaryColor)
                        {
                            btnTrainMenu_Destination.Text = btnTrainMenu_Destination.Text.Substring(0, 5);
                            btnTrainMenu_Destination.Text += " (" + btnClicked.Text + ") ";
                            arrPlaceId = key.ToString();
                        }

                    }

                }
            }
        }

        //해당 도시의 기차역개수만큼 버튼을 생성.
        private void createStationBtn(Hashtable station)
        {
            tPnlStation.AutoSize = true;
            tPnlStation.RowCount = station.Count / 5;

            foreach (var list in station.Keys)
            {
                Button btnStation = new Button();
                btnStation.Click += btn_StationClick;
                this.tPnlStation.Controls.Add(btnStation);
                btnStation.AutoSize = true;
                btnStation.Dock = DockStyle.Right;
                btnStation.Text = station[list].ToString();

            }
        }

        //도시를 클릭했을때, 해당하는 도시의 기차역을 보여주기위한 이벤트.
        private void btn_CityClick(object sender, EventArgs e)
        {

            Button btnClicked = sender as Button;
            ActivateButton(tPnlCity, sender);

            ClearPanelControls(tPnlStation);

            Hashtable station = new Hashtable();

            foreach (var list in cityCode.Keys)
            {
                if (btnClicked.Text.ToString().Equals(cityCode[list].ToString()))
                    station = stationOfCity[list];
            }

            createStationBtn(station);

        }

        private void createCityBtn()
        {
            tPnlCity.AutoSize = true;
            tPnlCity.RowCount = cityCode.Count / 5;

            foreach (var list in cityCode.Keys)
            {
                Button btnCities = new Button();
                btnCities.Click += btn_CityClick;
                this.tPnlCity.Controls.Add(btnCities);
                btnCities.Dock = DockStyle.Top;
                btnCities.AutoSize = true;
                btnCities.Text = cityCode[list].ToString();

            }
        }

        //출발지, 도착지의 기차역이 같으므로 함수처리 하여 코드의 재활용.
        private void getStationInfo()
        {
            if (depBtnCount == 0 && arrBtnCount == 0)
            {

                //도시코드를 가져옴.
                cityCode = getCityCode();
                //도시버튼 생성.
                createCityBtn();

                string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getCtyAcctoTrainSttnList"; // URL
                url += "?ServiceKey=" + new Project.Forms.Plane.PlaneAPI().getServiceKey(); // Service Key
                url += "&numOfRows=" + numOfRow;
                url += "&pageNo=" + pageNo;

                List<String> cityList = new List<String>();

                foreach (var list in cityCode.Keys)
                    cityList.Add(url + "&cityCode=" + list);


                foreach (var list in cityList)
                {
                    Hashtable station = new Hashtable();
                    string response = getXmlString(list);

                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(response);
                    string dicKey = list.Substring(list.Length - 2);

                    XmlNode node = doc["response"]["body"]["items"];

                    for (int i = 0; i < node.ChildNodes.Count; i++)
                    {
                        //존재하지 않은 기차역코드만 key값으로 설정 value는 기차역이름을 저장.
                        if (!station.ContainsKey(node.ChildNodes[i]["nodeid"].InnerText))
                            station.Add(node.ChildNodes[i]["nodeid"].InnerText, node.ChildNodes[i]["nodename"].InnerText);
                    }
                    if (!stationList.Contains(station))
                        stationList.Add(station);

                    if (!stationOfCity.ContainsKey(dicKey))
                        stationOfCity.Add(dicKey, station);
                }
            }
            else
            {
                createCityBtn();
            }
            depBtnCount++;
        }

        private void ClearPanelControls(Panel panel)
        {
            foreach (var control in panel.Controls.OfType<Button>().ToList())
                panel.Controls.Remove(control);
        }

        //출발지를 얻어오는 함수.
        private void btnPlaneMenu_Departure_Click(object sender, EventArgs e)
        {
            clickedkMenu(sender);
            ClearPanelControls(tPnlCity);
            ClearPanelControls(tPnlStation);
            ClearPanelControls(tPnlSort);
            getStationInfo();
            flpnlDetail.Show();
            lblDateToCome.Hide();
            lblDateToGo.Hide();
            goCalendar.Hide();
            comeCalendar.Hide();
            flpnlResult.Hide();
        }

        //도시코드 정보를 받아오는 함수.
        private Dictionary<String, String> getCityCode()
        {
            var cityCode = new Dictionary<String, String>();
            string url = " http://openapi.tago.go.kr/openapi/service/SuburbsBusInfoService/getCtyCodeList"; // URL
            url += "?ServiceKey=" + new Project.Forms.Plane.PlaneAPI().getServiceKey(); // Service Key
            string response = getXmlString(url);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response);
            XmlNode node = doc["response"]["body"]["items"];

            for (int i = 0; i < node.ChildNodes.Count; i++)
            {
                String cityName = node.ChildNodes[i]["cityName"].InnerText;
                String temp = "";

                if (cityName.Length == 3 || cityName.Length == 5)
                    cityName = cityName.Substring(0, 2);
                else
                {
                    temp += cityName.Substring(0, 1);
                    temp += cityName.Substring(2, 2);
                    temp = temp.Substring(0, 2);
                    cityName = temp;
                }

                //존재하지 않은 기차역만 key값으로 설정 value는 기차역코드를 저장.
                if (!cityCode.ContainsKey(node.ChildNodes[i]["cityCode"].InnerText))
                    cityCode.Add(node.ChildNodes[i]["cityCode"].InnerText, cityName);

            }
            return cityCode;
        }

        private void btn_SortClick(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;
            ActivateButton(tPnlSort, sender);

            foreach (var list in trainSort.Keys)
            {
                if (btnClicked.Text.Equals(trainSort[list]))
                {
                    btnTrainMenu_TrainSort.Text = trainSort[list].ToString();
                    trainGradeCode = list.ToString();
                }

            }
        }

        private void createSortBtn()
        {
            tPnlSort.AutoSize = true;
            tPnlSort.RowCount = trainSort.Count / 3;

            ClearPanelControls(tPnlSort);

            foreach (var list in trainSort.Keys)
            {
                Button btnSort = new Button();
                btnSort.Click += btn_SortClick;
                this.tPnlSort.Controls.Add(btnSort);
                btnSort.AutoSize = true;
                btnSort.Dock = DockStyle.Top;
                btnSort.Text = trainSort[list].ToString();

            }
        }

        //기차 종류 정보를 얻는 버튼.
        private void btnTrainMenu_TrainSort_Click(object sender, EventArgs e)
        {
            clickedkMenu(sender);
            ClearPanelControls(tPnlCity);
            ClearPanelControls(tPnlStation);
            flpnlDetail.Show();
            goCalendar.Hide();
            comeCalendar.Hide();
            lblDateToCome.Hide();
            lblDateToGo.Hide();
            flpnlResult.Hide();

            if (sortBtnCount == 0)
            {
                string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getVhcleKndList";
                url += "?ServiceKey=" + new Project.Forms.Plane.PlaneAPI().getServiceKey(); // Service Key

                string response = getXmlString(url);

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(response);

                XmlNode node = doc["response"]["body"]["items"];

                for (int i = 0; i < node.ChildNodes.Count; i++)
                {
                    //존재하지 않은 기차종류만 key값에 넣음. value는 기차종류코드번호를 넣어줌.
                    if (!trainSort.ContainsKey(node.ChildNodes[i]["vehiclekndid"].InnerText))
                    {
                        trainSort.Add(node.ChildNodes[i]["vehiclekndid"].InnerText, node.ChildNodes[i]["vehiclekndnm"].InnerText);

                    }

                }

                createSortBtn();

            }
            else
            {
                createSortBtn();
            }

            sortBtnCount++;
        }

        private String getXmlString(String url)
        {
            WebRequest reqWeb = WebRequest.Create(url);
            reqWeb.Method = "GET";

            WebResponse resWeb = reqWeb.GetResponse();
            Stream s = resWeb.GetResponseStream();
            StreamReader reader = new StreamReader(s);

            return reader.ReadToEnd();
        }


        private void btnDate_Click(object sender, EventArgs e)
        {
            clickedkMenu(sender);
            ClearPanelControls(tPnlCity);
            ClearPanelControls(tPnlStation);
            ClearPanelControls(tPnlSort);
            flpnlResult.Hide();

            //왕복일경우 달력 두개를 표시.
            if (btnWayToggle_RoundTrip.BackColor == ThemeColor.PrimaryColor)
            {
                goCalendar.Show();
                lblDateToGo.Show();
                comeCalendar.Show();
                lblDateToCome.Show();
            }
            else
            {
                goCalendar.Show();
                lblDateToGo.Show();
            }
        }

        private void goCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            string date = goCalendar.SelectionStart.ToShortDateString();

            btnDate.Text = date;
            date = date.Replace("-", string.Empty);
            depPlandTime = date;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            flpnlResult.Show();
            listResultToGo.Items.Clear();
            listResultToCome.Items.Clear();

            string depTime = "";
            string arrTime = "";

            for (int num = 1; num <= 6; num++)
            {
                string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getStrtpntAlocFndTrainInfo"; // URL
                url += "?ServiceKey=" + new Project.Forms.Plane.PlaneAPI().getServiceKey();
                url += "&numOfRows=" + numOfRow;
                url += "&pageNo=" + num;
                url += "&depPlaceId=" + depPlaceId;
                url += "&arrPlaceId=" + arrPlaceId;
                url += "&depPlandTime=" + depPlandTime;
                url += "&trainGradeCode=" + trainGradeCode;


                string response_Go = getXmlString(url);
                string response_Come = "";

                if (btnWayToggle_RoundTrip.BackColor == ThemeColor.PrimaryColor)
                {
                    url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getStrtpntAlocFndTrainInfo";
                    url += "?ServiceKey=" + new Project.Forms.Plane.PlaneAPI().getServiceKey();
                    url += "&numOfRows=" + numOfRow;
                    url += "&pageNo=" + num;
                    url += "&depPlaceId=" + arrPlaceId;
                    url += "&arrPlaceId=" + depPlaceId;
                    url += "&depPlandTime=" + depPlandTime_Round;
                    url += "&trainGradeCode=" + trainGradeCode;

                    response_Come = getXmlString(url);
                }


                XmlDocument doc = new XmlDocument();
                doc.LoadXml(response_Go);

                XmlNode node = doc["response"]["body"]["items"];

                for (int i = 0; i < node.ChildNodes.Count; i++)
                {
                    ListViewItem item_temp = new ListViewItem();

                    item_temp.Text = node.ChildNodes[i]["traingradename"].InnerText;

                    depTime = node.ChildNodes[i]["depplandtime"].InnerText;
                    arrTime = node.ChildNodes[i]["arrplandtime"].InnerText;

                    depTime = timeSubstring(depTime);
                    arrTime = timeSubstring(arrTime);

                    item_temp.SubItems.Add(depTime);
                    item_temp.SubItems.Add(arrTime);
                    item_temp.SubItems.Add(node.ChildNodes[i]["depplacename"].InnerText);
                    item_temp.SubItems.Add(node.ChildNodes[i]["arrplacename"].InnerText);
                    item_temp.SubItems.Add(node.ChildNodes[i]["adultcharge"].InnerText);

                    listResultToGo.Items.Add(item_temp);
                }

                for (int i = 0; i < listResultToGo.Columns.Count; i++)
                    listResultToGo.Columns[i].Width = -2;


                lblResultToGo.Show();
                listResultToGo.Show();

                if (response_Come != "")
                {
                    doc.LoadXml(response_Come);

                    node = doc["response"]["body"]["items"];

                    for (int i = 0; i < node.ChildNodes.Count; i++)
                    {
                        ListViewItem item_temp = new ListViewItem();

                        item_temp.Text = node.ChildNodes[i]["traingradename"].InnerText;

                        depTime = node.ChildNodes[i]["depplandtime"].InnerText;
                        arrTime = node.ChildNodes[i]["arrplandtime"].InnerText;

                        depTime = timeSubstring(depTime);
                        arrTime = timeSubstring(arrTime);

                        item_temp.SubItems.Add(depTime);
                        item_temp.SubItems.Add(arrTime);
                        item_temp.SubItems.Add(node.ChildNodes[i]["depplacename"].InnerText);
                        item_temp.SubItems.Add(node.ChildNodes[i]["arrplacename"].InnerText);
                        item_temp.SubItems.Add(node.ChildNodes[i]["adultcharge"].InnerText);

                        listResultToCome.Items.Add(item_temp);
                    }

                    for (int i = 0; i < listResultToCome.Columns.Count; i++)
                        listResultToCome.Columns[i].Width = -2;

                    lblResultToCome.Show();
                    listResultToCome.Show();
                }
                else
                {
                    listResultToCome.Hide();
                    lblResultToCome.Hide();
                }
            }
        }

        private String timeSubstring(String time)
        {
            time = time.Substring(8, 4).Insert(2, " : ");

            return time;
        }

        private void comeCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            string date = comeCalendar.SelectionStart.ToShortDateString();

            btnDate.Text += "\r\n"+date;
            date = date.Replace("-", string.Empty);
            depPlandTime_Round = date;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Collections;
using System.Linq;

namespace Project.Forms
{
    public partial class FormTrain : Form
    {
        private Button currentButton;
        private bool isCollapsed;

        int numOfRow = 10;          // 한 페이지 결과 수.
        int pageNo = 1;             // 페이지 번호.
        String depPlaceId = "NAT010000";     //출발지ID
        String arrPlaceId = "NAT011668";     //도착지ID
        String depPlandTime = "20201201";   //출발일
        String trainGradeCode = "00"; //차량종류코드

        public FormTrain()
        {
            InitializeComponent();
            flpnlDetail.Size = flpnlDetail.MinimumSize; //flow layout panel 숨기기
        }

        private void FormTrain_Load(object sender, EventArgs e)
        {
            LoadTheme();//테마 적용함수 로드
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

        private void btn_Click(object sender, EventArgs e)
        {
            Button btnClick = sender as Button;
            ActivateButton(pnlWayToggle, sender);
        }

        private void btnTrainMenu_Destination_Click(object sender, EventArgs e)
        {
            if (currentButton != sender)
            {
                Button thisButton = (Button)sender;
                flpnlDetail.Size = flpnlDetail.MinimumSize;
                isCollapsed = true;
            }
            ActivateButton(pnlPlaneMenu, sender);
            tmrPanelMove.Start();
        }

        private void btnTrainMenu_HeadCount_Click(object sender, EventArgs e)
        {
            if (currentButton != sender)
            {
                flpnlDetail.Size = flpnlDetail.MinimumSize;
                isCollapsed = true;
            }
            ActivateButton(pnlPlaneMenu, sender);
            tmrPanelMove.Start();
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
                    currentButton.Font = new System.Drawing.Font("서울남산체 B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
                    previousBtn.Font = new System.Drawing.Font("서울남산체 B", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                }
            }
        }

        private void tmrPanelMove_Tick(object sender, EventArgs e)
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









        //출발지를 얻어오는 함수.
        private void btnPlaneMenu_Departure_Click(object sender, EventArgs e)
        {
            if (currentButton != sender)
            {
                //보여진 패널(flpnDetail)을 바로 숨긴다(Size를 MinimumSize로 바꿔서).
                Button thisButton = (Button)sender;
                flpnlDetail.Size = flpnlDetail.MinimumSize;
                isCollapsed = true; //패널 닫혀있음 상태로 변경
            }
            ActivateButton(pnlPlaneMenu, sender);//현재 누른 버튼 활성화
            tmrPanelMove.Start();//타이머 작동 시작

            //도시코드를 가져옴.
            var cityCode = getCityCode();


            //가나다 순으로 정렬 하고 싶지만 안됨...
            cityCode.OrderBy(Dictionary => cityCode.Keys);

            foreach (var list in cityCode.Keys)
            {
                Button btnCities = new Button();
                btnCities.Click += btn_Click;
                this.flpnlDetail.Controls.Add(btnCities);
                btnCities.Dock = DockStyle.Top;
                btnCities.Text = list.ToString();

            }

            Hashtable station = new Hashtable();

            string key = "2SJfYnZjJ62Nhoe9Vl%2BFAqkdF4T4LbWeUo2TiamCZinFnKJA7LLGJ4PSwtVRwiGwWLIsUUh9xWwsK3oUQIB2Bg%3D%3D";
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getCtyAcctoTrainSttnList"; // URL
            url += "?ServiceKey=" + key; // Service Key
            url += "&numOfRows=" + numOfRow;
            url += "&pageNo=" + pageNo;

            List<String> cityList = new List<string>();


            foreach (var list in cityCode.Keys)
            {
                cityList.Add(url + "&cityCode=" + cityCode[list]);
            }


            foreach (var list in cityList)
            {
                string response = getXmlString(list);

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(response);

                XmlNode node = doc["response"]["body"]["items"];

                for (int i = 0; i < node.ChildNodes.Count; i++)
                {
                    //존재하지 않은 기차역만 key값으로 설정 value는 기차역코드를 저장.
                    if (!station.ContainsKey(node.ChildNodes[i]["nodename"].InnerText))
                        station.Add(node.ChildNodes[i]["nodename"].InnerText, node.ChildNodes[i]["nodeid"].InnerText);
                }
            }

            foreach (var stName in station.Keys)
            {

                //textBox1.Text += stName + "\r\n";
            }


        }

        //도시코드 정보를 받아오는 함수.
        private Dictionary<String, String> getCityCode()
        {

            var cityCode = new Dictionary<String, String>();

            string key = "2SJfYnZjJ62Nhoe9Vl%2BFAqkdF4T4LbWeUo2TiamCZinFnKJA7LLGJ4PSwtVRwiGwWLIsUUh9xWwsK3oUQIB2Bg%3D%3D";
            string url = " http://openapi.tago.go.kr/openapi/service/SuburbsBusInfoService/getCtyCodeList"; // URL
            url += "?ServiceKey=" + key; // Service Key

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
                if (!cityCode.ContainsKey(cityName))
                    cityCode.Add(cityName, node.ChildNodes[i]["cityCode"].InnerText);

            }


            return cityCode;
        }

        //기차 종류 정보를 얻는 버튼.
        private void btnTrainMenu_TrainSort_Click(object sender, EventArgs e)
        {
            if (currentButton != sender)
            {
                flpnlDetail.Size = flpnlDetail.MinimumSize;
                isCollapsed = true;
            }
            ActivateButton(pnlPlaneMenu, sender);
            tmrPanelMove.Start();


            Hashtable trainSort = new Hashtable();

            string key = "2SJfYnZjJ62Nhoe9Vl%2BFAqkdF4T4LbWeUo2TiamCZinFnKJA7LLGJ4PSwtVRwiGwWLIsUUh9xWwsK3oUQIB2Bg%3D%3D";
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getVhcleKndList";
            url += "?ServiceKey=" + key; // Service Key

            string response = getXmlString(url);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response);

            XmlNode node = doc["response"]["body"]["items"];

            for (int i = 0; i < node.ChildNodes.Count; i++)
            {
                //존재하지 않은 기차종류만 key값에 넣음. value는 기차종류코드번호를 넣어줌.
                if (!trainSort.ContainsKey(node.ChildNodes[i]["vehiclekndnm"].InnerText))
                {
                    trainSort.Add(node.ChildNodes[i]["vehiclekndnm"].InnerText, node.ChildNodes[i]["vehiclekndid"].InnerText);

                }


            }



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

        private void btnResult_Click(object sender, EventArgs e)
        {
            string key = "2SJfYnZjJ62Nhoe9Vl%2BFAqkdF4T4LbWeUo2TiamCZinFnKJA7LLGJ4PSwtVRwiGwWLIsUUh9xWwsK3oUQIB2Bg%3D%3D";
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getStrtpntAlocFndTrainInfo"; // URL
            url += "?ServiceKey=" + key;
            url += "&numOfRows=" + numOfRow;
            url += "&pageNo=" + pageNo;
            url += "&depPlaceId=" + depPlaceId;
            url += "&arrPlaceId=" + arrPlaceId;
            url += "&depPlandTime=" + depPlandTime;
            url += "&trainGradeCode=" + trainGradeCode;


            string response = getXmlString(url);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response);

            XmlNode node = doc["response"]["body"]["items"];

            for (int i = 0; i < node.ChildNodes.Count; i++)
            {

                textBox1.Text += node.ChildNodes[i]["traingradename"].InnerText + "\r\n";
                textBox1.Text += node.ChildNodes[i]["depplandtime"].InnerText + "\r\n";
                textBox1.Text += node.ChildNodes[i]["arrplandtime"].InnerText + "\r\n";
                textBox1.Text += node.ChildNodes[i]["depplacename"].InnerText + "\r\n";
                textBox1.Text += node.ChildNodes[i]["arrplacename"].InnerText + "\r\n";
                textBox1.Text += node.ChildNodes[i]["adultcharge"].InnerText + "\r\n";
                textBox1.Text += node.ChildNodes[i]["trainno"].InnerText + "\r\n";
                textBox1.Text += "\r\n";
            }
        }
    }
}

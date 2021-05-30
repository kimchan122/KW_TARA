using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Collections.Generic;

//고속버스
//성인: 100%
//소아(6세~초등학교 재학생): 50%
//유아: 0%(좌석배정X, 영유아 수가 나머지 인원수보다 많을 경우, 해당 유아는 소아 요금을 지불하여 별도의 좌석 배정.)

//비행기(국내선, 국제선)(저가항공사 제외)
//성인: 100%, 100%
//소아(24개월~만12세 미만): 75%, 75%
//유아(생후7일~24개월 미만, 별도 좌석 제공 안됨, 유아 수가 나머지 인원수보다 많을 경우, 해당 유아는 소아 요금을 지불하여 별도의 좌석 배정.): 무료, 10%

//지하철

//택시

//자가용

//톨게이트(경차~승용차)

namespace Project.Forms {
	public partial class FormRouteSearch : Form {
        private Button currentButton;
        private bool isCollapsed;
		private List<Train_Stationcode> startstation;
		private List<Train_Stationcode> endstation;
		private List<Train_Trainkinds> traingrade;

		public FormRouteSearch() {
			InitializeComponent();
            string url = "https://kimchan122.github.io/nvmaptest1/test.html";
            flpnlDetail.Size = flpnlDetail.MinimumSize; //flow layout panel 숨기기
                                                        //webBrowser1.Navigate(url);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string msg = e.Url + " 로딩 완료!";
            //MessageBox.Show(msg);
        }

        private void FormRouteSearch_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
		private void LoadTheme()
		{
			foreach (Control ctrls in this.Controls)
			{   //콘트롤 객체 탐색
				if (ctrls.GetType() == typeof(Button))
				{   //버튼일 경우
					Button btn = (Button)ctrls;
					btn.BackColor = ThemeColor.PrimaryColor;
					btn.ForeColor = Color.White;
					btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
				}
				else if (ctrls.GetType() == typeof(Label))
				{ //라벨일 경우
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

		private void btnRSMenu_Departure_Click(object sender, EventArgs e)
		{
			//직전에 누른 버튼이 지금 버튼과 다른 버튼이면
			if (currentButton != sender)
			{
				//보여진 패널(flpnDetail)을 바로 숨긴다(Size를 MinimumSize로 바꿔서).
				Button thisButton = (Button)sender;
				flpnlDetail.Size = flpnlDetail.MinimumSize;
				isCollapsed = true; //패널 닫혀있음 상태로 변경
			}
			ActivateButton(pnlRSMenu, sender);//현재 누른 버튼 활성화
			tmrPanelMove.Start();//타이머 작동 시작
		}

		private void btnRSMenu_Destination_Click(object sender, EventArgs e)
		{
			if (currentButton != sender)
			{
				Button thisButton = (Button)sender;
				flpnlDetail.Size = flpnlDetail.MinimumSize;
				isCollapsed = true;
			}
			ActivateButton(pnlRSMenu, sender);
			tmrPanelMove.Start();
		}

		private void btnRSMenu_HeadCount_Click(object sender, EventArgs e)
		{
			if (currentButton != sender)
			{
				flpnlDetail.Size = flpnlDetail.MinimumSize;
				isCollapsed = true;
			}
			ActivateButton(pnlRSMenu, sender);
			tmrPanelMove.Start();
		}


		private void btnRSMenu_SeatClass_Click(object sender, EventArgs e)
		{
			if (currentButton != sender)
			{
				flpnlDetail.Size = flpnlDetail.MinimumSize;
				isCollapsed = true;
			}
			ActivateButton(pnlRSMenu, sender);
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

					if (sel != null && (currentButton.Text == "  출발지" || currentButton.Text == "  도착지"))
					{
						//currentButton.Text += ": " + sel;
						sel = null;
					}
					Update();
				}
			}
		}
		string sel;
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

					char sp = ':';
					string[] s = previousBtn.Text.Split(sp);
                    if (s.Length>3 && (previousBtn.Name!= "btnRSMenu_Departure" || previousBtn.Name!= "btnRSMenu_Destination"))
                    {
						previousBtn.Text = s[0];
                    }
					//previousBtn.Text = "1";
				}
			}
		}
		//
		//타이머가 동작할 때의 동작을 정의하고 있는 함수입니다.
		//	타이머가 동작하면(.Start()), 타이머가 정지할 때까지 지정된 단위 시간마다 이 함수가 호출됩니다(단위 시간 변경 : 속성 -> Interval).
		//
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
		private void btnRSMenu_RSSearch_Click(object sender, EventArgs e)
		{
			Train_GetTrainCode();
		}

		string btnstart;
		string btnend;

		private void AddDeporArr(object sender, MouseEventArgs e)
        {
			startstation = null;
			endstation = null;
			traingrade = null;
            startstation = new List<Train_Stationcode>();
			endstation=new List<Train_Stationcode>();
			traingrade = new List<Train_Trainkinds>();
			sel = (sender as Button).Text;

			//MessageBox.Show("cur: " + currentButton.Text);

			if (currentButton.Name == "btnRSMenu_Departure") { // 출발지 탭에서
				btnstart = sel; // 버튼의 텍스트를 저장.
								// 기차
				if (btnstart == "서울"){
					Train_GetStationCode(1,"11");
                }
				else if (btnstart == "부산"){
					Train_GetStationCode(1,"21");
				}
				// 비행기
				// 고속버스

			}
			else if (currentButton.Name == "btnRSMenu_Destination") // 도착지 탭에서
            {
				btnend = sel;
				//기차
				if (btnend == "서울")
				{
					Train_GetStationCode(2,"11");
				}
				else if (btnend == "부산")
				{
					Train_GetStationCode(2,"21");
				}
			
			}
			MessageBox.Show("start: " + btnstart);
			MessageBox.Show("end: " + btnend);
			//Update();
		}


		public void Train_GetStationCode(int sore,string code) // 지역코드를 통해 역을 저장하는 코드
		{
			string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getCtyAcctoTrainSttnList"; // URL
			url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key
			url += "&numOfRows=100";
			url += "&pageNo=1";
			url += "&cityCode=";
			url += code;
			var request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = "GET";

			string results = string.Empty;
			HttpWebResponse response;
			using (response = request.GetResponse() as HttpWebResponse)
			{
				StreamReader reader = new StreamReader(response.GetResponseStream());
				results = reader.ReadToEnd();
			}

			int sw = 0;
			string str = string.Empty;
			string text = string.Empty;
			string c_code = string.Empty;
			string c_name = string.Empty;
			for (int i = 0; i < results.Length; i++)
			{
				if (sw == 1 && results[i] != '<' && results[i] != '>'){
					str += results[i];
				}
				else if (results[i] == '>'){
					switch (str)
					{
						case "resultMsg":
							sw = 2;
							break;
						case "nodeid":
							sw = 3;
							break;
						case "nodename":
							sw = 4;
							break;
						default:
							sw = 0;
							break;
					}
				}
				if (results[i] != '<' && results[i] != '>'){
					switch (sw)
					{
						case 2:
							text += results[i];
							break;
						case 3:
							c_code += results[i];
							break;
						case 4:
							c_name += results[i];
							break;
					}
					text += results[i];
				}
				else if (results[i] == '<'){
					switch (sw)
					{
						case 2:
							if (str.Length > 0 && text.Length > 0)
							{
							}
							break;
						case 3:
							if (str.Length > 0 && c_code.Length > 0)
							{
							}
							break;
						case 4:
							if (str.Length > 0 && c_name.Length > 0)
							{
								if (sore == 1){
									startstation.Add(new Train_Stationcode(c_code, c_name));
								}
								else if (sore == 2){
									endstation.Add(new Train_Stationcode(c_code, c_name));
								}
								c_code = string.Empty;
								c_name = string.Empty;
							}
							break;
					}
					sw = 0;
					str = string.Empty;
					text = string.Empty;
				}
				if (sw == 0 && results[i] == '<' && results[i + 1] != '/'){
					sw = 1;
				}
			}
			
			foreach(var c in startstation)
            {
				//MessageBox.Show(c.Name+": "+c.Code);
            }

			foreach (var c in endstation)
			{
				//MessageBox.Show(c.Name + ": " + c.Code);
			}
		}
		public static void Train_GetTrainCode()
		{
			List<Train_Trainkinds> traingrade = new List<Train_Trainkinds>();

			string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getVhcleKndList"; // URL
			url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key

			var request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = "GET";

			string results = string.Empty;
			HttpWebResponse response;
			using (response = request.GetResponse() as HttpWebResponse)
			{
				StreamReader reader = new StreamReader(response.GetResponseStream());
				results = reader.ReadToEnd();
			}

			string Real_results = string.Empty;
			int sw = 0;
			string str = string.Empty;
			string text = string.Empty;
			string vehiclekndid = string.Empty;
			string vehiclekndnm = string.Empty;

			for (int i = 0; i < results.Length; i++)
			{
				if (sw == 1 && results[i] != '<' && results[i] != '>')
				{
					str += results[i];
				}
				else if (results[i] == '>')
				{
					switch (str)
					{
						case "resultMsg":
							sw = 2;
							break;
						case "vehiclekndid":
							sw = 3;
							break;
						case "vehiclekndnm":
							sw = 4;
							break;
						default:
							sw = 0;
							break;
					}
				}

				if (results[i] != '<' && results[i] != '>')
				{
					switch (sw)
					{
						case 2:
							text += results[i];
							break;
						case 3:
							vehiclekndid += results[i];
							break;
						case 4:
							vehiclekndnm += results[i];
							break;
					}
					text += results[i];
				}
				else if (results[i] == '<')
				{
					switch (sw)
					{
						case 4:
							if (str.Length > 0 && vehiclekndnm.Length > 0)
							{
								traingrade.Add(new Train_Trainkinds(vehiclekndid, vehiclekndnm));
								vehiclekndid = string.Empty;
								vehiclekndnm = string.Empty;
							}
							break;
					}
					sw = 0;
					str = string.Empty;
					text = string.Empty;
				}
				if (sw == 0 && results[i] == '<' && results[i + 1] != '/')
				{
					sw = 1;
				}
			}

			foreach (var c in traingrade)
			{
				MessageBox.Show(c.Vehiclekndid + ": " + c.Vehiclekndnm);
				//Console.WriteLine("{0}: {1}", c.Vehiclekndid, c.Vehiclekndnm);
			}

			/*int sww = 0;
			while (true) // 코드 받아서 역 리스트 받는 부분으로 넘김
			{
				foreach (var c in traingrade)
				{
					Console.WriteLine("{0}: {1}", c.Vehiclekndid, c.Vehiclekndnm);
				}
				Console.WriteLine();
				string input_code = string.Empty; // 입력받은 코드를 저장할 문자열 변수
				Console.Write("Give me a Train Grade Code: "); // 코드를 입력하세요!
				input_code = Console.ReadLine(); // 입력
				sww = 0;
				foreach (var c in trainkinds)
				{
					if (c.Vehiclekndid == input_code) // 지역코드 중에 맞는 코드가 있는지 확인
					{
						sww = 1;
						return input_code;
						break;
					}
				}
				if (sww == 0)
				{
					Console.WriteLine("열차 코드를 다시 입력해 주세요!\n"); // 일치하는 코드가 없을 시 메시지
					Console.WriteLine("{0}", trainkinds.Count);
				}
			}
			return null;*/
		}
		public static void Train_GetStartToEnd(string start, string end, string deptime, string train)
		{
			Console.WriteLine("출발지  :{0}", start);
			Console.WriteLine("도착지  :{0}", end);
			Console.WriteLine("출발시각:{0}", deptime);
			Console.WriteLine("등급    :{0}", train);
			List<TrainList> trainlist = new List<TrainList>();
			string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getStrtpntAlocFndTrainInfo"; // URL
			url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key
			url += "&numOfRows=100";
			url += "&pageNo=1";
			url += "&depPlaceId=";
			url += start;
			url += "&arrPlaceId=";
			url += end;
			url += "&depPlandTime=";
			url += deptime;
			url += "&trainGradeCode=";
			url += train;

			var request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = "GET";

			string results = string.Empty;
			HttpWebResponse response;
			using (response = request.GetResponse() as HttpWebResponse)
			{
				StreamReader reader = new StreamReader(response.GetResponseStream());
				results = reader.ReadToEnd();
			}
			//Console.WriteLine(results);

			//string Real_results = string.Empty;
			//Console.WriteLine(results);
			int sw = 0;
			string str = string.Empty;
			string text = string.Empty;

			string c_charge = string.Empty;
			string c_arrname = string.Empty;
			string c_arrtime = string.Empty;
			string c_depname = string.Empty;
			string c_deptime = string.Empty;
			string c_grade = string.Empty;
			string c_number = string.Empty;

			for (int i = 0; i < results.Length; i++)
			{
				if (sw == 1 && results[i] != '<' && results[i] != '>')
				{
					str += results[i];
				}
				else if (results[i] == '>')
				{
					switch (str)
					{
						case "resultMsg":
							sw = 2;
							break;
						case "adultcharge": // 비용
							sw = 3;
							break;
						case "arrplacename": // 출발역
							sw = 4;
							break;
						case "arrplandtime":
							sw = 5;
							break;
						case "depplacename":
							sw = 6;
							break;
						case "depplandtime":
							sw = 7;
							break;
						case "traingradename":
							sw = 8;
							break;
						case "trainno":
							sw = 9;
							break;
						default:
							sw = 0;
							break;
					}
				}

				if (results[i] != '<' && results[i] != '>')
				{
					switch (sw)
					{
						case 2:
							text += results[i];
							break;
						case 3:
							c_charge += results[i];
							break;
						case 4:
							c_arrname += results[i];
							break;
						case 5:
							c_arrtime += results[i];
							break;
						case 6:
							c_depname += results[i];
							break;
						case 7:
							c_deptime += results[i];
							break;
						case 8:
							c_grade += results[i];
							break;
						case 9:
							c_number += results[i];
							break;
					}
					text += results[i];
				}
				else if (results[i] == '<')
				{
					switch (sw)
					{
						case 9:
							if (str.Length > 0 && c_number.Length > 0)
							{
								//Citycode css = new Citycode(c_code, c_name);
								//css.print();
								//cities.Add(new Citycode(c_code, c_name));
								trainlist.Add(new TrainList(c_charge, c_arrname, c_arrtime, c_depname, c_deptime, c_grade, c_number));
								c_charge = string.Empty;
								c_arrname = string.Empty;
								c_arrtime = string.Empty;
								c_depname = string.Empty;
								c_deptime = string.Empty;
								c_grade = string.Empty;
								c_number = string.Empty;
							}
							break;
					}
					sw = 0;
					str = string.Empty;
					text = string.Empty;
				}
				if (sw == 0 && results[i] == '<' && results[i + 1] != '/')
				{
					sw = 1;
				}
			}
			foreach (var c in trainlist)
			{
				c.print();
				//Console.WriteLine("{0}: {1}", c.Name, c.Code);
			}
		}
	}
    //국토교통부_열차정보 관련 클래스
    class Train_Citycode // 기차의 도시코드를 얻는 클래스
	{
		public string Code { get; set; }
		public string Name { get; set; }

		public Train_Citycode(string code, string name)
		{
			this.Code = code;
			this.Name = name;
		}
		public void print()
		{
			Console.WriteLine("{0}: {1}", this.Name, this.Code);
		}
	}
	class Train_Stationcode // 기차의 역 코드를 얻는 클래스
	{
		public string Code { get; set; }
		public string Name { get; set; }

		public Train_Stationcode(string code, string name)
		{
			this.Code = code;
			this.Name = name;
		}
		public void print()
		{
			Console.WriteLine("{0}: {1}", this.Name, this.Code);
		}
	}
	class Train_Trainkinds // 기차의 종류를 얻는 클래스
	{
		public string Vehiclekndid { get; set; }
		public string Vehiclekndnm { get; set; }

		public Train_Trainkinds(string vehiclekndid, string vehiclekndnm)
		{
			this.Vehiclekndid = vehiclekndid;
			this.Vehiclekndnm = vehiclekndnm;
		}
		public void print()
		{
			Console.WriteLine("{0}: {1}", this.Vehiclekndid, this.Vehiclekndnm);
		}
	}
	class TrainList // 기차의 운행정보를 담는 클래스
	{
		public string Charge { get; set; }
		public string ArrName { get; set; }
		public string ArrTime { get; set; }
		public string DepName { get; set; }
		public string DepTime { get; set; }
		public string Grade { get; set; }
		public string Number { get; set; }

		public TrainList(string charge, string arrname, string arrtime, string depname, string deptime, string grade, string number)
		{
			this.Charge = charge;
			this.ArrName = arrname;
			this.ArrTime = arrtime;
			this.DepName = depname;
			this.DepTime = deptime;
			this.Grade = grade;
			this.Number = number;
		}
		public void print()
		{
			Console.WriteLine("비용    : {0}", this.Charge);
			Console.WriteLine("도착역  : {0}", this.ArrName);
			Console.WriteLine("도착시각: {0}", this.ArrTime);
			Console.WriteLine("출발역  : {0}", this.DepName);
			Console.WriteLine("출발시각: {0}", this.DepTime);
			Console.WriteLine("등급    : {0}", this.Grade);
			Console.WriteLine("열차번호: {0}", this.Number);
			Console.WriteLine();
		}
	}

}

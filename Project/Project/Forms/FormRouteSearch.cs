using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Collections.Generic;

namespace Project.Forms {
	public partial class FormRouteSearch : Form {
		private Button currentButton;
		private bool isCollapsed;
		private string btnstart;
		private string btnend;
		private string btndeptime;

		private static List<Train_Stationcode> startstation = new List<Train_Stationcode>();
		private static List<Train_Stationcode> endstation = new List<Train_Stationcode>();
		private static List<Train_Trainkinds> traingrade = new List<Train_Trainkinds>();
		private static List<TrainList> trainlist = new List<TrainList>();

		private static List<ExpressBus_Terminalcode> startbusstation=new List<ExpressBus_Terminalcode>();
		private static List<ExpressBus_Terminalcode> endbusstation=new List<ExpressBus_Terminalcode>();
		private static List<ExpressBusList> exbuslist = new List<ExpressBusList>();

		private static List<string> startairport=new List<string>();
		private static List<string> endairport= new List<string>();
		private static List<Airport_AirlineID> airlines = new List<Airport_AirlineID>();
		private static List<AirplaneList> airplanelist = new List<AirplaneList>();

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
			Airport_GetAirlinesID();
			LoadTheme();
			cldDatePicker.Hide();
			string date = cldDatePicker.SelectionStart.ToShortDateString();
			date = date.Replace("-", string.Empty);
			btndeptime = date;
			Console.WriteLine("BTNDEPTIME: {0}", btndeptime);
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
			ButtonChange(metropolice);
			//ButtonChange(metro_gyeonggi);
			ActivateButton(pnlRSMenu, sender);//현재 누른 버튼 활성화
			cldDatePicker.Hide();
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
			ButtonChange(metropolice);
			ActivateButton(pnlRSMenu, sender);
			cldDatePicker.Hide();
			tmrPanelMove.Start();
		}

		private void btnRSMenu_HeadCount_Click(object sender, EventArgs e)//출발날짜
		{
			if (currentButton != sender)
			{
				flpnlDetail.Size = flpnlDetail.MinimumSize;
				isCollapsed = true;
			}
			ActivateButton(pnlRSMenu, sender);
			tmrPanelMove.Start();
			ButtonChange(none);
			cldDatePicker.Show();
		}
		private void cldDatePicker_DateChanged(object sender, DateRangeEventArgs e)
		{
			string date = cldDatePicker.SelectionStart.ToShortDateString();
			date = date.Replace("-", string.Empty);
			btndeptime = date;
			Console.WriteLine("BTNDEPTIME: {0}", btndeptime);
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
					if (s.Length > 3 && (previousBtn.Name != "btnRSMenu_Departure" || previousBtn.Name != "btnRSMenu_Destination"))
					{
						previousBtn.Text = s[0];
					}
				}
			}
		}
		private void tmrPanelMove_Tick(object sender/*Timer객체*/, EventArgs e)
		{
			Button btn = sender as Button;
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
		private void btnRSMenu_RSSearch_Click(object sender, EventArgs e) // 경로 탐색 버튼을 클릭할 경우.
		{                                                                // 동적 패널을 닫고, 각종 정보를 받은 후, 리스트에 경로들을 넣는다.
			cldDatePicker.Hide();
			ButtonChange(none);

			lvResult.Items.Clear();
			startbusstation.Clear();
			endbusstation.Clear();
			exbuslist.Clear();

			//startairport.Clear();
			//endairport.Clear();
			//airplanelist.Clear();
			
			tmrPanelMove.Start();
			if (!isCollapsed)
			{
				flpnlDetail.Width -= 20;
				if (flpnlDetail.Size == flpnlDetail.MinimumSize)
				{
					tmrPanelMove.Stop();
					isCollapsed = true;
				}
			}
			//각종 정보를 불러온다.
			Console.WriteLine("TRAIN go");
			//Train_GetTrainCode();
			//Train_GetStationCode(1, starttrain);
			//Train_GetStationCode(2, endtrain);
			foreach (var i in startstation)
			{
				foreach (var j in endstation)
				{
					Console.WriteLine("{0}, {1}", i.Code, j.Code);
					//Train_GetStartToEnd(i.Code, j.Code, btndeptime, "00");
					//Train_GetStartToEnd(i.Code, j.Code, btndeptime, "07");
					//Train_GetStartToEnd(i.Code, j.Code, btndeptime, "10");
					//Train_GetStartToEnd(i.Code, j.Code, btndeptime, "16");
					//Train_GetStartToEnd(i.Code, j.Code, btndeptime, "17");
					//foreach (var k in traingrade) {
					//MessageBox.Show(i.Code + " " + j.Code + " " + "text " + k.Vehiclekndid);
					//Console.WriteLine("{0} {1} {2} {3}", i.Code, j.Code, "txt", k.Vehiclekndnm);
					//Train_GetStartToEnd(i.Code, j.Code, "20210602",k.Vehiclekndid);
					//}
				}
			}
			Console.WriteLine("TRAIN END");

			Console.WriteLine("BUS go");
			//ExpressBus_GetTerminalID(1, btnstart); // 절대 지우지 말 것! 트래픽 초과 가능성 있음
			//ExpressBus_GetTerminalID(2, btnend); // 절대 지우지 말 것! 트래픽 초과 가능성 있음
			foreach (var i in startbusstation)
            {
				foreach(var j in endbusstation)
                {
					//ExpressBus_GetStartToEnd(i.terminalId, j.terminalId, btndeptime, "1"); // 절대 지우지 말 것! 트래픽 초과 가능성 있음
				}
			}
			Console.WriteLine("BUS END");

			Console.WriteLine("AIR go");
			foreach(var i in startairport)
            {
				foreach(var j in endairport)
                {
					if(i!="null" && j != "null") { 
						foreach (var c in airlines)
						{
							//Airport_GetStartToEnd(i, j, btndeptime, c.AirlineId); // 절대 지우지 말 것! 트래픽 초과 가능성 있음
						}
					}
                }
            }
			Console.WriteLine("AIR END");




			int cnt = 0;
			// 리스트뷰에 정보 기입
			foreach (var i in trainlist) // 기차 목록을 리스트뷰에 추가
			{
				cnt++;
				string[] str = new string[7];
				str[0] = "KTX";
				str[1] = i.DepName + "역";
				str[2] = i.DepTime.Substring(8, 4).Insert(2, ":");
				str[3] = i.ArrName + "역";
				str[4] = i.ArrTime.Substring(8, 4).Insert(2, ":");
				str[5] = i.Charge;
				str[6] = Timecount(i.DepTime.Substring(8, 4), i.ArrTime.Substring(8, 4));
				ListViewItem lvi = new ListViewItem(str);
				lvResult.Items.Add(lvi);
				if (cnt > 30) break;
			}

			
			cnt = 0;
			foreach(var i in exbuslist) // 버스 목록을 리스트뷰에 추가
            {
				cnt++;
				string[] str = new string[7];
				str[0] = "고속버스";
				str[1] = i.DepPlaceNm + "터미널";
				str[2] = i.DepPlandTime.Substring(8,4).Insert(2, ":");
				str[3] = i.ArrPlaceNm + "터미널";
				str[4] = i.ArrPlandTime.Substring(8, 4).Insert(2, ":");
				str[5] = i.Charge;
				str[6] = Timecount(i.DepPlandTime.Substring(8,4),i.ArrPlandTime.Substring(8,4));
				ListViewItem lvi = new ListViewItem(str);
				lvResult.Items.Add(lvi);
				if (cnt > 30) break;
            }
			startbusstation.Clear();
			endbusstation.Clear();
			exbuslist.Clear();
			btnstart = null;
			btnend = null;

			cnt = 0;
			foreach(var i in airplanelist) // 항공기 목록을 리스트뷰에 추가
            {
				cnt++;
				string[] str = new string[7];
				str[0] = "항공기";
				str[1] = i.DepAirportNm + "공항";
				str[2] = i.DepPlandTime.Substring(8,4).Insert(2,":");
				str[3] = i.ArrAirportNm + "공항";
				str[4] = i.ArrPlandTime.Substring(8, 4).Insert(2, ":");
				str[5] = i.EconomyCharge;
				str[6] = Timecount(i.DepPlandTime.Substring(8, 4), i.ArrPlandTime.Substring(8, 4));
				ListViewItem lvi = new ListViewItem(str);
				lvResult.Items.Add(lvi);
				if (cnt > 30) break;
			}
			startairport.Clear();
			endairport.Clear();
			airplanelist.Clear();

		}
		private string Timecount(string s, string e)
        {
			string result="";
			string sh, eh;
			int shh, ehh;
			int rh;
			string rhh;

			string sm, em;
			int smm, emm;
			int rm;
			int sw = 0;
			string rmm;

			sh = s.Substring(0, 2); eh = e.Substring(0, 2);
			shh = Convert.ToInt32(sh); ehh = Convert.ToInt32(eh);
			rh = ehh - shh;
			if (rh < 0) rh += 24;

			sm = s.Substring(2); em = e.Substring(2);
			smm = Convert.ToInt32(sm); emm = Convert.ToInt32(em);
			rm = emm - smm;
			if (rm < 0){
				rh -= 1; rm = rm + 60;
            }
			if (rm < 10){
				sw = 1;
			}
			rhh = Convert.ToString(rh); rmm = Convert.ToString(rm);
			result += rhh;
			result += ":";
            if (sw == 1){
				result += "0";
            }
			result += rmm;

			return result;
        }

		private static List<string> none = new List<string> { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
		private static List<string> metropolice = new List<string> { "서울", "부산", "대구", "인천", "광주", "대전", "울산", "세종", "경기", "강원", "충북", "충남", "전북", "전남", "경북", "경남", "제주", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
		private static List<string> metro_gyeonggi = new List<string>{ "가평", "고양", "과천", "광명", "광주", "구리", "군포", "김포", "남양주", "동두천", "부천", "성남", "수원", "시흥", "안산", "안성", "안양", "양주", "양평", "여주", "연천", "오산", "용인", "의왕", "의정부", "이천", "파주", "평택", "포천", "하남", "화성", "", "", "", "←", "" };
		private static List<string> metro_gangwon = new List<string> { "강릉", "고성", "동해", "삼척", "속초", "양구","양양","영월", "원주", "인제","정선","철원", "춘천", "태백", "평창", "홍천","화천","횡성","", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "←", ""};
		private static List<string> metro_chungbuk = new List<string> {"괴산","단양","보은","영동","옥천","음성","제천","증평","진천","청주","충주","", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "←", "" };
		private static List<string> metro_chungnam = new List<string> {"계룡","공주","금산","논산","당진","보령","부여","서산","서천","아산","예산","천안","청양","태안","홍성","", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "←", "" };
		private static List<string> metro_jeonbuk = new List<string> {"고창","군산","김제","남원","무주","부안","순창","완주","익산","임실","장수","전주","정읍","진안","", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "←", "" };
		private static List<string> metro_jeonnam = new List<string> {"강진","고흥","광양","곡성","구례","나주","담양","목포","무안","보성","순천","신안","여수","영광","영암","완도","장성","장흥","진도","함평","해남","화순","", "", "", "", "", "", "", "", "", "", "", "", "←", "" };
		private static List<string> metro_gyeongbuk = new List<string> {"경산","경주","고령","구미","군위","김천","문경","봉화","상주","성주","안동","영덕","영양","영주","영천","예천","울릉","울진","의성","청도","청송","칠곡","포항","", "", "", "", "", "", "", "", "", "", "", "←", "" };
		private static List<string> metro_gyeongnam = new List<string> {"거제","거창","고성","김해","남해","밀양","사천","산청","양산","의령","진주","창녕","창원","통영","하동","함안","함양","합천","", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "←", "" };
		private static List<string> metro_jeju = new List<string> { "서귀포","제주","", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "←", "" };
		private string starttrain;
		private string endtrain;

		private void ButtonChange(List<string> s)
        {
			button1.Text = s[0];button2.Text = s[1];button3.Text = s[2];button4.Text = s[3];button5.Text = s[4];button6.Text = s[5];
			button7.Text = s[6];button8.Text = s[7];button9.Text = s[8];button10.Text = s[9];button11.Text = s[10];button12.Text = s[11];
			button13.Text = s[12];button14.Text = s[13];button15.Text = s[14];button16.Text = s[15];button17.Text = s[16];button18.Text = s[17];
			button19.Text = s[18];button20.Text = s[19];button21.Text = s[20];button22.Text = s[21];button23.Text = s[22];button24.Text = s[23];
			button25.Text = s[24];button26.Text = s[25];button27.Text = s[26];button28.Text = s[27];button29.Text = s[28];button30.Text = s[29];
			button31.Text = s[30];button32.Text = s[31];button33.Text = s[32];button34.Text = s[33];button35.Text = s[34];button36.Text = s[35];
		}
		private void btnMetro_Click(object sender, MouseEventArgs e)
		{
			Button btn = sender as Button;
			if (currentButton.Name == "btnRSMenu_Departure")
			{
				btnstart = btn.Text;
				switch (btn.Text)
				{
					case "": break;
					case "경기": starttrain = "31"; startairport = new List<string> { "NAARKSS", "NAARKSI" }; ButtonChange(metro_gyeonggi); break;
					case "강원": starttrain = "32"; startairport = new List<string> { "NAARKNW", "NAARKNY" }; ButtonChange(metro_gangwon); break;
					case "충북": starttrain = "33"; startairport = new List<string> { "NAARKTU", "null" }; ButtonChange(metro_chungbuk); break;
					case "충남": starttrain = "34"; startairport = new List<string> { "NAARKJK", "NAARKTU" }; ButtonChange(metro_chungnam); break;
					case "전북": starttrain = "35"; startairport = new List<string> { "NAARKJK", "null" }; ButtonChange(metro_jeonbuk); break;
					case "전남": starttrain = "36"; startairport = new List<string> { "NAARKJB", "NAARKJJ" }; ButtonChange(metro_jeonnam); break;
					case "경북": starttrain = "37"; startairport = new List<string> { "NAARKTH", "NAARKTN" }; ButtonChange(metro_gyeongbuk); break;
					case "경남": starttrain = "38"; startairport = new List<string> { "NAARKPS", "NAARKPK" }; ButtonChange(metro_gyeongnam); break;
					case "제주": starttrain = "00"; startairport = new List<string> { "NAARKPC", "null" }; ButtonChange(metro_jeju); break;
					case "←": ButtonChange(metropolice); break;
					default: AddDeporArr(sender); break;
				}
			}
			else if (currentButton.Name == "btnRSMenu_Destination")
			{
				btnend = btn.Text;
				switch (btn.Text)
				{
					case "": break;
					case "경기": endtrain = "31"; endairport = new List<string> { "NAARKSS", "NAARKSI" }; ButtonChange(metro_gyeonggi); break;
					case "강원": endtrain = "32"; endairport = new List<string> { "NAARKNW", "NAARKNY" }; ButtonChange(metro_gangwon); break;
					case "충북": endtrain = "33"; endairport = new List<string> { "NAARKTU", "null" }; ButtonChange(metro_chungbuk); break;
					case "충남": endtrain = "34"; endairport = new List<string> { "NAARKJK", "NAARKTU" }; ButtonChange(metro_chungnam); break;
					case "전북": endtrain = "35"; endairport = new List<string> { "NAARKJK", "null" }; ButtonChange(metro_jeonbuk); break;
					case "전남": endtrain = "36"; endairport = new List<string> { "NAARKJB", "NAARKJJ" }; ButtonChange(metro_jeonnam); break;
					case "경북": endtrain = "37"; endairport = new List<string> { "NAARKTH", "NAARKTN" }; ButtonChange(metro_gyeongbuk); break;
					case "경남": endtrain = "38"; endairport = new List<string> { "NAARKPS", "NAARKPK" }; ButtonChange(metro_gyeongnam); break;
					case "제주": endtrain = "00"; endairport = new List<string> { "NAARKPC", "null" }; ButtonChange(metro_jeju); break;
					case "←": ButtonChange(metropolice); break;
					default: AddDeporArr(sender); break;
				}
			}
		}
		private void AddDeporArr(object sender)
        {
			sel = (sender as Button).Text;
			if (currentButton.Name == "btnRSMenu_Departure") { // 출발지 탭에서
				btnstart = sel; // 버튼의 텍스트를 저장. 이 시점에서 버스는 끝.
                switch (btnstart)
                {
					case "서울": starttrain = "11"; startairport = new List<string> { "NAARKSS", "NAARKSI" }; break;//서울용산수서 // 김포공항 // 동서울서울경부센트럴
					case "부산": starttrain = "21"; startairport = new List<string> { "NAARKPK" , "null" }; break;//부산 // 김해공항 // 노포사상
					case "대구": starttrain = "22"; startairport = new List<string> { "NAARKTN" , "null" }; break;//동대구 // 대구공항 // 동대구
					case "인천": starttrain = "23"; startairport = new List<string> { "NAARKSS", "NAARKSI" }; break;//x // 인천공항김포공항 // 인천
					case "광주":if(starttrain != "31") starttrain = "24"; startairport = new List<string> { "NAARKJJ", "null" }; break;//광주송정 // 광주공항 // 광주유스퀘어
					case "대전": starttrain = "25"; startairport = new List<string> { "NAARKTU" , "null" }; break;//서대전대전 // x // 대전
					case "울산": starttrain = "26"; startairport = new List<string> { "NAARKPU" , "null" }; break;//울산 // 울산공항 // 울산
					case "세종": starttrain = "12"; startairport = new List<string> {"null","null" }; break;//x // x // 세종
					default:break;
				}
				Console.WriteLine("starttrain: {0}, startairport: {1}, {2}", starttrain, startairport[0],startairport[1]);

			}
			else if (currentButton.Name == "btnRSMenu_Destination") // 도착지 탭에서
            {
				btnend = sel; // 이 시점에서 버스는 끝
                switch (btnend)
                {
					case "서울": endtrain = "11"; endairport = new List<string> { "NAARKSS", "NAARKSI" }; break;//서울용산수서 // 김포공항 // 동서울서울경부센트럴
					case "부산": endtrain = "21"; endairport = new List<string> { "NAARKPK" , "null" }; break;//부산 // 김해공항 // 노포사상
					case "대구": endtrain = "22"; endairport = new List<string> { "NAARKTN" , "null" }; break;//동대구 // 대구공항 // 동대구
					case "인천": endtrain = "23"; endairport = new List<string> { "NAARKSS", "NAARKSI" }; break;//x // 인천공항김포공항 // 인천
					case "광주": if (endtrain != "31") endtrain = "24"; endairport = new List<string> { "NAARKJJ" , "null" }; break;//광주송정 // 광주공항 // 광주유스퀘어
					case "대전": endtrain = "25"; endairport = new List<string> { "NAARKTU" , "null" }; break;//서대전대전 // x // 대전
					case "울산": endtrain = "26"; endairport = new List<string> { "NAARKPU" , "null" }; break;//울산 // 울산공항 // 울산
					case "세종": endtrain = "12"; endairport = new List<string> { "null", "null" }; break;//x // x // 세종
					default: break;
				}
				Console.WriteLine("endtrain: {0}, endairport: {1}, {2}", endtrain, endairport[0],endairport[1]);
			}
			//Console.WriteLine("start: {0}     ", btnstart);
			//Console.WriteLine("  end: {0}     ", btnend);
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
		}
		public static void Train_GetTrainCode()
		{
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
		}
		public static void Train_GetStartToEnd(string start, string end, string deptime, string train)
		{
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
								//MessageBox.Show("RES");
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
				//MessageBox.Show(c.DepTime + " " + c.ArrTime);
				//lvResult.Items.Add(lv);
				//c.print();
				//Console.WriteLine("{0}: {1}", c.Name, c.Code);
			}
		}






		public static void ExpressBus_GetTerminalID(int sore, string city) // 고속버스 터미널 코드를 얻는 함수
		{
			string url = "http://openapi.tago.go.kr/openapi/service/ExpBusInfoService/getExpBusTrminlList"; // URL
			url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key
			url += "&numOfRows=10";
			url += "&pageNo=1";
			url += "&terminalNm=";
			url += city;

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
			string terminalId = string.Empty;
			string terminalNm = string.Empty;
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
						case "terminalId":
							sw = 3;
							break;
						case "terminalNm":
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
							terminalId += results[i];
							break;
						case 4:
							terminalNm += results[i];
							break;
					}
					text += results[i];
				}
				else if (results[i] == '<')
				{
					switch (sw)
					{
						case 4:
							if (str.Length > 0 && terminalNm.Length > 0)
							{
                                if (sore == 1)
                                {
									startbusstation.Add(new ExpressBus_Terminalcode(terminalId, terminalNm));
									Console.WriteLine("출발지 터미널 추가: {0} {1}", terminalId, terminalNm);
								}
								else if (sore == 2)
                                {
									endbusstation.Add(new ExpressBus_Terminalcode(terminalId, terminalNm));
									Console.WriteLine("종점지 터미널 추가: {0} {1}", terminalId, terminalNm);
                                }
								terminalId = string.Empty;
								terminalNm = string.Empty;
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
		}

		public static void ExpressBus_GetStartToEnd(string start, string end, string deptime, string exbus) // 인자를 통해 버스의 노선을 검색하는 함수
		{
			string url = "http://openapi.tago.go.kr/openapi/service/ExpBusInfoService/getStrtpntAlocFndExpbusInfo"; // URL
			url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key
			url += "&numOfRows=100";
			url += "&pageNo=1";
			url += "&depTerminalId=";
			url += start;
			url += "&arrTerminalId=";
			url += end;
			url += "&depPlandTime=";
			url += deptime;
			url += "&busGradeId=";
			url += exbus;

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

			string routeid = string.Empty;
			string gradeNm = string.Empty;
			string depPlandTime = string.Empty;
			string arrPlandTime = string.Empty;
			string depPlaceNm = string.Empty;
			string arrplaceNm = string.Empty;
			string charge = string.Empty;

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
						case "arrPlaceNm":
							sw = 3;
							break;
						case "arrPlandTime":
							sw = 4;
							break;
						case "charge":
							sw = 5;
							break;
						case "depPlaceNm":
							sw = 6;
							break;
						case "depPlandTime": // 출발역
							sw = 7;
							break;
						case "gradeNm": // 등급
							sw = 8;
							break;
						case "routeId": // 비용
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
							arrplaceNm += results[i];
							break;
						case 4:
							arrPlandTime += results[i];
							break;
						case 5:
							charge += results[i];
							break;
						case 6:
							depPlaceNm += results[i];
							break;
						case 7:
							depPlandTime += results[i];
							break;
						case 8:
							gradeNm += results[i];
							break;
						case 9:
							routeid += results[i];
							break;
					}
					text += results[i];
				}
				else if (results[i] == '<')
				{
					switch (sw)
					{
						case 9:
							if (str.Length > 0 && charge.Length > 0)
							{
								exbuslist.Add(new ExpressBusList(routeid, gradeNm, depPlandTime, arrPlandTime, depPlaceNm, arrplaceNm, charge));
								routeid = string.Empty;
								gradeNm = string.Empty;
								depPlandTime = string.Empty;
								arrPlandTime = string.Empty;
								depPlaceNm = string.Empty;
								arrplaceNm = string.Empty;
								charge = string.Empty;
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
		}




		//비행기
		public static void Airport_GetAirlinesID()
		{ // 항공사 코드를 얻는 함수
			string url = "http://openapi.tago.go.kr/openapi/service/DmstcFlightNvgInfoService/getAirmanList"; // URL
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
			string airlineId = string.Empty;
			string airlineNm = string.Empty;
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
						case "airlineId":
							sw = 3;
							break;
						case "airlineNm":
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
							airlineId += results[i];
							break;
						case 4:
							airlineNm += results[i];
							break;
					}
					text += results[i];
				}
				else if (results[i] == '<')
				{
					switch (sw)
					{
						case 4:
							if (str.Length > 0 && airlineNm.Length > 0)
							{
								airlines.Add(new Airport_AirlineID(airlineId, airlineNm));
								airlineId = string.Empty;
								airlineNm = string.Empty;
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
		}
		public static void Airport_GetStartToEnd(string start, string end, string deptime, string airline)
		{
			string url = "http://openapi.tago.go.kr/openapi/service/DmstcFlightNvgInfoService/getFlightOpratInfoList"; // URL
			url += "?ServiceKey=" + "MYFMxLc4kHFtLGMFgXDn3EnezpmlYYDTjebarh6bvwc4x1B2ePwhjl52FeUi9FAYNOzVmnQn%2BhmZTGTleodsfQ%3D%3D"; // Service Key
			url += "&numOfRows=100";
			url += "&pageNo=1";
			url += "&depAirportId=";
			url += start;
			url += "&arrAirportId=";
			url += end;
			url += "&depPlandTime=";
			url += deptime;
			url += "&airlineId=";
			url += airline;

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

			string airlinenm = string.Empty;
			string arrairportnm = string.Empty;
			string arrplandtime = string.Empty;
			string depairportnm = string.Empty;
			string depplandtime = string.Empty;
			string economycharge = string.Empty;
			string prestigecharge = string.Empty;
			string vihicleid = string.Empty;

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
						case "airlineNm": // 항공사명
							sw = 3;
							break;
						case "arrAirportNm": // 도착공항
							sw = 4;
							break;
						case "arrPlandTime": // 도착예정시각
							sw = 5;
							break;
						case "depAirportNm": // 출발공항
							sw = 6;
							break;
						case "depPlandTime": // 출발예정시각
							sw = 7;
							break;
						case "economyCharge": // 일반석운임
							sw = 8;
							break;
						case "prestigeChgarge": // 비즈니스석운임
							sw = 9;
							break;
						case "vihicleId": // 항공편명
							sw = 10;
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
							airlinenm += results[i];
							break;
						case 4:
							arrairportnm += results[i];
							break;
						case 5:
							arrplandtime += results[i];
							break;
						case 6:
							depairportnm += results[i];
							break;
						case 7:
							depplandtime += results[i];
							break;
						case 8:
							economycharge += results[i];
							break;
						case 9:
							prestigecharge += results[i];
							break;
						case 10:
							vihicleid += results[i];
							break;
					}
					text += results[i];
				}
				else if (results[i] == '<')
				{
					switch (sw)
					{
						case 10:
							if (str.Length > 0 && airlinenm.Length > 0)
							{
								airplanelist.Add(new AirplaneList(airlinenm, arrairportnm, arrplandtime, depairportnm, depplandtime, economycharge, prestigecharge, vihicleid));
								airlinenm = string.Empty;
								arrairportnm = string.Empty;
								arrplandtime = string.Empty;
								depairportnm = string.Empty;
								depplandtime = string.Empty;
								economycharge = string.Empty;
								prestigecharge = string.Empty;
								vihicleid = string.Empty;
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




	//국토교통부_고속버스정보 서비스
	class ExpressBus_Terminalcode // 고속버스의 터미널 코드를 얻는 클래스
	{
		public string terminalId { get; set; }
		public string terminalNm { get; set; }

		public ExpressBus_Terminalcode(string terminalid, string terminalnm)
		{
			this.terminalId = terminalid;
			this.terminalNm = terminalnm;
		}
		public void print()
		{
			Console.WriteLine("{0}: {1}", this.terminalId, this.terminalNm);
		}
	}
	class ExPressBus_BusGrade // 고속버스 등급을 얻는 클래스
	{
		public string GradeId { get; set; }
		public string GradeNm { get; set; }

		public ExPressBus_BusGrade(string gradeid, string gradenm)
		{
			this.GradeId = gradeid;
			this.GradeNm = gradenm;
		}
		public void print()
		{
			Console.WriteLine("{0}: {1}", this.GradeId, this.GradeNm);
		}
	}
	class ExpressBusList // 고속버스 운행정보를 얻는 클래스
	{
		public string RouteId { get; set; }
		public string GradeNm { get; set; }
		public string DepPlandTime { get; set; }
		public string ArrPlandTime { get; set; }
		public string DepPlaceNm { get; set; }
		public string ArrPlaceNm { get; set; }
		public string Charge { get; set; }
		public ExpressBusList(string routeid, string gradenm, string depplandtime, string arrplandtime, string depplacenm, string arrplacenm, string charge)
		{
			this.RouteId = routeid;
			this.GradeNm = gradenm;
			this.DepPlandTime = depplandtime;
			this.ArrPlandTime = arrplandtime;
			this.DepPlaceNm = depplacenm;
			this.ArrPlaceNm = arrplacenm;
			this.Charge = charge;
		}
		public void print()
		{
			Console.WriteLine("노선ID    : {0}", this.RouteId);
			Console.WriteLine("버스등급명: {0}", this.GradeNm);
			Console.WriteLine("출발시각  : {0}", this.DepPlandTime);
			Console.WriteLine("도착시각  : {0}", this.ArrPlandTime);
			Console.WriteLine("출발터미널: {0}", this.DepPlaceNm);
			Console.WriteLine("도착터미널: {0}", this.ArrPlaceNm);
			Console.WriteLine("운임      : {0}", this.Charge);
			Console.WriteLine();
		}
	}




	//국토교통부_국내항공운항정보 관련 클래스
	class Airport_AirportCode // 공항 코드를 얻는 클래스
	{
		public string AirportId { get; set; }
		public string AirportNm { get; set; }
		public Airport_AirportCode(string airportid, string airportnm)
		{
			this.AirportId = airportid;
			this.AirportNm = airportnm;
		}
		public void print()
		{
			Console.WriteLine("{0}: {1}", this.AirportId, this.AirportNm);
		}
	}
	class Airport_AirlineID // 항공사 코드를 얻는 클래스
	{
		public string AirlineId { get; set; }
		public string AirlineNm { get; set; }
		public Airport_AirlineID(string airlineid, string airlinenm)
		{
			this.AirlineId = airlineid;
			this.AirlineNm = airlinenm;
		}
		public void print()
		{
			Console.WriteLine("{0}: {1}", this.AirlineId, this.AirlineNm);
		}
	}
	class AirplaneList // 비행 운항 정보를 얻는 클래스
	{
		public string VihicleId { get; set; }
		public string AirlineNm { get; set; }
		public string DepPlandTime { get; set; }
		public string ArrPlandTime { get; set; }
		public string EconomyCharge { get; set; }
		public string PrestigeCharge { get; set; }
		public string DepAirportNm { get; set; }
		public string ArrAirportNm { get; set; }
		public AirplaneList(string airlinenm, string arrairportnm, string arrplandtime, string depairportnm, string depplandtime, string economycharge, string prestigecharge, string vihicleid)
		{
			this.AirlineNm = airlinenm;
			this.ArrAirportNm = arrairportnm;
			this.ArrPlandTime = arrplandtime;
			this.DepAirportNm = depairportnm;
			this.DepPlandTime = depplandtime;
			this.EconomyCharge = economycharge;
			this.PrestigeCharge = prestigecharge;
			this.VihicleId = vihicleid;
		}
		public void print()
		{
			Console.WriteLine("항공사명      : {0}", this.AirlineNm);
			Console.WriteLine("도착공항      : {0}", this.ArrAirportNm);
			Console.WriteLine("도착시각      : {0}", this.ArrPlandTime);
			Console.WriteLine("출발공항      : {0}", this.DepAirportNm);
			Console.WriteLine("출발시각      : {0}", this.DepPlandTime);
			Console.WriteLine("일반석운임    : {0}", this.EconomyCharge);
			Console.WriteLine("비즈니스석운임: {0}", this.PrestigeCharge);
			Console.WriteLine("항공편명      : {0}", this.VihicleId);
			Console.WriteLine();
		}
	}

}

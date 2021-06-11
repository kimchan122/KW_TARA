using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using System.Xml;
using System.Collections;

namespace Project.Forms
{
	public partial class FormBus : Form
	{
		private Button currentButton;
		private bool isCollapsed;
		private bool isPress = false;
		private bool isPress2 = false;

		private string temp;
		private string temp2;        // 고속버스
		private string temp3;
		
		private string temp_2;
		private string temp2_2;      // 시외버스
		private string temp3_2;       
		
		

		public FormBus()
		{
			InitializeComponent();
			flpnlDetail.Size = flpnlDetail.MinimumSize; //flow layout panel 숨기기
		}

		private void FormBus_Load(object sender, EventArgs e)
		{
			LoadTheme();	
		}

		//
		//부모 Form의 색상테마를 적용하는 함수입니다.
		//	현재 폼의 콘트롤 객체들을 모두 탐색하면서, 콘트롤 객체의 종류마다 다른 스타일을
		//	적용할 수 있습니다.	
		//예를 들어 콘트롤 객체가 버튼일 경우(typeof(Button)),
		//	배경은 PrimaryColor, 테두리는 SecondaryColor로 지정하고,
		//	라벨일 경우에는 글자색을 SecondaryColor로 지정하는 식의 로직입니다.
		//
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

		//
		//티켓 경로를 선택하는 버튼의 클릭에 대한 동작입니다.
		//왕복, 편도 두 개의 버튼이 있으며, pnlBusMenu > pnlWayToggle 내에 있습니다.
		//
		private void btnWayToggle_CountrySide_Click(object sender, EventArgs e)
		{
			ActivateButton(pnlWayToggle, sender);
		}

		private void btnWayToggle_Express_Click(object sender, EventArgs e)
		{
			ActivateButton(pnlWayToggle, sender);
			
			dep1_2.Visible = false;
			dep2_2.Visible = false;
			arr1_2.Visible = false;
			arr2_2.Visible = false;
			Sub.Visible = false;
			BusGrade_2.Visible = false;
			
			
		}


		//
		//출발지, 도착지, 인원, 좌석 등급을 설정하는 버튼의 클릭에 대한 동작입니다.
		//각 버튼은 pnlPlaneMenu 내에 있습니다.
		//각 버튼을 누르면 (FlowLayoutPanel)flpnlDetail 패널이 서서히 나타납니다.
		//패널의 보이기 동작은 (Timer)tmrPanelMove 에 의해 패널의 크기를 조정하는 식으로
		//구현하였습니다.
		//한 버튼을 누르고 다른 버튼을 누르면 flpnlDetail이 사라졌다가 다시 서서히 나타납니다.
		//패널 영역 내의 버튼 활성화 시 동작을 정의한 함수입니다.
		//먼저 버튼이 소속된 Area 내에 다른 버튼이 활성화 되어 있다면 그 버튼을 원래 상태로 되돌리고, 
		//현재 누른 버튼에 색상을 적용합니다.
		//
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

        private void btnWayToggle_countryside_Click(object sender, EventArgs e)
        {
			ActivateButton(pnlWayToggle, sender);
		}

        private void btnWayToggle_Express_Click_1(object sender, EventArgs e)
        {
			ActivateButton(pnlWayToggle, sender);
		}

        private void btnWayToggle_Single_Click(object sender, EventArgs e)
        {
			ActivateButton(panel1, sender);
			dateTimePicker2.Visible = false;
			dep2.Visible = false;
			dep2_2.Visible = false;
			arr2.Visible = false;
			arr2_2.Visible = false;
			Back.Visible = false;

			isPress = true; 
			
			
			//직전에 누른 버튼이 지금 버튼과 다른 버튼이면
			if (currentButton != sender)
			{
				//보여진 패널(flpnDetail)을 바로 숨긴다(Size를 MinimumSize로 바꿔서).
				Button thisButton = (Button)sender;
				flpnlDetail.Size = flpnlDetail.MinimumSize;
				isCollapsed = true; //패널 닫혀있음 상태로 변경
			}
			ActivateButton(pnlBusMenu, sender);//현재 누른 버튼 활성화
			tmrPanelMove.Start();//타이머 작동 시작
		}

        private void btnWayToggle_RoundTrip_Click(object sender, EventArgs e)
        {
			isPress2 = true;

			ActivateButton(panel1, sender);
			//직전에 누른 버튼이 지금 버튼과 다른 버튼이면
			if (currentButton != sender)
			{
				//보여진 패널(flpnDetail)을 바로 숨긴다(Size를 MinimumSize로 바꿔서).
				Button thisButton = (Button)sender;
				flpnlDetail.Size = flpnlDetail.MinimumSize;
				isCollapsed = true; //패널 닫혀있음 상태로 변경
			}
			ActivateButton(pnlBusMenu, sender);//현재 누른 버튼 활성화
			tmrPanelMove.Start();//타이머 작동 시작
		}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
			Date.Text = dateTimePicker1.Value.ToString("yyyy.MM.dd");
		}

        private void button1_Click(object sender, EventArgs e)
        {
			// 고속버스 조회버튼
			// url - listview1

			string url = "http://openapi.tago.go.kr/openapi/service/ExpBusInfoService/getStrtpntAlocFndExpbusInfo";
			url += "?ServiceKey=" + "1VXfcTtiBFcGQqmRkAKkthAFG1yqLnMbGFVyVCUmvggx1r%2BAd9fJ%2BrLmMvw9kVk2D0wzqvNtHICgNCwOETfmkQ%3D%3D"; // Service Key
			url += "&numOfRows=10";
			url += "&pageNo=1";
			url += "&depTerminalId=" + temp; // temp -> 선택된터미널_콤보박스
			url += "&arrTerminalId=" + temp2; // temp -> 선택된터미널_콤보박스
			url += "&depPlandTime="  + dateTimePicker1.Value.ToString("yyyyMMdd");
		    //url += "&depPlandTime="  + dateTimePicker2.Value.ToString("yyyyMMdd");
			url += "&busGradeId=" + temp3;//   

			WebRequest wr = WebRequest.Create(url);
			wr.Method = "GET";

			WebResponse wrs = wr.GetResponse();
			Stream s = wrs.GetResponseStream();
			StreamReader sr = new StreamReader(s);
			string response = sr.ReadToEnd();

			XmlDocument xd = new XmlDocument();
			xd.LoadXml(response);

			XmlNode xn = xd["response"]["body"]["items"];

			// url2 - listview2

			string url2 = "http://openapi.tago.go.kr/openapi/service/ExpBusInfoService/getStrtpntAlocFndExpbusInfo";
			url2 += "?ServiceKey=" + "1VXfcTtiBFcGQqmRkAKkthAFG1yqLnMbGFVyVCUmvggx1r%2BAd9fJ%2BrLmMvw9kVk2D0wzqvNtHICgNCwOETfmkQ%3D%3D"; // Service Key
			url2 += "&numOfRows=10";
			url2 += "&pageNo=1";
			url2 += "&depTerminalId=" + temp2; // temp -> 선택된터미널_콤보박스
			url2 += "&arrTerminalId=" + temp; // temp -> 선택된터미널_콤보박스
			//url2 += "&depPlandTime=" + dateTimePicker1.Value.ToString("yyyyMMdd");
			url2 += "&depPlandTime=" + dateTimePicker2.Value.ToString("yyyyMMdd");
			url2 += "&busGradeId=" + temp3;//   

			WebRequest wr2 = WebRequest.Create(url2);
			wr2.Method = "GET";

			WebResponse wrs2 = wr2.GetResponse();
			Stream s2 = wrs2.GetResponseStream();
			StreamReader sr2 = new StreamReader(s2);
			string response2 = sr2.ReadToEnd();

			XmlDocument xd2 = new XmlDocument();
			xd2.LoadXml(response2);

			XmlNode xn2 = xd2["response"]["body"]["items"];

			/////////////// listView1
			listView1.Items.Clear();
			for (int i = 0; i < xn.ChildNodes.Count; i++)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = xn.ChildNodes[i]["gradeNm"].InnerText;
				lvi.SubItems.Add(xn.ChildNodes[i]["depPlandTime"].InnerText);
				lvi.SubItems.Add(xn.ChildNodes[i]["arrPlandTime"].InnerText);
				lvi.SubItems.Add(xn.ChildNodes[i]["depPlaceNm"].InnerText);
				lvi.SubItems.Add(xn.ChildNodes[i]["arrPlaceNm"].InnerText);
				lvi.SubItems.Add(xn.ChildNodes[i]["charge"].InnerText);

				listView1.Items.Add(lvi);

			}
			if (xn.ChildNodes.Count == 0) {
				ListViewItem lvi = new ListViewItem();
				lvi.Text = "None";
				lvi.SubItems.Add("None");
				lvi.SubItems.Add("None");
				lvi.SubItems.Add("None");
				lvi.SubItems.Add("None");
				lvi.SubItems.Add("None");
				listView1.Items.Add(lvi);
			}
			/////////////// listView2
			
			
			listView2.Items.Clear();
			for (int i = 0; i < xn2.ChildNodes.Count; i++)
			{
				ListViewItem lvi2 = new ListViewItem();
				lvi2.Text = xn2.ChildNodes[i]["gradeNm"].InnerText;
				lvi2.SubItems.Add(xn2.ChildNodes[i]["depPlandTime"].InnerText);
				lvi2.SubItems.Add(xn2.ChildNodes[i]["arrPlandTime"].InnerText);
				lvi2.SubItems.Add(xn2.ChildNodes[i]["depPlaceNm"].InnerText);
				lvi2.SubItems.Add(xn2.ChildNodes[i]["arrPlaceNm"].InnerText);
				lvi2.SubItems.Add(xn2.ChildNodes[i]["charge"].InnerText);

				listView2.Items.Add(lvi2);

			}
			if (xn2.ChildNodes.Count == 0)
			{
				ListViewItem lvi2 = new ListViewItem();
				lvi2.Text = "None";
				lvi2.SubItems.Add("None");
				lvi2.SubItems.Add("None");
				lvi2.SubItems.Add("None");
				lvi2.SubItems.Add("None");
				lvi2.SubItems.Add("None");
				listView2.Items.Add(lvi2);
			}
			
			flpnlDetail.Size = flpnlDetail.MinimumSize;
			isCollapsed = true; //패널 닫혀있음 상태로 변경

			if (isPress == true)                // 편도
			{
				listView1.Visible = true;
				label9.Visible = true;
				panel2.Visible = true;
			}
			else if (isPress2 == true)          // 왕복
			{
				listView1.Visible = true;
				listView2.Visible = true;
				label9.Visible = true;
				panel2.Visible = true;
				label10.Visible = true;
				panel3.Visible = true;
			}
		}

        private void dep1_SelectedIndexChanged(object sender, EventArgs e)
        {
			
			Departure.Text = dep1.SelectedItem.ToString();
			arr2.Text = dep1.SelectedItem.ToString();
			Depa.Text = dep1.SelectedItem.ToString();
			Dest2.Text = dep1.SelectedItem.ToString();

			string url = "http://openapi.tago.go.kr/openapi/service/ExpBusInfoService/getExpBusTrminlList"; // URL
			url += "?ServiceKey=" + "1VXfcTtiBFcGQqmRkAKkthAFG1yqLnMbGFVyVCUmvggx1r%2BAd9fJ%2BrLmMvw9kVk2D0wzqvNtHICgNCwOETfmkQ%3D%3D"; // Service Key
			url += "&numOfRows=10";
			url += "&pageNo=1";
			url += "&terminalNm=" + dep1.SelectedItem.ToString();

			WebRequest wr = WebRequest.Create(url);
			wr.Method = "GET";

			WebResponse wrs = wr.GetResponse();
			Stream s = wrs.GetResponseStream();
			StreamReader sr = new StreamReader(s);
			string response = sr.ReadToEnd();

			XmlDocument xd = new XmlDocument();
			xd.LoadXml(response);

			XmlNode xn = xd["response"]["body"]["items"];

			temp = xn.ChildNodes[0]["terminalId"].InnerText;
			
		}

        private void arr1_SelectedIndexChanged(object sender, EventArgs e)
        {
			Destination.Text = arr1.SelectedItem.ToString();
			dep2.Text = arr1.SelectedItem.ToString();
			Dest.Text = arr1.SelectedItem.ToString();
			Depa2.Text = arr1.SelectedItem.ToString();

			string url = "http://openapi.tago.go.kr/openapi/service/ExpBusInfoService/getExpBusTrminlList"; // URL
			url += "?ServiceKey=" + "1VXfcTtiBFcGQqmRkAKkthAFG1yqLnMbGFVyVCUmvggx1r%2BAd9fJ%2BrLmMvw9kVk2D0wzqvNtHICgNCwOETfmkQ%3D%3D"; // Service Key
			url += "&numOfRows=10";
			url += "&pageNo=1";
			url += "&terminalNm=" + arr1.SelectedItem.ToString();

			WebRequest wr = WebRequest.Create(url);
			wr.Method = "GET";

			WebResponse wrs = wr.GetResponse();
			Stream s = wrs.GetResponseStream();
			StreamReader sr = new StreamReader(s);
			string response = sr.ReadToEnd();

			XmlDocument xd = new XmlDocument();
			xd.LoadXml(response);

			XmlNode xn = xd["response"]["body"]["items"];

			temp2 = xn.ChildNodes[0]["terminalId"].InnerText;
		
		}

        private void BusGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
			Grad.Text = BusGrade.SelectedItem.ToString();
			Grad2.Text = BusGrade.SelectedItem.ToString();

			Hashtable ht = new Hashtable();
			ht.Add("우등", "1");
			ht.Add("고속", "2");
			ht.Add("심야우등", "3");
			ht.Add("심야고속", "4");
			ht.Add("일반", "5");
			ht.Add("일반심야", "6");
			ht.Add("프리미엄", "7");
			ht.Add("심야프리미엄", "8");
			


			temp3 = (string)ht[BusGrade.SelectedItem.ToString()];

		}

        private void button2_Click(object sender, EventArgs e)
        {
			
			//시외버스 조회버튼

			string url = "http://openapi.tago.go.kr/openapi/service/SuburbsBusInfoService/getStrtpntAlocFndSuberbsBusInfo"; // URL
			url += "?ServiceKey=" + "1VXfcTtiBFcGQqmRkAKkthAFG1yqLnMbGFVyVCUmvggx1r%2BAd9fJ%2BrLmMvw9kVk2D0wzqvNtHICgNCwOETfmkQ%3D%3D"; // Service Key
			url += "&numOfRows=10";
			url += "&pageNo=1";
			url += "&depTerminalId=" + temp_2;
			url += "&arrTerminalId=" + temp2_2;
			url += "&depPlandTime=" + dateTimePicker1.Value.ToString("yyyyMMdd");
			url += "&busGradeId=" + temp3_2;

			WebRequest wr = WebRequest.Create(url);
			wr.Method = "GET";

			WebResponse wrs = wr.GetResponse();
			Stream s = wrs.GetResponseStream();
			StreamReader sr = new StreamReader(s);
			string response = sr.ReadToEnd();

			XmlDocument xd = new XmlDocument();
			xd.LoadXml(response);

			XmlNode xn = xd["response"]["body"]["items"];

			// url2 - listview2

			string url2 = "http://openapi.tago.go.kr/openapi/service/SuburbsBusInfoService/getStrtpntAlocFndSuberbsBusInfo"; // URL
			url2 += "?ServiceKey=" + "1VXfcTtiBFcGQqmRkAKkthAFG1yqLnMbGFVyVCUmvggx1r%2BAd9fJ%2BrLmMvw9kVk2D0wzqvNtHICgNCwOETfmkQ%3D%3D"; // Service Key
			url2 += "&numOfRows=10";
			url2 += "&pageNo=1";
			url2 += "&depTerminalId=" + temp2_2;
			url2 += "&arrTerminalId=" + temp_2;
			url2 += "&depPlandTime=" + dateTimePicker1.Value.ToString("yyyyMMdd");
			url2 += "&busGradeId=" + temp3_2;

			WebRequest wr2 = WebRequest.Create(url2);
			wr2.Method = "GET";

			WebResponse wrs2 = wr2.GetResponse();
			Stream s2 = wrs2.GetResponseStream();
			StreamReader sr2 = new StreamReader(s2);
			string response2 = sr2.ReadToEnd();

			XmlDocument xd2 = new XmlDocument();
			xd2.LoadXml(response2);

			XmlNode xn2 = xd2["response"]["body"]["items"];

			/////////////// listView1
			listView1.Items.Clear();
			for (int i = 0; i < xn.ChildNodes.Count; i++)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = xn.ChildNodes[i]["gradeNm"].InnerText;
				lvi.SubItems.Add(xn.ChildNodes[i]["depPlandTime"].InnerText);
				lvi.SubItems.Add(xn.ChildNodes[i]["arrPlandTime"].InnerText);
				lvi.SubItems.Add(xn.ChildNodes[i]["depPlaceNm"].InnerText);
				lvi.SubItems.Add(xn.ChildNodes[i]["arrPlaceNm"].InnerText);
				lvi.SubItems.Add(xn.ChildNodes[i]["charge"].InnerText);

				listView1.Items.Add(lvi);

			}
			if (xn.ChildNodes.Count == 0)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = "None";
				lvi.SubItems.Add("None");
				lvi.SubItems.Add("None");
				lvi.SubItems.Add("None");
				lvi.SubItems.Add("None");
				lvi.SubItems.Add("None");
				listView1.Items.Add(lvi);
			}
			/////////////// listView2


			listView2.Items.Clear();
			for (int i = 0; i < xn2.ChildNodes.Count; i++)
			{
				ListViewItem lvi2 = new ListViewItem();
				lvi2.Text = xn2.ChildNodes[i]["gradeNm"].InnerText;
				lvi2.SubItems.Add(xn2.ChildNodes[i]["depPlandTime"].InnerText);
				lvi2.SubItems.Add(xn2.ChildNodes[i]["arrPlandTime"].InnerText);
				lvi2.SubItems.Add(xn2.ChildNodes[i]["depPlaceNm"].InnerText);
				lvi2.SubItems.Add(xn2.ChildNodes[i]["arrPlaceNm"].InnerText);
				lvi2.SubItems.Add(xn2.ChildNodes[i]["charge"].InnerText);

				listView2.Items.Add(lvi2);

			}
			if (xn2.ChildNodes.Count == 0)
			{
				ListViewItem lvi2 = new ListViewItem();
				lvi2.Text = "None";
				lvi2.SubItems.Add("None");
				lvi2.SubItems.Add("None");
				lvi2.SubItems.Add("None");
				lvi2.SubItems.Add("None");
				lvi2.SubItems.Add("None");
				listView2.Items.Add(lvi2);
			}

			flpnlDetail.Size = flpnlDetail.MinimumSize;
			isCollapsed = true; //패널 닫혀있음 상태로 변경


			if (isPress == true)                // 편도
			{
				listView1.Visible = true;
				label9.Visible = true;
				panel2.Visible = true;
			}
			else if (isPress2 == true)          // 왕복
			{
				listView1.Visible = true;
				listView2.Visible = true;
				label9.Visible = true;
				panel2.Visible = true;
				label10.Visible = true;
				panel3.Visible = true;
			}		
		}
		
		private void dep1_2_SelectedIndexChanged(object sender, EventArgs e)
        {
			
			arr2_2.Text = dep1_2.SelectedItem.ToString();
			Departure.Text = dep1_2.SelectedItem.ToString();
			Depa.Text = dep1_2.SelectedItem.ToString();
			Dest2.Text = dep1_2.SelectedItem.ToString();

			string url = "http://openapi.tago.go.kr/openapi/service/SuburbsBusInfoService/getSuberbsBusTrminlList"; // URL
			url += "?ServiceKey=" + "1VXfcTtiBFcGQqmRkAKkthAFG1yqLnMbGFVyVCUmvggx1r%2BAd9fJ%2BrLmMvw9kVk2D0wzqvNtHICgNCwOETfmkQ%3D%3D"; // Service Key
			url += "&numOfRows=10";
			url += "&pageNo=1";
			url += "&terminalNm=" + dep1_2.SelectedItem.ToString();

			WebRequest wr = WebRequest.Create(url);
			wr.Method = "GET";

			WebResponse wrs = wr.GetResponse();
			Stream s = wrs.GetResponseStream();
			StreamReader sr = new StreamReader(s);
			string response = sr.ReadToEnd();

			XmlDocument xd = new XmlDocument();
			xd.LoadXml(response);

			XmlNode xn = xd["response"]["body"]["items"];

			temp_2 = xn.ChildNodes[0]["terminalId"].InnerText;
			Console.WriteLine(xn.ChildNodes[0]["terminalId"].InnerText);
			
			///////////
			string url2 = "http://openapi.tago.go.kr/openapi/service/SuburbsBusInfoService/getTrminlAcctoSuberbsBusInfo"; // URL
			url2 += "?ServiceKey=" + "1VXfcTtiBFcGQqmRkAKkthAFG1yqLnMbGFVyVCUmvggx1r%2BAd9fJ%2BrLmMvw9kVk2D0wzqvNtHICgNCwOETfmkQ%3D%3D"; // Service Key
			url2 += "&numOfRows=10";
			url2 += "&pageNo=1";
			url2 += "&terminalId=" + temp_2;
			url2 += "&depPlandTime=" + dateTimePicker1.Value.ToString("yyyyMMdd");

			WebRequest wr2 = WebRequest.Create(url2);
			wr2.Method = "GET";

			WebResponse wrs2 = wr2.GetResponse();
			Stream s2 = wrs2.GetResponseStream();
			StreamReader sr2 = new StreamReader(s2);
			string response2 = sr2.ReadToEnd();

			XmlDocument xd2 = new XmlDocument();
			xd2.LoadXml(response2);

			XmlNode xn2 = xd2["response"]["body"]["items"];


			List<string> listData = new List<string>();
			listData.Clear();
			for (int i = 0; i < xn2.ChildNodes.Count; i++)
			{
				listData.Add(xn2.ChildNodes[i]["arrPlaceNm"].InnerText);

				listData = listData.Distinct().ToList();

				arr1_2.Items.Clear();
				arr1_2.Items.AddRange(listData.ToArray());
			}			
		}

		private void arr1_2_SelectedIndexChanged(object sender, EventArgs e)
        {
			
			dep2_2.Text = arr1_2.SelectedItem.ToString();
			Destination.Text = arr1_2.SelectedItem.ToString();
			Dest.Text = arr1_2.SelectedItem.ToString();
			Depa2.Text = arr1_2.SelectedItem.ToString();

			string url = "http://openapi.tago.go.kr/openapi/service/SuburbsBusInfoService/getSuberbsBusTrminlList"; // URL
			url += "?ServiceKey=" + "1VXfcTtiBFcGQqmRkAKkthAFG1yqLnMbGFVyVCUmvggx1r%2BAd9fJ%2BrLmMvw9kVk2D0wzqvNtHICgNCwOETfmkQ%3D%3D"; // Service Key
			url += "&terminalNm="+ arr1_2.SelectedItem.ToString(); 
			

			WebRequest wr = WebRequest.Create(url);
			wr.Method = "GET";

			WebResponse wrs = wr.GetResponse();
			Stream s = wrs.GetResponseStream();
			StreamReader sr = new StreamReader(s);
			string response = sr.ReadToEnd();

			XmlDocument xd = new XmlDocument();
			xd.LoadXml(response);

			XmlNode xn = xd["response"]["body"]["items"];

			for (int i = 0; i < xn.ChildNodes.Count; i++)
			{
				if (xn.ChildNodes[i]["terminalNm"].InnerText == arr1_2.SelectedItem.ToString()) {
					temp2_2 = xn.ChildNodes[i]["terminalId"].InnerText;
					Console.WriteLine(xn.ChildNodes[i]["terminalId"].InnerText);
				}
			}			
		}

        private void BusGrade_2_SelectedIndexChanged(object sender, EventArgs e)
        {
			Grad.Text = BusGrade_2.SelectedItem.ToString();
			Grad2.Text = BusGrade_2.SelectedItem.ToString();

			Hashtable ht2 = new Hashtable();
			ht2.Add("프리미엄", "IDB");
			ht2.Add("일반", "IDG");
			ht2.Add("우등", "IDP");
			ht2.Add("주말프리", "IDW");
			ht2.Add("심야프리", "INB");
			ht2.Add("심야일반", "ING");
			ht2.Add("심야우등", "INP");
			ht2.Add("주말심프", "INW");
	
			

			temp3_2 = (string)ht2[BusGrade_2.SelectedItem.ToString()];
			Console.WriteLine((string)ht2[BusGrade_2.SelectedItem.ToString()]);
			

		}

        private void pnlBusMenu_Paint(object sender, PaintEventArgs e)
        {
			listView1.Visible = false;
			listView2.Visible = false;
			label9.Visible = false;
			label10.Visible = false;
			panel2.Visible = false;
			panel3.Visible = false;
			Date.Text = DateTime.Now.ToString("yyyy.MM.dd");
			Date2.Text = DateTime.Now.ToString("yyyy.MM.dd");
		}
	
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
			Date2.Text = dateTimePicker2.Value.ToString("yyyy.MM.dd");
		}   
    }
}

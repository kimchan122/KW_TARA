using Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms.Plane {
	public partial class FormPlane : Form {
		PlaneAPI api = new PlaneAPI();
		List<FlightInfo.Flight> leaves;
		List<FlightInfo.Flight> returns;
		List<FlightInfo.Airline> airlines;
		List<FlightInfo.Airport> airports;
		private Button currentButton;

		//동적 패널의 펼침과 접힘 상태를 나타내는 토큰
		bool[] isCollapsed;
		
		public FormPlane() {
			InitializeComponent();

			airlines = api.getAirlineList();
			airports = api.getAirportList();

			isCollapsed = new bool[3] { true, true, true };

		}

		private void FormPlane_Load(object sender, EventArgs e) {
			//LoadTheme(tpnlResults);

			fillAirportButtons();
			pnlDepAirports.Size = pnlDepAirports.MinimumSize;
			pnlArrAirports.Size = pnlArrAirports.MinimumSize;

			pnlDetails.Width = 0; //flow layout panel 숨기기
			DisablePanel(pnlDetails);

			pnlDetails.Visible = true;
			pnlDetails.BringToFront();
		}

		/* 티켓 경로를 선택하는 버튼의 클릭에 대한 동작 */
		//왕복, 편도 두 개의 버튼이 있으며, pnlPlaneMenu > pnlWayToggle 내에 있습니다.
		private void btnCourse_RoundTrip_Click(object sender, EventArgs e) {
			ActivateButton(pnlCourse, sender);
			if(btnOptions_Date.BackColor == ThemeColor.PrimaryColor) {
				if (pnlDetail_Date.Height != pnlDetail_Date.MaximumSize.Height) {
					pnlDetail_Date.Height = pnlDetail_Date.MaximumSize.Height;
				}
			}
			tpnlResults.GetControlFromPosition(1, 0).Visible = true;
			tpnlResults.GetControlFromPosition(1, 1).Visible = true;
		}

		private void btnCourse_Single_Click(object sender, EventArgs e) {
			ActivateButton(pnlCourse, sender);
			if (btnOptions_Date.BackColor == ThemeColor.PrimaryColor) {
				if (pnlDetail_Date.Height != (pnlDetail_Date.MaximumSize.Height) / 2) {
					pnlDetail_Date.Height = (pnlDetail_Date.MaximumSize.Height / 2);
				}
			}
			tpnlResults.GetControlFromPosition(1, 0).Visible = false;
			tpnlResults.GetControlFromPosition(1, 1).Visible = false;
		}

		/* 출발지, 도착지, 인원, 좌석 등급을 설정하는 버튼의 클릭에 대한 동작 */
		//각 버튼은 pnlPlaneMenu 내에 있습니다.
		//각 버튼을 누르면 (FlowLayoutPanel)flpnlDetail 패널이 서서히 나타납니다.
		//패널의 보이기 동작은 (Timer)tmrPanelMove 에 의해 패널의 크기를 조정하는 식으로
		//구현하였습니다.
		//한 버튼을 누르고 다른 버튼을 누르면 flpnlDetail이 사라졌다가 다시 서서히 나타납니다.
		private void btnOptions_Departure_Click(object sender, EventArgs e)
		{
			//직전에 누른 버튼이 지금 버튼과 다른 버튼이면
			if (currentButton != sender)
			{
				//보여진 패널(flpnDetail)을 바로 숨긴다(Size를 MinimumSize로 바꿔서).
				pnlDetails.Width = 0;
				isCollapsed[0] = true;
				pnlArrAirports.Size = pnlArrAirports.MinimumSize;
				isCollapsed[2] = true;
			}
			ActivateButton(pnlOptions, sender);//현재 누른 버튼 활성화
			DisablePanel(pnlDetails);
			pnlDetail_Departure.Size = pnlDetail_Departure.MaximumSize;

			tmrDetailsPanel_Move.Start();//타이머 작동 시작
		}

		private void btnOptions_Arrival_Click(object sender, EventArgs e)
		{
			if (currentButton != sender)
			{
				pnlDetails.Width = 0;
				isCollapsed[0] = true;
				pnlDepAirports.Size = pnlDepAirports.MinimumSize;
				isCollapsed[1] = true;

			}
			ActivateButton(pnlOptions, sender);
			DisablePanel(pnlDetails);
			pnlDetail_Arrival.Size = pnlDetail_Arrival.MaximumSize;
			tmrDetailsPanel_Move.Start();
		}

		private void btnOptions_Date_Click(object sender, EventArgs e) {
			if (currentButton != sender) {
				pnlDetails.Width = 0;
				isCollapsed[0] = true;
			}
			ActivateButton(pnlOptions, sender);
			DisablePanel(pnlDetails);
			if (btnCourse_Single.BackColor == ThemeColor.PrimaryColor) {
				pnlDetail_Date.Height = (pnlDetail_Date.MaximumSize.Height) / 2;
			} else {
				pnlDetail_Date.Height = pnlDetail_Date.MaximumSize.Height;
			}

			tmrDetailsPanel_Move.Start();
		}

		private void btnOptions_SeatClass_Click(object sender, EventArgs e)
		{
			if (currentButton != sender)
			{
				pnlDetails.Width = 0;
				isCollapsed[0] = true;
			}
			ActivateButton(pnlOptions, sender);
			DisablePanel(pnlDetails);
			pnlDetail_SeatClass.Size = pnlDetail_SeatClass.MaximumSize;
			tmrDetailsPanel_Move.Start();
		}

		/* 출발지와 도착지 옵션 안에 있는 출발/도착 공항 보기 버튼을 클릭할때의 동작 */
		private void btnShowDepAirports_Click(object sender, EventArgs e) {
			pnlArrAirports.Size = pnlArrAirports.MinimumSize;
			isCollapsed[2] = true;
			tmrAirportsPanel_Move.Start();
		}

		private void btnShowArrAirports_Click(object sender, EventArgs e) {
			pnlDepAirports.Size = pnlDepAirports.MinimumSize;
			isCollapsed[1] = true;
			tmrAirportsPanel_Move.Start();
		}

		//출발지, 도착지에서 공항 이름 버튼을 눌렀을 때의 동작을 정의하는 함수입니다.
		private void btnAirportName_Click(object sender, EventArgs e) {
			Button btn = (Button)sender;
			if (isCollapsed[1] == false) {
				ActivateButton(tpnlDepAirports, btn);
				txtDepAirport_Name.Text = btn.Text;
				txtDepAirport_Name.ForeColor = Color.Black;
			} else if (isCollapsed[2] == false) {
				ActivateButton(tpnlArrAirports, btn);
				txtArrAirport_Name.Text = btn.Text;
				txtArrAirport_Name.ForeColor = Color.Black;
			}
		}

		/* 타이머가 동작할 때의 동작을 정의하고 있는 함수 */
		//	타이머가 동작하면(.Start()), 타이머가 정지할 때까지 지정된 단위 시간마다 이 함수가 호출됩니다(단위 시간 변경 : 속성 -> Interval).
		//
		private void tmrDetailsPanel_Move_Tick(object sender, EventArgs e) {
			//패널이 닫혀있으면
			if (isCollapsed[0] == true) {//pnlDetails가 닫혀있으면
				pnlDetails.Width += 20;
				if (pnlDetails.Width == 350) {//최대 크기에 도달하면
					isCollapsed[0] = false;
					tmrDetailsPanel_Move.Stop(); //타이머 정지
				}
			} else {
				pnlDetails.Width -= 20;
				if (pnlDetails.Width == 0) {
					isCollapsed[0] = true;
					tmrDetailsPanel_Move.Stop();
				}
			}
		}

		private void tmrAirportsPanel_Move_Tick(object sender, EventArgs e) {
			if (pnlDetail_Departure.Size != pnlDetail_Departure.MinimumSize) {	//pnlDetail_Departure이 열려 있으면
				if (isCollapsed[1] == true) {//pnlDepAirports가 닫혀 있으면
					pnlDepAirports.Height += 20;
					if (pnlDepAirports.Size == pnlDepAirports.MaximumSize) {
						tmrAirportsPanel_Move.Stop();
						isCollapsed[1] = false;
					}
				} else {//pnlDepAirports가 열려 있으면
					pnlDepAirports.Height -= 20;
					if (pnlDepAirports.Size == pnlDepAirports.MinimumSize) {
						tmrAirportsPanel_Move.Stop();
						isCollapsed[1] = true;
					}
				}
			} 
			else {  //pnlDetail_Arrival이 열려 있으면
				if (isCollapsed[2] == true) {//pnlDepAirports가 닫혀 있으면
					pnlArrAirports.Height += 20;
					if (pnlArrAirports.Size == pnlArrAirports.MaximumSize) {
						tmrAirportsPanel_Move.Stop();
						isCollapsed[2] = false;
					}
				} else {//pnlDepAirports가 열려 있으면
					pnlArrAirports.Height -= 20;
					if (pnlArrAirports.Size == pnlArrAirports.MinimumSize) {
						tmrAirportsPanel_Move.Stop();
						isCollapsed[2] = true;
					}
				}
			}
		}

		/* tpnlDepAirPorts와 tpnlArrAirports 안에 airports의 원소 이름을 가진 버튼들을 채우는 함수 */
		private void fillAirportButtons() {
			tpnlDepAirports.RowCount = (int)Math.Ceiling(((decimal)airports.Count) / 4);
			tpnlArrAirports.RowCount = tpnlDepAirports.RowCount;
			tpnlDepAirports.ColumnCount = 4;
			tpnlArrAirports.ColumnCount = tpnlDepAirports.ColumnCount;

			for (int i = 0; i < airports.Count; i++) {
				Button btn1 = new Button();
				Button btn2 = new Button();
				btn1.Text = airports[i].공항이름;
				btn2.Text = btn1.Text;
				btn1.Size = new Size(80, 40);
				btn2.Size = new Size(80, 40);
				btn1.Dock = DockStyle.Fill;
				btn2.Dock = DockStyle.Fill;
				btn1.FlatStyle = FlatStyle.Flat;
				btn2.FlatStyle = FlatStyle.Flat;
				btn1.FlatAppearance.BorderSize = 0;
				btn2.FlatAppearance.BorderSize = 0;
				btn1.Click += new EventHandler(btnAirportName_Click);
				btn2.Click += new EventHandler(btnAirportName_Click);
				tpnlDepAirports.Controls.Add(btn1, i % 4, i / 4);
				tpnlArrAirports.Controls.Add(btn2, i % 4, i / 4);
			}
		}
		
		/* 패널의 모든 요소들의 Height을 0으로 만들어 숨기는 함수*/
		private void DisablePanel(Panel Area) {
			foreach (Control pnl in Area.Controls) {
				if (pnl.GetType() == typeof(Panel)) {
					pnl.Size = pnl.MinimumSize;
				}
			}
		}

		/* 패널 영역 내의 버튼 활성화 시 동작을 정의한 함수 */
		//먼저 버튼이 소속된 Area 내에 다른 버튼이 활성화 되어 있다면 그 버튼을 원래 상태로 되돌리고, 
		//현재 누른 버튼에 색상을 적용합니다.
		private void ActivateButton(Panel Area, object btnSender) {
			if (btnSender != null) {
				if (currentButton != (Button)btnSender) { //선택한 버튼과 다른 버튼이 인자로 들어왔으면
					DisableButton(Area);  //버튼을 초기 상태로 되돌림

					currentButton = (Button)btnSender;  //현재 버튼을 currentButton에 저장
					currentButton.BackColor = ThemeColor.PrimaryColor;
					currentButton.ForeColor = Color.White;
					currentButton.Font = new System.Drawing.Font("서울남산체 B", Area.Font.Size, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
				}
			}
		}

		/* 패널 내 모든 버튼들의 스타일을 원래대로 되돌리는 함수 */
		private void DisableButton(Panel Area) {
			foreach (Control previousBtn in Area.Controls) { //패널 내의 모든 콘트롤 객체 탐색
				if (previousBtn.GetType() == typeof(Button)) {   //버튼이면 스타일 초기화
					previousBtn.BackColor = Color.Transparent;
					previousBtn.ForeColor = Color.White;
					previousBtn.Font = new System.Drawing.Font("서울남산체 B", Area.Font.Size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
				}
			}
		}

		/* 패널의 색상테마를 적용하는 함수 */
		//	현재 폼의 콘트롤 객체들을 모두 탐색하면서, 콘트롤 객체의 종류마다 다른 스타일을
		//	적용할 수 있습니다.	
		//예를 들어 콘트롤 객체가 버튼일 경우(typeof(Button)),
		//	배경은 PrimaryColor, 테두리는 SecondaryColor로 지정하고,
		//	라벨일 경우에는 글자색을 SecondaryColor로 지정하는 식의 로직입니다.
		private void LoadTheme(Panel pnl) {
			foreach (Control ctrls in pnl.Controls) {   //콘트롤 객체 탐색
				if (ctrls.GetType() == typeof(Button)) {   //버튼일 경우
					Button btn = (Button)ctrls;
					btn.BackColor = ThemeColor.PrimaryColor;
					btn.ForeColor = Color.White;
					btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
				} else if (ctrls.GetType() == typeof(Label)) { //라벨일 경우
					Label lbl = (Label)ctrls;
					lbl.ForeColor = ThemeColor.SecondaryColor;
				}
				/**
				 * 다른 컨트롤 객체들도 테마 적용하시려면 여기에 조건문을 추가하시면 됩니다.
				 *	ctrls.GetType()이 typeof(아이템 이름(ex.Panel, Textbox,...))과 일치하면
				 *	해당 아이템 객체 선언하시고
				 *	PrimaryColor나 SecondaryColor로 컬러 속성 변경하는 식입니다.
				 **/
			}
		}

		private void txtDepAirport_Name_Click(object sender, EventArgs e) {
			txtDepAirport_Name.Text = "";
			txtDepAirport_Name.ForeColor = Color.Black;
		}

		private void txtArrAirport_Name_Click(object sender, EventArgs e) {
			txtArrAirport_Name.Text = "";
			txtArrAirport_Name.ForeColor = Color.Black;
		}

		private void btnDetail_SeatClass_Economy_Click(object sender, EventArgs e) {
			ActivateButton(pnlDetail_SeatClass, sender);
		}

		private void btnDetail_SeatClass_Business_Click(object sender, EventArgs e) {
			ActivateButton(pnlDetail_SeatClass, sender);
		}

		private void pnlResults_Click(object sender, EventArgs e) {
			if(pnlDetails.Width != 0)
				tmrDetailsPanel_Move.Start();
		}

	}
}

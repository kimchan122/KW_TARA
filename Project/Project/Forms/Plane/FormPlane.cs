using Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project.Forms.Plane.FlightInfo;

namespace Project.Forms.Plane {
	[Flags]
	/* 사용자 의 조건 설정에 따른 결과 화면 내용의 업데이트 사항을 나타낸 Flags enum입니다. */
	public enum ResultContentState {
		upToDate = 0,       //최신 상태
		Dep_Old = 1,				//출발공항 업데이트 필요
		Arr_Old = 2,        //도착공항 업데이트 필요
		leaveDate_Old = 4,  //가는 날짜의 업데이트 필요
		returnDate_Old = 8, //오는 날짜의 업데이트 필요
		airline_Old = 16,		//항공사 업데이트 필요
	}

	public partial class FormPlane : Form {
		PlaneAPI apiLeave = new PlaneAPI();					//가는 날의 항공편 정보를 받아올 api입니다.
		PlaneAPI apiReturn = new PlaneAPI();				//오는 날의 항공편 정보를 받아올 api입니다.
		List<Flight> leaves = new List<Flight>();		//가는 날 항공편 정보
		List<Flight> returns = new List<Flight>();  //오는 날 항공편 정보
		List<Airline> airlines;											//전체 항공사 이름
		List<Airport> airports;											//전체 공항 이름

		/* -----[ FormPlane의 동적 변화 상태를 저장하는 필드입니다. ]----- */

		/* 사용자가 직전에 누른 버튼 */
		private Button currentButton = new Button();
		/* 현재 결과창에 보여진 항공사 */
		Airline currentAirLine = new Airline();
		/* 동적 패널의 펼침과 접힘 상태를 나타내는 토큰
		 isCollapsed[0] = pnlDetails 
		            [1] = pnlDepAirports 
		            [2] = pnlArrAirports
		*/
		bool[] isCollapsed = new bool[3] { true, true, true };
		/* 결과창 업데이트 필요 사항 */
		ResultContentState updateChecker;



		/* -----[ FormPlane의 생성자입니다. ]----- */
		public FormPlane() {
			InitializeComponent();
			/** api에서 공항 목록, 항공사 목록 불러오기 **/
			airlines = apiLeave.getAirlineList();
			airports = apiLeave.getAirportList();

			/** 출발 공항, 도착 공항 버튼들 채우고, 최소화한 상태로 초기화 **/
			fillAirportButtons();
			fillAirlineButtons();
			DisablePanel(pnlDetails);
			pnlDetails.Width = 0;
			pnlDetails.BringToFront();

			/** FormPlane의 결과 화면 초기화
			  [초기값]
			  출발공항 : 김포
			  도착공항 : 제주
			  가는날/오는날 : 오늘
				항공사 : 대한항공
			**/
			currentAirLine.항공사명 = "대한항공";
			updateChecker = new ResultContentState();
			updateResultArea(ResultContentState.Dep_Old | ResultContentState.Arr_Old | ResultContentState.returnDate_Old | ResultContentState.leaveDate_Old | ResultContentState.airline_Old);
		}



		/* -----[ 왕복/편도, 출발지, 도착지, 날짜, 좌석 등급 버튼의 클릭에 대한 동작입니다. ]-----  */

		/* "왕복", "편도" 버튼의 클릭에 대한 동작 */
		private void btnCourseName_Click(object sender, EventArgs e) {
			Button btn = sender as Button;
			ActivateButton(pnlCourse, btn);
			/**
			 날짜 버튼이 눌려 있어 pnlDetails가 열려 있는 상태일 경우,
			 오는 날짜 선택 부분을 숨겨 가는 날짜만 선택할 수 있도록 합니다.
			**/
			int showRange = pnlDetail_Date.MaximumSize.Height;
			showRange = (isButtonActivated(btnCourse_RoundTrip)) ? showRange : showRange / 2;
			if (isButtonActivated(btnOptions_Date)) pnlDetail_Date.Height = showRange;

			//결과 영역의 출력 범위 조정
			bool visibleToken = isButtonActivated(btnCourse_RoundTrip);
			for (int i = 0; i < tpnlResults.RowCount; i++)
				tpnlResults.GetControlFromPosition(1, i).Visible = visibleToken;
		}
		/* "출발지" 버튼의 클릭에 대한 동작 */
		private void btnOptions_Departure_Click(object sender, EventArgs e) {
			/** 이전에 누른 버튼이 다른 버튼이면, pnlDetails 초기화 
				1. pnlDetails를 안보임 상태로 변경
				2. pnlDetails의 가로 폭을 0으로 변경
				3. pnlDetail의 상태를 닫힘 상태로 변경
				4. pnlDetails의 내용의 세로 폭을 모두 0으로 변경
			**/
			if (currentButton != sender) {
				pnlDetails.Visible = false;
				pnlDetails.Width = 0;
				isCollapsed[0] = true;
				
				DisablePanel(pnlDetails);
			}
			
			/** 버튼 활성화 
			**/
			ActivateButton(pnlOptions, sender);

			btnShowDepAirports.Image = imgArrow.Images[0];
			pnlDepAirports.Height = pnlArrAirports.Height = 0;
			isCollapsed[1] = isCollapsed[2] = true;

			/** 초기화가 완료된 pnlDetails의 동작을 시작
				pnlDetails를 보임 상태로 변경
				pnlDetails가 서서히 나타나도록 타이머 시작
			**/
			pnlDetail_Departure.Size = pnlDetail_Departure.MaximumSize;
			pnlDetails.Visible = true;
			tmrDetailsPanel_Move.Start();
		}
		/* "도착지" 버튼의 클릭에 대한 동작 */
		private void btnOptions_Arrival_Click(object sender, EventArgs e)
		{
			/** 이전에 누른 버튼이 다른 버튼이면, pnlDetails 초기화 
				1. pnlDetails를 안보임 상태로 변경
				2. pnlDetails의 가로 폭을 0으로 변경
				3. pnlDetail의 상태를 닫힘 상태로 변경
				4. pnlDetails의 내용의 세로 폭을 모두 0으로 변경
			**/
			if (currentButton != sender) {
				pnlDetails.Visible = false;
				pnlDetails.Width = 0;
				isCollapsed[0] = true;
				DisablePanel(pnlDetails);
			}

			/** 버튼 활성화 
			**/
			ActivateButton(pnlOptions, sender);

			btnShowArrAirports.Image = imgArrow.Images[0];
			pnlDepAirports.Height = pnlArrAirports.Height = 0;
			isCollapsed[1] = isCollapsed[2] = true;

			/** 초기화가 완료된 pnlDetails의 동작을 시작
				pnlDetails를 보임 상태로 변경
				pnlDetails가 서서히 나타나도록 타이머 시작
			**/
			pnlDetail_Arrival.Size = pnlDetail_Arrival.MaximumSize;
			pnlDetails.Visible = true;
			tmrDetailsPanel_Move.Start();
		}
		/* "날짜" 버튼의 클릭에 대한 동작 */
		private void btnOptions_Date_Click(object sender, EventArgs e) {
			/** 이전에 누른 버튼이 다른 버튼이면, pnlDetails 초기화 
				1. pnlDetails를 안보임 상태로 변경
				2. pnlDetails의 가로 폭을 0으로 변경
				3. pnlDetails의 상태를 닫힘 상태로 변경
				4. pnlDetails의 내용의 세로 폭을 모두 0으로 변경
			**/
			if (currentButton != sender) {
				pnlDetails.Visible = false;
				pnlDetails.Width = 0;
				isCollapsed[0] = true;
				DisablePanel(pnlDetails);
			}

			/**왕복/편도 선택 상태에 따라서 세부 설정과 결과 화면에 보여줄 영역 지정
			  1. "왕복"/"편도" 모두 선택되지 않았을 경우
					- 메시지창 로드
				2. "왕복"을 선택한 상태인 경우
					- 가는 날짜 선택 컨트롤만 사용자에게 보임
					- 결과 화면에서 가는 날의 정보와 오는 날의 정보 모두를 사용자에게 보임
				3. "편도"를 선택한 상태인 경우
					- 가는 날짜 선택 컨트롤만 사용자에게 보임
					- 결과 화면에서 가는 날의 정보만 사용자에게 보임
			**/
			if (isButtonActivated(btnCourse_RoundTrip) == false) {
				if(isButtonActivated(btnCourse_Single) == false) {
					MessageBox.Show("왕복, 편도를 먼저 선택해주세요.");
					DisableButton(pnlOptions);
					return;

				} else pnlDetail_Date.Height = (pnlDetail_Date.MaximumSize.Height) / 2;

			} else pnlDetail_Date.Height = pnlDetail_Date.MaximumSize.Height;

			/** 버튼 활성화 
			**/
			ActivateButton(pnlOptions, sender);

			/** 초기화가 완료된 pnlDetails의 동작을 시작
				pnlDetails를 보임 상태로 변경
				pnlDetails가 서서히 나타나도록 타이머 시작
			**/
			pnlDetail_Date.Size = pnlDetail_Date.MaximumSize;
			pnlDetails.Visible = true;
			tmrDetailsPanel_Move.Start();
		}
		/* "좌석 등급" 버튼의 클릭에 대한 동작 */
		private void btnOptions_SeatClass_Click(object sender, EventArgs e) {
			/** 이전에 누른 버튼이 다른 버튼이면, pnlDetails 초기화 
				1. pnlDetails를 안보임 상태로 변경
				2. pnlDetails의 가로 폭을 0으로 변경
				3. pnlDetail의 상태를 닫힘 상태로 변경
				4. pnlDetails의 내용의 세로 폭을 모두 0으로 변경
			**/
			if (currentButton != sender) {
				pnlDetails.Visible = false;
				pnlDetails.Width = 0;
				isCollapsed[0] = true;
				DisablePanel(pnlDetails);
			}

			/** 버튼 활성화 
			**/
			ActivateButton(pnlOptions, sender);

			/** 초기화가 완료된 pnlDetails의 동작을 시작
				pnlDetails를 보임 상태로 변경
				pnlDetails가 서서히 나타나도록 타이머 시작
			**/
			pnlDetail_SeatClass.Size = pnlDetail_SeatClass.MaximumSize;
			pnlDetails.Visible = true;
			tmrDetailsPanel_Move.Start();
		}
		/* "항공사" 버튼의 클릭에 대한 동작 */
		private void btnOptions_Airline_Click(object sender, EventArgs e) {
			/** 이전에 누른 버튼이 다른 버튼이면, pnlDetails 초기화 
				1. pnlDetails를 안보임 상태로 변경
				2. pnlDetails의 가로 폭을 0으로 변경
				3. pnlDetail의 상태를 닫힘 상태로 변경
				4. pnlDetails의 내용의 세로 폭을 모두 0으로 변경
			**/
			if (currentButton != sender) {
				pnlDetails.Visible = false;
				pnlDetails.Width = 0;
				isCollapsed[0] = true;
				DisablePanel(pnlDetails);
			}

			/** 버튼 활성화 
			**/
			ActivateButton(pnlOptions, sender);

			/** 초기화가 완료된 pnlDetails의 동작을 시작
				pnlDetails를 보임 상태로 변경
				pnlDetails가 서서히 나타나도록 타이머 시작
			**/
			pnlDetail_Airlines.Size = pnlDetail_Airlines.MaximumSize;
			pnlDetails.Visible = true;
			tmrDetailsPanel_Move.Start();
		}



		/* -----[ 설정 버튼을 클릭하면 나오는 세부사항에 대한 컨트롤들의 동작입니다. ]----- */

		/* 아래 방향 화살표 " V " 버튼의 클릭에 대한 동작 */
		private void btnShowAirports_Click(object sender, EventArgs e) {
			/** 공항 목록 패널 움직이기 
			**/
			tmrAirportsPanel_Move.Start();
		}
		/* 공항 이름 버튼의 클릭에 대한 동작 */
		private void btnAirportName_Click(object sender, EventArgs e) {
			/**결과 화면 상단의 문자열에서 출발 공항과 도착 공항의 이름을 추출 
			**/
			string l_Dep = btnLeaveInfo.Text.Substring(0, 2),
				r_Dep = btnReturnInfo.Text.Substring(0, 2);

			/** 출발지/도착지의 업데이트 여부를 판단 
				1. 지금 누른 버튼이 출발공항일 때
					- 결과 화면의 출발지와 다른 버튼을 눌렀을 경우
					- 업데이트 플래그 추가
				2. 도착공항일 때
					-	결과 화면의 도착지와 다른 버튼을 눌렀을 경우
					- 업데이트 플래그 추가
			**/
			Button btn = sender as Button;
			if (isButtonActivated(btnOptions_Departure)) {	//"출발지" 버튼이 활성화되어 있는 상태면
				ActivateButton(tpnlDepAirports, btn);
				if (l_Dep != btn.Text)
					updateChecker |= ResultContentState.Dep_Old;
				/** TextBox에 공항 이름 추가, 색상 검정으로 변경 
				**/
				txtDepAirport_Name.Text = btn.Text;
				txtDepAirport_Name.ForeColor = Color.Black;
			}
			else {
				ActivateButton(tpnlArrAirports, btn);
				if (r_Dep != btn.Text)
					updateChecker |= ResultContentState.Arr_Old;
				/** TextBox에 공항 이름 추가, 색상 검정으로 변경 
				**/
				txtArrAirport_Name.Text = btn.Text;
				txtArrAirport_Name.ForeColor = Color.Black;
			}
		}
		/* "이코노미", "비즈니스" 버튼의 클릭에 대한 동작*/
		private void btnSeatClassName_Click(object sender, EventArgs e) {
			/** 버튼 활성화
			**/
			Button btn = sender as Button;
			ActivateButton(pnlDetail_SeatClass, btn);
			
			/** 선택한 좌석 등급 종류에 따라 결과화면의 열 머리 중 "요금"의 제목을 변경 
			 * **/
			if(isButtonActivated(btnDetail_SeatClass_Business)) {
				l_price.Text = r_price.Text = "요금(비즈니스석)";
			} else {
				l_price.Text = r_price.Text = "요금(이코노미석)";
			}
		}
		/* 항공사 이름 버튼의 클릭에 대한 동작 */
		private void btnAirlineName_Click(object sender, EventArgs e) {
			/** 버튼 활성화
			**/
			Button btn = sender as Button;
			ActivateButton(tpnlAirlines, btn);

			/** 항공사 업데이트 여부르 판단
				결과 화면의 항공사 정보와 다른 항공사를 선택했을 경우
				업데이트 플래그 추가
			**/
			if (currentAirLine.항공사명 != btn.Text) {
				updateChecker |= ResultContentState.airline_Old;
			}
		}


		/* -----[ 동적 패널의 움직임을 위한 타이머 동작을 정의하고 있는 함수입니다 ]----- */

		/* 세부 옵션 패널(pnlDetails)의 Width 변경 동작 */
		private void tmrDetailsPanel_Move_Tick(object sender, EventArgs e) {
			/** isCollapsed[0] 토큰의 값으로 Width의 증가/감소 판단
				1. isCollapsed[0] == true -> Detail 패널이 닫혀있으면 
				 - 최대 너비까지 너비 증가
				 - 너비 증가 완료 후 isCollapsed[0] 값을 반대(false)로 변경
				2. isCollapsed[0] == false -> Detail 패널이 열려있으면 
				 - 최소 너비까지 너비 감소
				 - 너비 감소 완료 후 isCollapsed[0] 값을 반대(true)로 변경
			**/
			if (isCollapsed[0] == true) {
				pnlDetails.Width += 20;
				if (pnlDetails.Width == 350) {//최대 크기에 도달하면
					isCollapsed[0] = false;	//토큰 변경
					tmrDetailsPanel_Move.Stop(); //타이머 정지
				}
			} 
			else {
				pnlDetails.Width -= 20;
				if (pnlDetails.Width == 0) {
					isCollapsed[0] = true;
					tmrDetailsPanel_Move.Stop();
				}
			}
		}
		/* 출발/도착 공항 목록 패널(pnlDepAirports, pnlArrAirports)의 Height 변경 동작 */
		private void tmrAirportsPanel_Move_Tick(object sender, EventArgs e) {
			//pnlDetail_Departure이 열려 있으면 (출발 공항 선택 중이라면)
			if (pnlDetail_Departure.Size != pnlDetail_Departure.MinimumSize) {	
				if (isCollapsed[1] == true) {//pnlDepAirports가 닫혀 있으면
					pnlDepAirports.Height += 20;
					if (pnlDepAirports.Size == pnlDepAirports.MaximumSize) {
						btnShowDepAirports.Image = imgArrow.Images[1];
						tmrAirportsPanel_Move.Stop();
						isCollapsed[1] = false;
					}
				} else {//pnlDepAirports가 열려 있으면
					pnlDepAirports.Height -= 20;
					if (pnlDepAirports.Size == pnlDepAirports.MinimumSize) {
						btnShowDepAirports.Image = imgArrow.Images[0];
						tmrAirportsPanel_Move.Stop();
						isCollapsed[1] = true;
					}
				}
			}
			//pnlDetail_Arrival이 열려 있으면 (도착 공항 선택 중이라면)
			else {  
				if (isCollapsed[2] == true) {//pnlArrAirports가 닫혀 있으면
					pnlArrAirports.Height += 20;
					if (pnlArrAirports.Size == pnlArrAirports.MaximumSize) {
						btnShowArrAirports.Image = imgArrow.Images[1];
						tmrAirportsPanel_Move.Stop();
						isCollapsed[2] = false;
					}
				} else {//pnlArrAirports가 열려 있으면
					pnlArrAirports.Height -= 20;
					if (pnlArrAirports.Size == pnlArrAirports.MinimumSize) {
						btnShowArrAirports.Image = imgArrow.Images[0];
						tmrAirportsPanel_Move.Stop();
						isCollapsed[2] = true;
					}
				}
			}
		}

		
		/* -----[ 동적으로 Control을 생성 또는 조작하는 함수입니다. ]----- */

		/* 공항 이름 버튼들을 채우는 함수 */
		private void fillAirportButtons() {
			/** 출발 공항 버튼과 도착 공항 버튼이 들어갈 두 TableLayoutPanel의 열과 행을 먼저 지정
				열의 갯수 : 4개
				행의 갯수 : 공항의 갯수를 4로 나눈 10진수형 몫의 올림값
			**/
			tpnlDepAirports.RowCount = tpnlArrAirports.RowCount
				= (int)Math.Ceiling(((decimal)airports.Count) / 4);
			tpnlDepAirports.ColumnCount = tpnlArrAirports.ColumnCount
				= 4;

			/** 새 버튼을 2개씩 생성하여 두 패널에 각각 추가 
				버튼 속성
					이름 : api에서 받아온 공항 이름
					크기 : 80 x 40 (pixel)
					배경색 : Transparent
					채우기 : Fill
					FlatStyle : Flat
					테두리선 : 0 (pixel)
					Click EventHandler : btnAirportName_Click
			**/
			for (int i = 0; i < airports.Count; i++) {
				Button btn1 = new Button(), 
					btn2 = new Button();
				btn1.Text = btn2.Text
					= airports[i].공항이름;
				btn1.Size = btn2.Size
					= new Size(80, 40);
				btn1.BackColor = btn2.BackColor
					= Color.Transparent;
				btn1.Dock = btn2.Dock
					= DockStyle.Fill;
				btn1.FlatStyle = btn2.FlatStyle
					= FlatStyle.Flat;
				btn1.FlatAppearance.BorderSize = btn2.FlatAppearance.BorderSize
					= 0;
				btn1.Click += new EventHandler(btnAirportName_Click);
				btn2.Click += new EventHandler(btnAirportName_Click);
				tpnlDepAirports.Controls.Add(btn1, i % 4, i / 4);
				tpnlArrAirports.Controls.Add(btn2, i % 4, i / 4);
			}
		}
		/* 항공사 이름 버튼들을 채우는 함수 */
		private void fillAirlineButtons() {
			/** 출발 공항 버튼과 도착 공항 버튼이 들어갈 두 TableLayoutPanel의 열과 행을 먼저 지정
				열의 갯수 : 1개
				행의 갯수 : 항공사 개수 + 1 (전체 선택 버튼)
			**/
			tpnlAirlines.ColumnCount = 1;
			tpnlAirlines.RowCount = airlines.Count + 1;

			for(int i = 0; i <= airlines.Count; i++) {
				Button btn = new Button();
				if(i == 0) {
					btn.Text = "< 전체 선택하기 >";
					btn.TextAlign = ContentAlignment.MiddleCenter;
				} else {
					btn.Text = airlines[i - 1].항공사명;
					btn.TextAlign = ContentAlignment.MiddleRight;
					btn.Image = imgAirlineLogo.Images[i - 1];
					btn.ImageAlign = ContentAlignment.MiddleLeft;
				}
				btn.Size = new Size(pnlDetails.MaximumSize.Width, 50);
				btn.Margin = new Padding(0, 0, 0, 0);
				btn.Padding = new Padding(20, 0, 20, 0);
				btn.Dock = DockStyle.Fill;
				btn.FlatStyle = FlatStyle.Flat;
				btn.FlatAppearance.BorderSize = 0;
				btn.Click += new EventHandler(btnAirlineName_Click);
				tpnlAirlines.Controls.Add(btn, 0, i);
			}
		}
		/* 패널에 속한 모든 Control들의 Height을 0으로 만들어 숨기는 함수*/
		private void DisablePanel(Panel Area) {
			foreach (Control pnl in Area.Controls) {
				if (pnl.GetType() == typeof(Panel)) {
					pnl.Size = pnl.MinimumSize;
				}
			}
		}
		/* 버튼을 클릭하면 버튼에 색상을 적용하는 함수 */
		private void ActivateButton(Panel Area, object btnSender) {
			//먼저 버튼이 소속된 Area 내에 다른 버튼이 활성화 되어 있다면 그 버튼을 원래 상태로 되돌리고, 
			//현재 누른 버튼에 색상을 적용합니다.
			if (btnSender != null) {
				if (currentButton != (Button)btnSender) { //선택한 버튼과 다른 버튼이 인자로 들어왔으면
					DisableButton(Area);  //Area 내의 모든 버튼을 초기 상태로 되돌림

				currentButton = (Button)btnSender;  //현재 버튼을 currentButton에 저장
				currentButton.BackColor = ThemeColor.PrimaryColor;
				currentButton.ForeColor = Color.White;
				currentButton.Font = new System.Drawing.Font("서울남산체 B", Area.Font.Size, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
				}
			}
		}
		/* 컨트롤 내 모든 버튼들의 스타일을 원래대로 되돌리는 함수 */
		private void DisableButton(Control Area) {
			foreach (Control previousBtn in Area.Controls) { //패널 내의 모든 콘트롤 객체 탐색
				if (previousBtn.GetType() == typeof(Button)) {   //버튼이면 스타일 초기화
					previousBtn.BackColor = Color.Transparent;
					previousBtn.ForeColor = Color.White;
					previousBtn.Font = new System.Drawing.Font("서울남산체 B", Area.Font.Size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
				}
			}
		}
		/* 해당 버튼의 선택 유무를 색상으로 판별하는 함수 */
		private bool isButtonActivated(Button btnSender) { 
			return btnSender.BackColor == ThemeColor.PrimaryColor ? true : false; 
		}
		/* 결과 출력 창에 마우스를 클릭하면 세부사항 패널(pnlDetails)을 숨기고 결과 내용을 업데이트하는 함수 */
		private void ResultArea_MouseDown(object sender, MouseEventArgs e) {
			if(isCollapsed[0] == true) return;
			pnlDetails.Visible = false;
			pnlDetails.Width = 0;
			isCollapsed[0] = true;
			DisablePanel(pnlDetails);
			DisableButton(pnlOptions);

			updateResultArea(updateChecker);
		}


		/* -----[ 결과 화면의 조작 및 업데이트에 관련된 함수입니다. ]----- */
		
		/* 결과 화면 영역의 내용을 사용자가 설정한 대로 업데이트하는 함수 */
		private void updateResultArea(ResultContentState contentState) {

			//결과 화면 상단부의 항공권 조건 정보를 표시
			btnLeaveInfo.Text = txtDepAirport_Name.Text + "   ->   " + txtArrAirport_Name.Text + "\n\n"
			+ dtpLeaveDate.Value.ToString("yyyy 년  M 월  d 일");
			btnReturnInfo.Text = txtArrAirport_Name.Text + "   ->   " + txtDepAirport_Name.Text + "\n\n"
				+ dtpReturnDate.Value.ToString("yyyy 년  M 월  d 일");
			
			//최신 상태인 경우
			if (contentState == ResultContentState.upToDate) return;	//	0
			//출발지 정보 업데이트가 필요한 상태일 경우
			if (contentState.HasFlag(ResultContentState.Dep_Old)) {	//	1
				apiLeave.depAirportId = apiReturn.arrAirportId
				= airports.Find(x => x.공항이름.Contains(txtDepAirport_Name.Text)).공항ID;
			}
			//도착지 정보 업데이트가 필요한 상태일 경우
			if (contentState.HasFlag(ResultContentState.Arr_Old)) {	//	2
				apiLeave.arrAirportId = apiReturn.depAirportId
				= airports.Find(x => x.공항이름.Contains(txtArrAirport_Name.Text)).공항ID;
			}
			//출발 날짜 정보 업데이트가 필요한 상태일 경우
			if (contentState.HasFlag(ResultContentState.leaveDate_Old)) {	//	4
				apiLeave.depPlandTime = dtpLeaveDate.Value.ToString("yyyyMMdd");
			}
			//귀환 날짜 정보 업데이트가 필요한 상태일 경우
			if (contentState.HasFlag(ResultContentState.returnDate_Old)) {	//	8
				apiReturn.depPlandTime = dtpReturnDate.Value.ToString("yyyyMMdd");
			}
			//항공사 정보 업데이트가 필요한 상태일 경우
			if (contentState.HasFlag(ResultContentState.airline_Old)) { //	16
				foreach (Button btn in tpnlAirlines.Controls) {
					if (isButtonActivated(btn)) {
						currentAirLine.항공사명 = btn.Text;
						leaves.Clear();
						returns.Clear();
						break;
					}
				}
			}
			//1. 날짜, 공항, 항공사 업데이트가 아예 필요 없을 때
			//2. 날짜, 공항 목록 업데이트가 아예 필요 없고, 항공사만 업데이트 해야할 때
			//3. 다 업데이트 해야할 때
			if (currentAirLine.항공사명 == "< 전체 선택하기 >") {
				foreach (Airline al in airlines) {
					apiLeave.airlineId = apiReturn.airlineId = al.항공사ID;
					leaves.AddRange(apiLeave.getFlightInfo().ToList());
					returns.AddRange(apiReturn.getFlightInfo().ToList());
				}
			} 
			else {
				apiLeave.airlineId = apiReturn.airlineId
					= airlines.Find(x => x.항공사명.Equals(currentAirLine.항공사명)).항공사ID;
				leaves = apiLeave.getFlightInfo().ToList();
				returns = apiReturn.getFlightInfo().ToList();
			}
					
			fillListView(lvwLeaveFlights, leaves);
			fillListView(lvwReturnFlights, returns);

			btnLeaveTotal.Text
				= "총  "
				+ (lvwLeaveFlights.Items[0].Text != "항공편 없음" ? lvwLeaveFlights.Items.Count : 0)
				+ "  개의  결과";
			btnReturnTotal.Text
				= "총  "
				+ (lvwLeaveFlights.Items[0].Text != "항공편 없음" ? lvwReturnFlights.Items.Count : 0)
				+ "  개의  결과";
			
			return;
		}
		/* ListView 안에 항공편정보 목록의 내용을 채우는 함수 */
		private void fillListView(ListView lvw, List<Flight> flist) {
			lvw.Items.Clear();
			if (flist.Count == 0) {
				lvw.Items.Add(new ListViewItem("항공편 없음"));
				return;
			}

			foreach (Flight f in flist) {
				ListViewItem lvi = new ListViewItem();
				lvi.Text = f.출발시각.ToString("HH : mm");
				lvi.SubItems.Add(f.도착시각.ToString("HH : mm"));
				lvi.SubItems.Add(f.항공사);
				if (l_price.Text.Equals("요금(비즈니스석)")) {
					lvi.SubItems.Add(f.요금[(int)TicketCharge.prestigeCharge]);
				} else {
					lvi.SubItems.Add(f.요금[(int)TicketCharge.economyCharge]);
				}
				lvw.Items.Add(lvi);
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms {
	public partial class FormPlane : Form {
		private Button currentButton;
		private bool isCollapsed;

		public FormPlane() {
			InitializeComponent();
			flpnlDetail.Size = flpnlDetail.MinimumSize;	//flow layout panel 숨기기
		}

		private void FormPlane_Load(object sender, EventArgs e)
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
		//왕복, 편도 두 개의 버튼이 있으며, pnlPlaneMenu > pnlWayToggle 내에 있습니다.
		//
		private void btnWayToggle_RoundTrip_Click(object sender, EventArgs e)
		{
			ActivateButton(pnlWayToggle, sender);
		}

		private void btnWayToggle_Single_Click(object sender, EventArgs e)
		{
			ActivateButton(pnlWayToggle, sender);
		}

		//
		//출발지, 도착지, 인원, 좌석 등급을 설정하는 버튼의 클릭에 대한 동작입니다.
		//각 버튼은 pnlPlaneMenu 내에 있습니다.
		//각 버튼을 누르면 (FlowLayoutPanel)flpnlDetail 패널이 서서히 나타납니다.
		//패널의 보이기 동작은 (Timer)tmrPanelMove 에 의해 패널의 크기를 조정하는 식으로
		//구현하였습니다.
		//한 버튼을 누르고 다른 버튼을 누르면 flpnlDetail이 사라졌다가 다시 서서히 나타납니다.
		//
		private void btnPlaneMenu_Departure_Click(object sender, EventArgs e)
		{
			//직전에 누른 버튼이 지금 버튼과 다른 버튼이면
			if (currentButton != sender)
			{
				//보여진 패널(flpnDetail)을 바로 숨긴다(Size를 MinimumSize로 바꿔서).
				Button thisButton = (Button)sender;
				flpnlDetail.Size = flpnlDetail.MinimumSize;
				isCollapsed = true;	//패널 닫혀있음 상태로 변경
			}
			ActivateButton(pnlPlaneMenu, sender);//현재 누른 버튼 활성화
			tmrPanelMove.Start();//타이머 작동 시작
		}

		private void btnPlaneMenu_Destination_Click(object sender, EventArgs e)
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

		private void btnPlaneMenu_HeadCount_Click(object sender, EventArgs e)
		{
			if (currentButton != sender)
			{
				flpnlDetail.Size = flpnlDetail.MinimumSize;
				isCollapsed = true;
			}
			ActivateButton(pnlPlaneMenu, sender);
			tmrPanelMove.Start();
		}

		private void btnPlaneMenu_SeatClass_Click(object sender, EventArgs e)
		{
			if (currentButton != sender)
			{
				flpnlDetail.Size = flpnlDetail.MinimumSize;
				isCollapsed = true;
			}
			ActivateButton(pnlPlaneMenu, sender);
			tmrPanelMove.Start();
		}

		//
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

					currentButton = (Button)btnSender;	//현재 버튼을 currentButton에 저장
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
				flpnlDetail.Width += 20;	//패널 가로 크기 20pixel 증가
				if (flpnlDetail.Size == flpnlDetail.MaximumSize)	//MaximumSize는 속성에서 변경가능
				{//최대 크기에 도달하면
					tmrPanelMove.Stop();	//타이머 정지
					isCollapsed = false;	//패널 열려있음으로 상태 변경
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
	}
}

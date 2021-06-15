using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project {
	public partial class FormMainMenu : Form {

		/* -----[ 필드 입니다. ]----- */

		/* 현재 활성화된 버튼 */
		private Button currentButton;
		/* 현재 활성화된 폼 */
		private Form activeForm; 
		/* 색상 랜덤 선택용 Random Class */
		private Random random;
		/* 색상 리스트에서 선택된 색상의 인덱스 */
		private int tempIndex;



		/* -----[ 폼의 생성자입니다. ]----- */

		public FormMainMenu() {
			InitializeComponent();

			/** 폼 초기화 작업 
				홈 화면이므로 btnGohome이 보이지 않게
				폼의 컨트롤박스 지우기
				폼의 최대화 크기를 작업표시줄을 제외한 화면 전체 크기로 지정
			**/
			btnGoHome.Visible = false;  
			this.Text = string.Empty;
			this.ControlBox = false;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;	
		}



		/* -----[ 주 기능으로 진입하는 버튼의 동작에 대한 EventHandler입니다. ]----- */

		private void btnTrain_Click(object sender, EventArgs e) {
			OpenChildForm(new Forms.FormTrain(), sender);
		}
		private void btnBus_Click(object sender, EventArgs e) {
			OpenChildForm(new Forms.FormBus(), sender);
		}
		private void btnPlane_Click(object sender, EventArgs e) {
			OpenChildForm(new Forms.Plane.FormPlane(), sender);
		}
		private void btnRouteSearch_Click(object sender, EventArgs e) {
			OpenChildForm(new Forms.FormRouteSearch(), sender);
		}



		/* -----[ 메인 폼의 보조 기능과 관련된 버튼의 동작에 대한 EventHandler입니다. ]----- */
		
		private void btnGoHome_Click(object sender, EventArgs e) {
			if (activeForm != null)
				activeForm.Close();
			Reset();
		}
		private void btnMinimize_Click(object sender, EventArgs e) {
			this.WindowState = FormWindowState.Minimized;
		}
		private void btnMaximize_Click(object sender, EventArgs e) {
			if (WindowState == FormWindowState.Normal) {
				this.WindowState = FormWindowState.Maximized;
			}
			else {
				this.WindowState = FormWindowState.Normal;
			}
		}				
		private void btnClose_Click(object sender, EventArgs e) {
			Application.Exit();
		}
		private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e) {
			ReleaseCapture();
			/**
				0x112 : 시스템 정의 메시지 - 키보드 가속기 알림 - WM_SYSCOMMAND (0x0112)
				0xf012 : 메시지상수(문서화되지 않음) - SC_DRAGMOVE (0xf012)
					#define    SC_SZLEFT           (0xF001)              // resize from left
					#define    SC_SZRIGHT          (0xF002)              // resize from right
					#define    SC_SZTOP            (0xF003)              // resize from top
					#define    SC_SZTOPLEFT        (0xF004)              // resize from top left
					#define    SC_SZTOPRIGHT       (0xF005)              // resize from top right
					#define    SC_SZBOTTOM         (0xF006)              // resize from bottom
					#define    SC_SZBOTTOMLEFT     (0xF007)              // resize from bottom left
					#define    SC_SZBOTTOMRIGHT    (0xF008)              // resize from bottom right
				*	#define    SC_DRAGMOVE         (0xF012)              // move by drag
			**/
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}



		/* -----[ EventHandler를 서포트하는 Method입니다. ]----- */

		/* 컬러톤을 랜덤으로 선택하는 함수 */
		private Color SelectThemeColor() {
			random = new Random();
			int index = 0;	//ColorList 인덱스
			while (tempIndex == index) {
				index = random.Next(ThemeColor.ColorList.Count);
			}
			tempIndex = index;
			string color = ThemeColor.ColorList[index];
			return ColorTranslator.FromHtml(color);	//HTML 컬러포맷을 Color로 변환하여 리턴
		}
		/* 버튼 활성화 */
		private void ActivateButton(object btnSender) {
			if (btnSender != null) {
				if (currentButton != (Button)btnSender) {	//선택한 버튼과 다른 버튼이 인자로 들어왔으면
					DisableButton();  //버튼 비활성화

					//색상 저장
					Color color = SelectThemeColor();
					ThemeColor.PrimaryColor = color;  //FormMainMenu에 적용한 랜덤색상
					ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);  //밝기변화처리된 색상

					currentButton = (Button)btnSender;
					currentButton.BackColor = ThemeColor.PrimaryColor;
					currentButton.ForeColor = Color.White;
					currentButton.Font = new System.Drawing.Font("서울남산체 B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
					pnlTitleBar.BackColor = ThemeColor.PrimaryColor;
					pnlLogo.BackColor = ThemeColor.SecondaryColor;
					btnGoHome.Visible = true;
				}
			}
		}
		/* 버튼 비활성화 */
		private void DisableButton() {
			foreach (Control previousBtn in pnlMenu.Controls) {	//pnlMenu(좌측 메뉴)내의 콘트롤객체 탐색
				if (previousBtn.GetType() == typeof(Button)) {		//버튼이면 스타일 초기화
					previousBtn.BackColor = Color.FromArgb(51, 51, 76);
					previousBtn.ForeColor = Color.White;
					previousBtn.Font = new System.Drawing.Font("서울남산체 B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
				}
			}
		}
		/* Body부분에 자식 폼을 띄우는 함수 */
		private void OpenChildForm(Form childForm, object btnSender) {
			if (activeForm != null) {	//현재 열려있는 자식 폼 종료.
				activeForm.Close();
			}
			ActivateButton(btnSender);
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.pnlDesktopPanel.Controls.Add(childForm);
			this.pnlDesktopPanel.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			lblTitle.Text = childForm.Text;
		}
		/* 폼을 처음 시작상태로 초기화하는 함수 */
		private void Reset() {
			DisableButton();
			lblTitle.Text = "한눈에 보는 교통수단, TARA!";
			pnlTitleBar.BackColor = Color.FromArgb(0, 150, 136);
			pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
			currentButton = null;
			btnGoHome.Visible = false;
		}



		/* -----[ 외부 라이브러리를 사용하는 Method입니다. ]----- */

		/* pnlTitleBar에 드래그 이동 기능을 적용하는 외부 함수
			DllImportAttribute 선언 	(DllImportAttribute : 매니지드 코드에서 언매니지드 api를 static하게 사용할 수 있도록 하는 속성)
				1. ReleaseCapture() : delegate mousedown events to underlying controls.
					https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-releasecapture

				2. SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam) : propagating environment variables
					Official : https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendmessage
				
					hWnd : 메시지를 수신할 창에 대한 핸들의 주소값

					wMsg : 보낼 메시지
						Official : https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand

					wParam : 추가 메시지 관련 정보(핸들 또는 정수) (= 메시지 상수)
						Have Comment at : https://social.msdn.microsoft.com/Forums/expression/ko-KR/78265b78-73bb-4949-89bf-21a7440bf9ec/545324711251076-5063045716-509524602050864-5335644592-4832044221?forum=visualcplusko
				
					IParam : 추가 메시지 관련 정보(포인터)
		*/
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
	}
}

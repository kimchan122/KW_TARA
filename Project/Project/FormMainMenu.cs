using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project {
	public partial class FormMainMenu : Form {
		//Feilds
		private Button currentButton;
		private Random random;
		private int tempIndex;
		private Form activeForm;

		public FormMainMenu() {
			InitializeComponent();
			btnGoHome.Visible = false;  //홈메뉴에서는 btnGoHome버튼 안보이게 

			//타이틀바 지우기
			//타이틀바를 지우면 드래그로 창을 이동시킬 수 없고, 닫기랑 최대화, 최소화도 안된다. 
			//이에 대한 해결은 line:128에서 
			this.Text = string.Empty;
			this.ControlBox = false;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;	//전체화면 시 작업표시줄 가리지 않도록
		}

		//Methods
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

		//버튼 활성화 시 동작을 정의한 함수
		private void ActivateButton(object btnSender) {
			if (btnSender != null) {
				if (currentButton != (Button)btnSender) {	//선택한 버튼과 다른 버튼이 인자로 들어왔으면
					DisableButton();	//버튼 비활성화

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

		//모든 버튼들의 스타일을 원래대로 되돌리는 함수
		private void DisableButton() {
			foreach (Control previousBtn in pnlMenu.Controls) {	//pnlMenu(좌측 메뉴)내의 콘트롤객체 탐색
				if (previousBtn.GetType() == typeof(Button)) {		//버튼이면 스타일 초기화
					previousBtn.BackColor = Color.FromArgb(51, 51, 76);
					previousBtn.ForeColor = Color.Gainsboro;
					previousBtn.Font = new System.Drawing.Font("서울남산체 B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
				}
			}
		}

		//자식 폼을 가져오는 함수
		private void OpenChildForm(Form childForm, object btnSender/*버튼사용*/) {
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

		private void btnTrain_Click(object sender, EventArgs e) {
			OpenChildForm(new Forms.FormTrain(), sender);
		}

		private void btnBus_Click(object sender, EventArgs e) {
			OpenChildForm(new Forms.FormBus(), sender);
		}

		private void btnPlane_Click(object sender, EventArgs e) {
			OpenChildForm(new Forms.FormPlane(), sender);
		}

		private void btnRouteSearch_Click(object sender, EventArgs e) {
			OpenChildForm(new Forms.FormRouteSearch(), sender);
		}

		private void btnSettings_Click(object sender, EventArgs e) {
			OpenChildForm(new Forms.FormSettings(), sender);
		}

		private void btnGoHome_Click(object sender, EventArgs e) {
			if (activeForm != null)
				activeForm.Close();
			Reset();
		}

		private void Reset() {
			DisableButton();
			lblTitle.Text = "한눈에 보는 교통수단, TARA!";
			pnlTitleBar.BackColor = Color.FromArgb(0, 150, 136);
			pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
			currentButton = null;
			btnGoHome.Visible = false;
		}

		//없어진 ControlBox를 대체할 버튼과 MouseDown 드래깅 추가

		//DllImport Attribute 추가
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();

		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e) {
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnClose_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void btnMaximize_Click(object sender, EventArgs e) {
			if (WindowState == FormWindowState.Normal) {
				this.WindowState = FormWindowState.Maximized;
			}
			else {
				this.WindowState = FormWindowState.Normal;
			}
		}

		private void btnMinimize_Click(object sender, EventArgs e) {
			this.WindowState = FormWindowState.Minimized;
		}

        private void pnlDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

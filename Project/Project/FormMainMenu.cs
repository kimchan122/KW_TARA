using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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

		//모든 버튼들의 스타일을 원래대로 되돌리는 함수
		private void DisableButton() {
			foreach (Control previousBtn in pnlMenu.Controls) {	//pnlMenu(좌측 메뉴)내의 콘트롤객체 탐색
				if (previousBtn.GetType() == typeof(Button)) {		//버튼이면 스타일 초기화
					previousBtn.BackColor = Color.FromArgb(51, 51, 76);
					previousBtn.ForeColor = Color.White;
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
			OpenChildForm(new Forms.Plane.FormPlane(), sender);
		}

		private void btnRouteSearch_Click(object sender, EventArgs e) {
			OpenChildForm(new Forms.FormRouteSearch(), sender);
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

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            showWeather();
        }

        private void showWeather()
        {
            Hashtable cityCode = new Hashtable();
            List<String> queryList = new List<string>();

            //10개의 도시부분만 메인화면에 구성.
            cityCode.Add("4215061500", "강원도");
            cityCode.Add("4182025000", "경기도");
            cityCode.Add("4831034000", "경상남도");
            cityCode.Add("4729053000", "경상북도");
            cityCode.Add("1168066000", "서울특별시");
            cityCode.Add("4681025000", "전라남도");
            cityCode.Add("4579031000", "전라북도");
            cityCode.Add("5013025300", "제주도");
            cityCode.Add("4425051000", "충청남도");
            cityCode.Add("4376031000", "충청북도");

            //api 주소
            string query = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=";


            //각각의 도시코드별로 api주소를 생성.
            foreach (var key in cityCode.Keys)
            {
                queryList.Add(query + key);
            }

            //생성된 api주소별로 데이터를 얻어오는 과정.
            foreach (var list in queryList)
            {
                //api주소 끝부분 도시코드의 key 값을 의미.
                string key = list.Substring(list.Length - 10, 10);

                TableLayoutPanel tblPnl = new TableLayoutPanel();
                tblPnl.RowCount = 5;    //도시이름, 날씨상태, 기온, 강수확률, 풍속에 관한 정보를 담을 갯수.
                tblPnl.AutoSize = true;
                Panel pnl = new Panel();


                Bitmap img1 = new Bitmap("img/img1.png");   //맑음
                Bitmap img2 = new Bitmap("img/img2.png");   //구름많음
                Bitmap img3 = new Bitmap("img/img3.png");   //흐림
                Bitmap img4 = new Bitmap("img/img4.png");   //비
                Bitmap img5 = new Bitmap("img/img5.png");   //비/눈
                Bitmap img6 = new Bitmap("img/img6.png");   //눈
                Bitmap img7 = new Bitmap("img/img7.png");   //소나기


                PictureBox weatherState = new PictureBox();
                weatherState.Size = new Size(80, 80);
                weatherState.SizeMode = PictureBoxSizeMode.Zoom;

                Label lblCityName = new Label();
                Label lblTemp = new Label();
                Label lblRain = new Label();
                Label lblWind = new Label();

                tblPnl.Controls.Add(lblCityName);
                tblPnl.Controls.Add(weatherState);
                tblPnl.Controls.Add(lblTemp);
                tblPnl.Controls.Add(lblRain);
                tblPnl.Controls.Add(lblWind);

				//added
				lblCityName.Font = new Font("서울남산체 B", 11);
				//added

                lblCityName.Text = ' '+cityCode[key].ToString();
                this.tlPnlWeather.Controls.Add(tblPnl);


                //클라이언트에서 request.
                WebRequest wr = WebRequest.Create(list);
                wr.Method = "GET";

                //Response를 받는다.
                WebResponse wrs = wr.GetResponse();
                Stream s = wrs.GetResponseStream();
                StreamReader sr = new StreamReader(s);

                string response = sr.ReadToEnd();

                XmlDocument xd = new XmlDocument();
                xd.LoadXml(response);


                //메인화면 상단에 날짜를 표시하기 위한 코드(날짜 텍스트가 비어있을 경우만 실행.)
                if (lblDate.Text.Equals(""))
                {
                    XmlNode date = xd["rss"]["channel"]["pubDate"];
                    lblDate.Text = date.InnerText.Substring(0, date.InnerText.Length - 5);
                }


                XmlNode node = xd["rss"]["channel"]["item"]["description"]["body"];

                lblTemp.Text = "온도(°C)\t: " + node.ChildNodes[0]["temp"].InnerText;
                lblRain.Text = "강수확률(%)\t: " + node.ChildNodes[0]["pop"].InnerText;
                lblWind.Text = "풍속(m/s)\t: " + node.ChildNodes[0]["ws"].InnerText.Substring(0, 3);

                string wState = node.ChildNodes[0]["wfKor"].InnerText;

                if (wState == "맑음")
                {
                    weatherState.Image = img1;
                }
                else if (wState == "구름 많음")
                {
                    weatherState.Image = img2;
                }
                else if (wState == "흐림")
                {
                    weatherState.Image = img3;
                }
                else if (wState == "비")
                {
                    weatherState.Image = img4;
                }
                else if (wState == "비/눈")
                {
                    weatherState.Image = img5;
                }
                else if (wState == "눈")
                {
                    weatherState.Image = img6;
                }
                else if (wState == "소나기")
                {
                    weatherState.Image = img7;
                }
            }
        }
    }
}

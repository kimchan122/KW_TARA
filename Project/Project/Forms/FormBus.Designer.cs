namespace Project.Forms {
	partial class FormBus {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pnlBusMenu = new System.Windows.Forms.Panel();
            this.btnBusMenu_SeatClass = new System.Windows.Forms.Button();
            this.btnBusMenu_Date = new System.Windows.Forms.Button();
            this.btnBusMenu_Destination = new System.Windows.Forms.Button();
            this.btnBusMenu_Departure = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWayToggle_Single = new System.Windows.Forms.Button();
            this.btnWayToggle_RoundTrip = new System.Windows.Forms.Button();
            this.pnlWayToggle = new System.Windows.Forms.Panel();
            this.btnWayToggle_CountrySide = new System.Windows.Forms.Button();
            this.btnWayToggle_Express = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tmrPanelMove = new System.Windows.Forms.Timer(this.components);
            this.dep1 = new System.Windows.Forms.ComboBox();
            this.arr1 = new System.Windows.Forms.ComboBox();
            this.Exp = new System.Windows.Forms.Button();
            this.flpnlDetail = new System.Windows.Forms.Panel();
            this.arr1_2 = new System.Windows.Forms.ComboBox();
            this.BusGrade_2 = new System.Windows.Forms.ComboBox();
            this.arr2_2 = new System.Windows.Forms.TextBox();
            this.arr2 = new System.Windows.Forms.TextBox();
            this.dep2_2 = new System.Windows.Forms.TextBox();
            this.dep2 = new System.Windows.Forms.TextBox();
            this.Sub = new System.Windows.Forms.Button();
            this.BusGrade = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Label();
            this.dep1_2 = new System.Windows.Forms.ComboBox();
            this.Destination = new System.Windows.Forms.TextBox();
            this.Departure = new System.Windows.Forms.TextBox();
            this.Go = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Grad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dest = new System.Windows.Forms.TextBox();
            this.Depa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Grad2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Dest2 = new System.Windows.Forms.TextBox();
            this.Depa2 = new System.Windows.Forms.TextBox();
            this.Date2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBusMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlWayToggle.SuspendLayout();
            this.flpnlDetail.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBusMenu
            // 
            this.pnlBusMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.pnlBusMenu.Controls.Add(this.btnBusMenu_SeatClass);
            this.pnlBusMenu.Controls.Add(this.btnBusMenu_Date);
            this.pnlBusMenu.Controls.Add(this.btnBusMenu_Destination);
            this.pnlBusMenu.Controls.Add(this.btnBusMenu_Departure);
            this.pnlBusMenu.Controls.Add(this.panel1);
            this.pnlBusMenu.Controls.Add(this.pnlWayToggle);
            this.pnlBusMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlBusMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBusMenu.Name = "pnlBusMenu";
            this.pnlBusMenu.Size = new System.Drawing.Size(175, 2400);
            this.pnlBusMenu.TabIndex = 2;
            this.pnlBusMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBusMenu_Paint);
            // 
            // btnBusMenu_SeatClass
            // 
            this.btnBusMenu_SeatClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBusMenu_SeatClass.FlatAppearance.BorderSize = 0;
            this.btnBusMenu_SeatClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusMenu_SeatClass.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnBusMenu_SeatClass.ForeColor = System.Drawing.Color.White;
            this.btnBusMenu_SeatClass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusMenu_SeatClass.Location = new System.Drawing.Point(0, 280);
            this.btnBusMenu_SeatClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBusMenu_SeatClass.Name = "btnBusMenu_SeatClass";
            this.btnBusMenu_SeatClass.Size = new System.Drawing.Size(175, 56);
            this.btnBusMenu_SeatClass.TabIndex = 9;
            this.btnBusMenu_SeatClass.Text = " 버스등급";
            this.btnBusMenu_SeatClass.UseVisualStyleBackColor = true;
            
            // 
            // btnBusMenu_Date
            // 
            this.btnBusMenu_Date.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBusMenu_Date.FlatAppearance.BorderSize = 0;
            this.btnBusMenu_Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusMenu_Date.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnBusMenu_Date.ForeColor = System.Drawing.Color.White;
            this.btnBusMenu_Date.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusMenu_Date.Location = new System.Drawing.Point(0, 224);
            this.btnBusMenu_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBusMenu_Date.Name = "btnBusMenu_Date";
            this.btnBusMenu_Date.Size = new System.Drawing.Size(175, 56);
            this.btnBusMenu_Date.TabIndex = 8;
            this.btnBusMenu_Date.Text = "  날짜";
            this.btnBusMenu_Date.UseVisualStyleBackColor = true;
            
            // 
            // btnBusMenu_Destination
            // 
            this.btnBusMenu_Destination.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBusMenu_Destination.FlatAppearance.BorderSize = 0;
            this.btnBusMenu_Destination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusMenu_Destination.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnBusMenu_Destination.ForeColor = System.Drawing.Color.White;
            this.btnBusMenu_Destination.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusMenu_Destination.Location = new System.Drawing.Point(0, 168);
            this.btnBusMenu_Destination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBusMenu_Destination.Name = "btnBusMenu_Destination";
            this.btnBusMenu_Destination.Size = new System.Drawing.Size(175, 56);
            this.btnBusMenu_Destination.TabIndex = 7;
            this.btnBusMenu_Destination.Text = "  도착지";
            this.btnBusMenu_Destination.UseVisualStyleBackColor = true;
           
            // 
            // btnBusMenu_Departure
            // 
            this.btnBusMenu_Departure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBusMenu_Departure.FlatAppearance.BorderSize = 0;
            this.btnBusMenu_Departure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusMenu_Departure.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnBusMenu_Departure.ForeColor = System.Drawing.Color.White;
            this.btnBusMenu_Departure.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusMenu_Departure.Location = new System.Drawing.Point(0, 112);
            this.btnBusMenu_Departure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBusMenu_Departure.Name = "btnBusMenu_Departure";
            this.btnBusMenu_Departure.Size = new System.Drawing.Size(175, 56);
            this.btnBusMenu_Departure.TabIndex = 6;
            this.btnBusMenu_Departure.Text = "  출발지";
            this.btnBusMenu_Departure.UseVisualStyleBackColor = true;
            
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnWayToggle_Single);
            this.panel1.Controls.Add(this.btnWayToggle_RoundTrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 56);
            this.panel1.TabIndex = 5;
            // 
            // btnWayToggle_Single
            // 
            this.btnWayToggle_Single.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnWayToggle_Single.FlatAppearance.BorderSize = 0;
            this.btnWayToggle_Single.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWayToggle_Single.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnWayToggle_Single.ForeColor = System.Drawing.Color.White;
            this.btnWayToggle_Single.Location = new System.Drawing.Point(89, 0);
            this.btnWayToggle_Single.Margin = new System.Windows.Forms.Padding(1);
            this.btnWayToggle_Single.Name = "btnWayToggle_Single";
            this.btnWayToggle_Single.Size = new System.Drawing.Size(86, 56);
            this.btnWayToggle_Single.TabIndex = 1;
            this.btnWayToggle_Single.Text = "편도";
            this.btnWayToggle_Single.UseVisualStyleBackColor = true;
            this.btnWayToggle_Single.Click += new System.EventHandler(this.btnWayToggle_Single_Click);
            // 
            // btnWayToggle_RoundTrip
            // 
            this.btnWayToggle_RoundTrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWayToggle_RoundTrip.FlatAppearance.BorderSize = 0;
            this.btnWayToggle_RoundTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWayToggle_RoundTrip.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnWayToggle_RoundTrip.ForeColor = System.Drawing.Color.White;
            this.btnWayToggle_RoundTrip.Location = new System.Drawing.Point(0, 0);
            this.btnWayToggle_RoundTrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWayToggle_RoundTrip.Name = "btnWayToggle_RoundTrip";
            this.btnWayToggle_RoundTrip.Size = new System.Drawing.Size(87, 56);
            this.btnWayToggle_RoundTrip.TabIndex = 0;
            this.btnWayToggle_RoundTrip.Text = "왕복";
            this.btnWayToggle_RoundTrip.UseVisualStyleBackColor = true;
            this.btnWayToggle_RoundTrip.Click += new System.EventHandler(this.btnWayToggle_RoundTrip_Click);
            // 
            // pnlWayToggle
            // 
            this.pnlWayToggle.Controls.Add(this.btnWayToggle_CountrySide);
            this.pnlWayToggle.Controls.Add(this.btnWayToggle_Express);
            this.pnlWayToggle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWayToggle.Location = new System.Drawing.Point(0, 0);
            this.pnlWayToggle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlWayToggle.Name = "pnlWayToggle";
            this.pnlWayToggle.Size = new System.Drawing.Size(175, 56);
            this.pnlWayToggle.TabIndex = 0;
            // 
            // btnWayToggle_CountrySide
            // 
            this.btnWayToggle_CountrySide.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnWayToggle_CountrySide.FlatAppearance.BorderSize = 0;
            this.btnWayToggle_CountrySide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWayToggle_CountrySide.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnWayToggle_CountrySide.ForeColor = System.Drawing.Color.White;
            this.btnWayToggle_CountrySide.Location = new System.Drawing.Point(89, 0);
            this.btnWayToggle_CountrySide.Margin = new System.Windows.Forms.Padding(1);
            this.btnWayToggle_CountrySide.Name = "btnWayToggle_CountrySide";
            this.btnWayToggle_CountrySide.Size = new System.Drawing.Size(86, 56);
            this.btnWayToggle_CountrySide.TabIndex = 1;
            this.btnWayToggle_CountrySide.Text = "시외";
            this.btnWayToggle_CountrySide.UseVisualStyleBackColor = true;
            this.btnWayToggle_CountrySide.Click += new System.EventHandler(this.btnWayToggle_CountrySide_Click);
            // 
            // btnWayToggle_Express
            // 
            this.btnWayToggle_Express.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWayToggle_Express.FlatAppearance.BorderSize = 0;
            this.btnWayToggle_Express.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWayToggle_Express.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnWayToggle_Express.ForeColor = System.Drawing.Color.White;
            this.btnWayToggle_Express.Location = new System.Drawing.Point(0, 0);
            this.btnWayToggle_Express.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWayToggle_Express.Name = "btnWayToggle_Express";
            this.btnWayToggle_Express.Size = new System.Drawing.Size(87, 56);
            this.btnWayToggle_Express.TabIndex = 0;
            this.btnWayToggle_Express.Text = "고속";
            this.btnWayToggle_Express.UseVisualStyleBackColor = true;
            this.btnWayToggle_Express.Click += new System.EventHandler(this.btnWayToggle_Express_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 238);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 25);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker2.Location = new System.Drawing.Point(188, 238);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 25);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // tmrPanelMove
            // 
            this.tmrPanelMove.Enabled = true;
            this.tmrPanelMove.Interval = 15;
            this.tmrPanelMove.Tick += new System.EventHandler(this.tmrPanelMove_Tick);
            // 
            // dep1
            // 
            this.dep1.FormattingEnabled = true;
            this.dep1.Items.AddRange(new object[] {
            "강릉",
            "강진",
            "경북도청",
            "경주",
            "고대조치원",
            "고양백석",
            "고양화정",
            "고창",
            "고흥",
            "곡성",
            "공주",
            "광명(KTX역)",
            "광명(철산역)",
            "광양",
            "광주(유·스퀘어)",
            "구례",
            "구리",
            "구미",
            "군산",
            "금산",
            "김제",
            "김천",
            "김천혁신",
            "김해",
            "김해장유",
            "나주",
            "낙동강(휴)상행",
            "낙동강(휴)하행",
            "남악",
            "남원",
            "내포",
            "녹동",
            "논산",
            "능주",
            "담양",
            "당진",
            "당진기지시",
            "대구용계",
            "대구혁신",
            "대전도룡",
            "대전복합",
            "대전청사",
            "덕과",
            "덕산스파",
            "동광양",
            "동대구",
            "동서울",
            "동해",
            "마산",
            "마산내서",
            "목포",
            "무안",
            "문장",
            "밀양",
            "배방정류소",
            "벌교",
            "보성",
            "부산",
            "부천",
            "북청주",
            "삼척",
            "삼호",
            "상봉",
            "상주",
            "서대구",
            "서부산(사상)",
            "서산",
            "서수원",
            "서울경부",
            "선문대",
            "선산(휴)상행",
            "선산(휴)하행",
            "섬진강(휴)상행",
            "섬진강(휴)하행",
            "성남(분당)",
            "세종국무조정실",
            "세종시청",
            "세종연구단지",
            "세종청사",
            "세종터미널",
            "센트럴시티(서울)",
            "속초",
            "수원",
            "순창",
            "순천",
            "순천신대지구",
            "시흥(시화)",
            "신갈시외",
            "신갈영덕",
            "아산둔포",
            "아산서부(호서대)",
            "아산온양",
            "아산탕정사무소",
            "아산테크노밸리",
            "안동",
            "안면도",
            "안산",
            "안성",
            "안성공도",
            "안성대림",
            "안성중대",
            "안성풍림",
            "안성한경",
            "안성회관",
            "안중",
            "안중오거리",
            "애통리",
            "양산",
            "양양",
            "여수",
            "여주",
            "여주대",
            "여천",
            "연무대",
            "영광",
            "영덕",
            "영산포",
            "영암",
            "영주",
            "영천",
            "영천망정동",
            "영통",
            "예산",
            "예천",
            "오산",
            "옥과",
            "완도",
            "용인",
            "용인신갈",
            "용인유림",
            "울산",
            "울산신복",
            "원동",
            "원주",
            "원주기업도시",
            "원주문막",
            "원주혁신",
            "유성",
            "의정부",
            "이천",
            "이천(마장택지지구)",
            "이천부발(신하리)",
            "익산",
            "익산팔봉",
            "인삼랜드(휴)상행",
            "인삼랜드(휴)하행",
            "인천",
            "인천공항T1",
            "인천공항T2",
            "임자(대광)",
            "임자(진리)",
            "자치인재원",
            "장성",
            "장흥",
            "전북혁신",
            "전주",
            "전주호남제일문",
            "점촌",
            "정산",
            "정안(휴)상행",
            "정안(휴)하행",
            "정읍",
            "제천",
            "제천하소",
            "조치원",
            "죽전",
            "중앙탑면",
            "지도",
            "진도",
            "진주",
            "진주개양",
            "진주혁신",
            "진해",
            "창기리",
            "창원",
            "창원역",
            "천안",
            "천안3공단",
            "천안아산역",
            "청양",
            "청주(센트럴)",
            "청주고속터미널",
            "청주공항",
            "춘천",
            "충주",
            "탕정삼성LCD",
            "태안",
            "태인",
            "통영",
            "평택",
            "평택대",
            "평택용이동",
            "포항",
            "포항시청",
            "풍기",
            "함평",
            "해남",
            "해제",
            "홍대조치원",
            "홍성",
            "화순",
            "황간",
            "회진",
            "횡성(휴)상행",
            "횡성(휴)하행"});
            this.dep1.Location = new System.Drawing.Point(20, 129);
            this.dep1.Name = "dep1";
            this.dep1.Size = new System.Drawing.Size(103, 25);
            this.dep1.TabIndex = 10;
            this.dep1.SelectedIndexChanged += new System.EventHandler(this.dep1_SelectedIndexChanged);
            // 
            // arr1
            // 
            this.arr1.FormattingEnabled = true;
            this.arr1.Items.AddRange(new object[] {
            "강릉",
            "강진",
            "경북도청",
            "경주",
            "고대조치원",
            "고양백석",
            "고양화정",
            "고창",
            "고흥",
            "곡성",
            "공주",
            "광명(KTX역)",
            "광명(철산역)",
            "광양",
            "광주(유·스퀘어)",
            "구례",
            "구리",
            "구미",
            "군산",
            "금산",
            "김제",
            "김천",
            "김천혁신",
            "김해",
            "김해장유",
            "나주",
            "낙동강(휴)상행",
            "낙동강(휴)하행",
            "남악",
            "남원",
            "내포",
            "녹동",
            "논산",
            "능주",
            "담양",
            "당진",
            "당진기지시",
            "대구용계",
            "대구혁신",
            "대전도룡",
            "대전복합",
            "대전청사",
            "덕과",
            "덕산스파",
            "동광양",
            "동대구",
            "동서울",
            "동해",
            "마산",
            "마산내서",
            "목포",
            "무안",
            "문장",
            "밀양",
            "배방정류소",
            "벌교",
            "보성",
            "부산",
            "부천",
            "북청주",
            "삼척",
            "삼호",
            "상봉",
            "상주",
            "서대구",
            "서부산(사상)",
            "서산",
            "서수원",
            "서울경부",
            "선문대",
            "선산(휴)상행",
            "선산(휴)하행",
            "섬진강(휴)상행",
            "섬진강(휴)하행",
            "성남(분당)",
            "세종국무조정실",
            "세종시청",
            "세종연구단지",
            "세종청사",
            "세종터미널",
            "센트럴시티(서울)",
            "속초",
            "수원",
            "순창",
            "순천",
            "순천신대지구",
            "시흥(시화)",
            "신갈시외",
            "신갈영덕",
            "아산둔포",
            "아산서부(호서대)",
            "아산온양",
            "아산탕정사무소",
            "아산테크노밸리",
            "안동",
            "안면도",
            "안산",
            "안성",
            "안성공도",
            "안성대림",
            "안성중대",
            "안성풍림",
            "안성한경",
            "안성회관",
            "안중",
            "안중오거리",
            "애통리",
            "양산",
            "양양",
            "여수",
            "여주",
            "여주대",
            "여천",
            "연무대",
            "영광",
            "영덕",
            "영산포",
            "영암",
            "영주",
            "영천",
            "영천망정동",
            "영통",
            "예산",
            "예천",
            "오산",
            "옥과",
            "완도",
            "용인",
            "용인신갈",
            "용인유림",
            "울산",
            "울산신복",
            "원동",
            "원주",
            "원주기업도시",
            "원주문막",
            "원주혁신",
            "유성",
            "의정부",
            "이천",
            "이천(마장택지지구)",
            "이천부발(신하리)",
            "익산",
            "익산팔봉",
            "인삼랜드(휴)상행",
            "인삼랜드(휴)하행",
            "인천",
            "인천공항T1",
            "인천공항T2",
            "임자(대광)",
            "임자(진리)",
            "자치인재원",
            "장성",
            "장흥",
            "전북혁신",
            "전주",
            "전주호남제일문",
            "점촌",
            "정산",
            "정안(휴)상행",
            "정안(휴)하행",
            "정읍",
            "제천",
            "제천하소",
            "조치원",
            "죽전",
            "중앙탑면",
            "지도",
            "진도",
            "진주",
            "진주개양",
            "진주혁신",
            "진해",
            "창기리",
            "창원",
            "창원역",
            "천안",
            "천안3공단",
            "천안아산역",
            "청양",
            "청주(센트럴)",
            "청주고속터미널",
            "청주공항",
            "춘천",
            "충주",
            "탕정삼성LCD",
            "태안",
            "태인",
            "통영",
            "평택",
            "평택대",
            "평택용이동",
            "포항",
            "포항시청",
            "풍기",
            "함평",
            "해남",
            "해제",
            "홍대조치원",
            "홍성",
            "화순",
            "황간",
            "회진",
            "횡성(휴)상행",
            "횡성(휴)하행"});
            this.arr1.Location = new System.Drawing.Point(20, 185);
            this.arr1.Name = "arr1";
            this.arr1.Size = new System.Drawing.Size(103, 25);
            this.arr1.TabIndex = 11;
            this.arr1.SelectedIndexChanged += new System.EventHandler(this.arr1_SelectedIndexChanged);
            // 
            // Exp
            // 
            this.Exp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.Exp.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Exp.Location = new System.Drawing.Point(137, 374);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(71, 29);
            this.Exp.TabIndex = 0;
            this.Exp.Text = "조회";
            this.Exp.UseVisualStyleBackColor = false;
            this.Exp.Click += new System.EventHandler(this.button1_Click);
            // 
            // flpnlDetail
            // 
            this.flpnlDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpnlDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.flpnlDetail.Controls.Add(this.arr1_2);
            this.flpnlDetail.Controls.Add(this.BusGrade_2);
            this.flpnlDetail.Controls.Add(this.arr2_2);
            this.flpnlDetail.Controls.Add(this.arr2);
            this.flpnlDetail.Controls.Add(this.dep2_2);
            this.flpnlDetail.Controls.Add(this.dep2);
            this.flpnlDetail.Controls.Add(this.Sub);
            this.flpnlDetail.Controls.Add(this.BusGrade);
            this.flpnlDetail.Controls.Add(this.Back);
            this.flpnlDetail.Controls.Add(this.dep1_2);
            this.flpnlDetail.Controls.Add(this.Destination);
            this.flpnlDetail.Controls.Add(this.Departure);
            this.flpnlDetail.Controls.Add(this.dateTimePicker2);
            this.flpnlDetail.Controls.Add(this.Go);
            this.flpnlDetail.Controls.Add(this.dateTimePicker1);
            this.flpnlDetail.Controls.Add(this.arr1);
            this.flpnlDetail.Controls.Add(this.dep1);
            this.flpnlDetail.Controls.Add(this.Exp);
            this.flpnlDetail.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.flpnlDetail.ForeColor = System.Drawing.Color.White;
            this.flpnlDetail.Location = new System.Drawing.Point(176, 0);
            this.flpnlDetail.Margin = new System.Windows.Forms.Padding(0);
            this.flpnlDetail.MaximumSize = new System.Drawing.Size(350, 2400);
            this.flpnlDetail.MinimumSize = new System.Drawing.Size(0, 2400);
            this.flpnlDetail.Name = "flpnlDetail";
            this.flpnlDetail.Size = new System.Drawing.Size(350, 2400);
            this.flpnlDetail.TabIndex = 3;
            
            // 
            // arr1_2
            // 
            this.arr1_2.DropDownWidth = 103;
            this.arr1_2.FormattingEnabled = true;
            this.arr1_2.Location = new System.Drawing.Point(20, 184);
            this.arr1_2.Name = "arr1_2";
            this.arr1_2.Size = new System.Drawing.Size(103, 25);
            this.arr1_2.TabIndex = 11;
            this.arr1_2.SelectedIndexChanged += new System.EventHandler(this.arr1_2_SelectedIndexChanged);
            // 
            // BusGrade_2
            // 
            this.BusGrade_2.DropDownWidth = 114;
            this.BusGrade_2.FormattingEnabled = true;
            this.BusGrade_2.Items.AddRange(new object[] {
            "프리미엄",
            "일반",
            "우등",
            "주말프리",
            "심야프리",
            "심야일반",
            "심야우등",
            "주말심프"});
            this.BusGrade_2.Location = new System.Drawing.Point(20, 297);
            this.BusGrade_2.Name = "BusGrade_2";
            this.BusGrade_2.Size = new System.Drawing.Size(114, 25);
            this.BusGrade_2.TabIndex = 17;
            this.BusGrade_2.SelectedIndexChanged += new System.EventHandler(this.BusGrade_2_SelectedIndexChanged);
            // 
            // arr2_2
            // 
            this.arr2_2.Location = new System.Drawing.Point(207, 185);
            this.arr2_2.Name = "arr2_2";
            this.arr2_2.Size = new System.Drawing.Size(103, 25);
            this.arr2_2.TabIndex = 22;
            this.arr2_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // arr2
            // 
            this.arr2.Location = new System.Drawing.Point(207, 185);
            this.arr2.Name = "arr2";
            this.arr2.Size = new System.Drawing.Size(103, 25);
            this.arr2.TabIndex = 21;
            this.arr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dep2_2
            // 
            this.dep2_2.Location = new System.Drawing.Point(207, 129);
            this.dep2_2.Name = "dep2_2";
            this.dep2_2.Size = new System.Drawing.Size(103, 25);
            this.dep2_2.TabIndex = 20;
            this.dep2_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   
            // 
            // dep2
            // 
            this.dep2.Location = new System.Drawing.Point(207, 129);
            this.dep2.Name = "dep2";
            this.dep2.Size = new System.Drawing.Size(103, 25);
            this.dep2.TabIndex = 19;
            this.dep2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.Sub.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Sub.Location = new System.Drawing.Point(137, 374);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(71, 29);
            this.Sub.TabIndex = 18;
            this.Sub.Text = "조회";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.Click += new System.EventHandler(this.button2_Click);
            // 
            // BusGrade
            // 
            this.BusGrade.FormattingEnabled = true;
            this.BusGrade.Items.AddRange(new object[] {
            "우등",
            "고속",
            "심야우등",
            "심야고속",
            "일반",
            "일반심야",
            "프리미엄",
            "심야프리미엄"});
            this.BusGrade.Location = new System.Drawing.Point(20, 297);
            this.BusGrade.Name = "BusGrade";
            this.BusGrade.Size = new System.Drawing.Size(114, 25);
            this.BusGrade.TabIndex = 17;
            this.BusGrade.SelectedIndexChanged += new System.EventHandler(this.BusGrade_SelectedIndexChanged);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(139, 54);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(69, 48);
            this.Back.TabIndex = 15;
            this.Back.Text = "←";
            // 
            // dep1_2
            // 
            this.dep1_2.DropDownWidth = 103;
            this.dep1_2.FormattingEnabled = true;
            this.dep1_2.Items.AddRange(new object[] {
            "가조",
            "가평",
            "간성",
            "감곡",
            "강구",
            "강릉시외터미널",
            "강진(전남)",
            "거제(고현)",
            "거진",
            "거창",
            "경북대(상주)",
            "경북도청",
            "경북도청(신)",
            "경산",
            "경주고속",
            "경주시외",
            "계룡금암",
            "고금",
            "고덕",
            "고령",
            "고북",
            "고성(경남)",
            "고양(백석)",
            "고양(화정)",
            "고창",
            "고천",
            "고한사북공영",
            "고흥",
            "공도",
            "공주",
            "공주(산성)",
            "과기대앞",
            "관산",
            "광명",
            "광명(철산역)",
            "광양",
            "광주(경기)",
            "광주(유·스퀘어)",
            "광천(충남)",
            "괴산",
            "구례",
            "구리",
            "구미",
            "구미공단",
            "구미복지",
            "군산",
            "군산고속",
            "군위",
            "군포",
            "금산",
            "금촌",
            "기지시",
            "기흥역",
            "김대중컨벤션센터",
            "김제",
            "김천",
            "김천부곡한남",
            "김포공항",
            "김해",
            "김해공항",
            "나로도",
            "나주",
            "나주혁신도시",
            "낙산",
            "남교",
            "남면(태안)",
            "남선",
            "남악",
            "남악도청",
            "남원",
            "남청주",
            "남해",
            "내포시",
            "노고단(성삼재)",
            "녹동",
            "논산",
            "단양상진",
            "담양",
            "당목",
            "당진",
            "대구공항",
            "대구대",
            "대구북부",
            "대구서부",
            "대소",
            "대야",
            "대의",
            "대전도룡",
            "대전복합",
            "대전서남부",
            "대전청사",
            "대전청사(공항선)",
            "덕산(산청)",
            "덕산스파",
            "도리원",
            "동광양",
            "동대구",
            "동두천",
            "동서울",
            "동송",
            "동영천IC정류장",
            "동해",
            "땅끝",
            "마산",
            "마산남부",
            "만리포",
            "목포",
            "무안(전남)",
            "무주",
            "문경",
            "물치",
            "밀양",
            "배둔",
            "배방정류소",
            "백담사",
            "벌교",
            "보령(대천)",
            "보성",
            "봉강교",
            "봉화(경북)",
            "부곡",
            "부산동래",
            "부산동부",
            "부산서부(사상)",
            "부산해운대",
            "부안",
            "부여",
            "부천",
            "북대전IC",
            "북청주",
            "사천",
            "사천공항",
            "사천시청(용현)",
            "산청",
            "삼가",
            "삼성",
            "삼척",
            "삼천포",
            "삼호",
            "삽교천",
            "상봉",
            "상주시외",
            "서산",
            "서상(남덕유산)",
            "서수원  ",
            "서울남부",
            "서천",
            "서현리",
            "석곡",
            "성남",
            "성주",
            "세마역(오산)",
            "세종",
            "세종청사",
            "속초",
            "송도환승센터",
            "송정역",
            "송탄",
            "수안보",
            "수원터미널",
            "순창",
            "순천",
            "시지",
            "시흥",
            "신갈(용인)",
            "신남",
            "신대지구(순천)",
            "신례원",
            "신반",
            "신창",
            "신평",
            "쏠비치진도",
            "아산(온양)",
            "아주대",
            "안면도",
            "안산터미널",
            "안성",
            "안양",
            "안양역",
            "안의",
            "양구",
            "양구정중앙",
            "양산",
            "양양",
            "양주역",
            "언양",
            "엄사",
            "여수",
            "여주",
            "여천",
            "연천",
            "영광",
            "영덕",
            "영동",
            "영산(경남)",
            "영암",
            "영양",
            "영월",
            "영주",
            "영천",
            "영통",
            "영해",
            "예산",
            "예천",
            "예천삼거리",
            "오산",
            "오색",
            "오수",
            "오창산단",
            "옥과",
            "온정",
            "옹천",
            "와수리",
            "완도",
            "완산동",
            "완주혁신도시",
            "용계",
            "용원(녹산,명지)",
            "용인",
            "우만동",
            "운남",
            "운산",
            "운정(경기)",
            "울산",
            "울산고속",
            "울산공항",
            "울산신복",
            "울진",
            "원주",
            "원지",
            "원통",
            "월곶삼거리",
            "유성",
            "음성",
            "음암",
            "의령",
            "의성",
            "의정부",
            "이천",
            "익산",
            "익산IC",
            "익산고속",
            "익산왕궁",
            "인월",
            "인제",
            "인천",
            "일동",
            "임실",
            "임자(대광)",
            "임자(진리)",
            "자운대",
            "장계",
            "장성",
            "장수",
            "장승포",
            "장신대",
            "장유",
            "장유(환승)",
            "장평",
            "장항",
            "장호",
            "전북(완주)혁신도시",
            "전주(리무진터미널)",
            "전주대",
            "전주시외터미널",
            "점촌",
            "정선",
            "정읍",
            "제천",
            "조치원",
            "좌천",
            "주문진",
            "주왕산",
            "중산리",
            "지리산(백무동)",
            "진도",
            "진보",
            "진부",
            "진안",
            "진영",
            "진주",
            "진주(개양)",
            "진주(경남)",
            "진주혁신도시",
            "진천",
            "진해",
            "진해경찰서",
            "창기리",
            "창녕",
            "창원",
            "창원남산",
            "창원역",
            "천안",
            "천안아산(KTX)역",
            "청도(경북)",
            "청송",
            "청양",
            "청주",
            "청주공항",
            "청주북부터미널",
            "청주사창",
            "춘양",
            "춘천",
            "충주",
            "칠원예곡",
            "칠원읍",
            "코엑스(도심공항)",
            "태백",
            "태안",
            "통영",
            "평창",
            "평택",
            "평해",
            "포항",
            "풍기IC",
            "하남BRT",
            "하동",
            "하양",
            "하조대",
            "한서대",
            "함안가야",
            "함안군북(39사단)",
            "함양",
            "함창",
            "함평",
            "합덕",
            "합천",
            "해남",
            "해미",
            "현풍",
            "호계동",
            "호남제일문",
            "호산",
            "홍농",
            "홍성",
            "홍천",
            "화개공용",
            "화천",
            "횡계",
            "횡성",
            "효문",
            "후포"});
            this.dep1_2.Location = new System.Drawing.Point(20, 129);
            this.dep1_2.Name = "dep1_2";
            this.dep1_2.Size = new System.Drawing.Size(103, 25);
            this.dep1_2.TabIndex = 10;
            this.dep1_2.SelectedIndexChanged += new System.EventHandler(this.dep1_2_SelectedIndexChanged);
            // 
            // Destination
            // 
            this.Destination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.Destination.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Destination.ForeColor = System.Drawing.SystemColors.Window;
            this.Destination.Location = new System.Drawing.Point(207, 41);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(125, 40);
            this.Destination.TabIndex = 16;
            this.Destination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Departure
            // 
            this.Departure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.Departure.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Departure.ForeColor = System.Drawing.SystemColors.Window;
            this.Departure.Location = new System.Drawing.Point(13, 41);
            this.Departure.Name = "Departure";
            this.Departure.Size = new System.Drawing.Size(125, 40);
            this.Departure.TabIndex = 15;
            this.Departure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
       
            // 
            // Go
            // 
            this.Go.AutoSize = true;
            this.Go.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go.Location = new System.Drawing.Point(142, 21);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(69, 48);
            this.Go.TabIndex = 14;
            this.Go.Text = "→";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listView1.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(392, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(447, 542);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "등급";
            this.columnHeader9.Width = 56;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "출발";
            this.columnHeader10.Width = 55;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "도착";
            this.columnHeader11.Width = 49;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "출발지";
            this.columnHeader12.Width = 67;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "도착지";
            this.columnHeader13.Width = 74;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "운임료";
            this.columnHeader14.Width = 78;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView2.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView2.ForeColor = System.Drawing.Color.White;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(862, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(447, 542);
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "등급";
            this.columnHeader2.Width = 56;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "출발";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "도착";
            this.columnHeader4.Width = 49;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "출발지";
            this.columnHeader5.Width = 67;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "도착지";
            this.columnHeader6.Width = 74;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "운임료";
            this.columnHeader7.Width = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.label10.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(204, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "왕복";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.label9.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(199, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "편도";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Grad);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Dest);
            this.panel2.Controls.Add(this.Depa);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Date);
            this.panel2.Location = new System.Drawing.Point(199, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 147);
            this.panel2.TabIndex = 13;
            // 
            // Grad
            // 
            this.Grad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.Grad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grad.ForeColor = System.Drawing.SystemColors.Window;
            this.Grad.Location = new System.Drawing.Point(60, 114);
            this.Grad.Name = "Grad";
            this.Grad.Size = new System.Drawing.Size(102, 14);
            this.Grad.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "등급 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(19, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "날짜 : ";
            // 
            // Dest
            // 
            this.Dest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.Dest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dest.ForeColor = System.Drawing.SystemColors.Window;
            this.Dest.Location = new System.Drawing.Point(60, 84);
            this.Dest.Name = "Dest";
            this.Dest.Size = new System.Drawing.Size(102, 14);
            this.Dest.TabIndex = 6;
            // 
            // Depa
            // 
            this.Depa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.Depa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Depa.ForeColor = System.Drawing.SystemColors.Window;
            this.Depa.Location = new System.Drawing.Point(60, 53);
            this.Depa.Name = "Depa";
            this.Depa.Size = new System.Drawing.Size(102, 14);
            this.Depa.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(19, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "도착 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(19, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "출발 : ";
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Date.ForeColor = System.Drawing.SystemColors.Window;
            this.Date.Location = new System.Drawing.Point(63, 21);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(102, 14);
            this.Date.TabIndex = 0;
          
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Grad2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Dest2);
            this.panel3.Controls.Add(this.Depa2);
            this.panel3.Controls.Add(this.Date2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(202, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 149);
            this.panel3.TabIndex = 12;
            // 
            // Grad2
            // 
            this.Grad2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.Grad2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grad2.ForeColor = System.Drawing.SystemColors.Window;
            this.Grad2.Location = new System.Drawing.Point(58, 111);
            this.Grad2.Name = "Grad2";
            this.Grad2.Size = new System.Drawing.Size(102, 14);
            this.Grad2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(16, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "등급 : ";
            // 
            // Dest2
            // 
            this.Dest2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.Dest2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dest2.ForeColor = System.Drawing.SystemColors.Window;
            this.Dest2.Location = new System.Drawing.Point(58, 80);
            this.Dest2.Name = "Dest2";
            this.Dest2.Size = new System.Drawing.Size(102, 14);
            this.Dest2.TabIndex = 10;
            // 
            // Depa2
            // 
            this.Depa2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.Depa2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Depa2.ForeColor = System.Drawing.SystemColors.Window;
            this.Depa2.Location = new System.Drawing.Point(58, 49);
            this.Depa2.Name = "Depa2";
            this.Depa2.Size = new System.Drawing.Size(102, 14);
            this.Depa2.TabIndex = 9;
            // 
            // Date2
            // 
            this.Date2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.Date2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Date2.ForeColor = System.Drawing.SystemColors.Window;
            this.Date2.Location = new System.Drawing.Point(59, 18);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(102, 14);
            this.Date2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "날짜 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "도착 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "출발 : ";
            // 
            // FormBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1224, 554);
            this.Controls.Add(this.flpnlDetail);
            this.Controls.Add(this.pnlBusMenu);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBus";
            this.Text = "고속/일반버스";
            this.Load += new System.EventHandler(this.FormBus_Load);
            this.pnlBusMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlWayToggle.ResumeLayout(false);
            this.flpnlDetail.ResumeLayout(false);
            this.flpnlDetail.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Panel pnlBusMenu;
        private System.Windows.Forms.Panel pnlWayToggle;
        private System.Windows.Forms.Button btnWayToggle_CountrySide;
        private System.Windows.Forms.Timer tmrPanelMove;
        private System.Windows.Forms.Button btnBusMenu_SeatClass;
        private System.Windows.Forms.Button btnBusMenu_Date;
        private System.Windows.Forms.Button btnBusMenu_Destination;
        private System.Windows.Forms.Button btnBusMenu_Departure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWayToggle_Single;
        private System.Windows.Forms.Button btnWayToggle_RoundTrip;
        private System.Windows.Forms.Button btnWayToggle_Express;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox arr1;
        private System.Windows.Forms.ComboBox dep1;
        private System.Windows.Forms.Button Exp;
        private System.Windows.Forms.Panel flpnlDetail;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.TextBox Departure;
        private System.Windows.Forms.Label Go;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox BusGrade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Dest;
        private System.Windows.Forms.TextBox Depa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.ComboBox dep1_2;
        private System.Windows.Forms.TextBox arr2_2;
        private System.Windows.Forms.TextBox arr2;
        private System.Windows.Forms.TextBox dep2_2;
        private System.Windows.Forms.TextBox dep2;
        private System.Windows.Forms.ComboBox BusGrade_2;
        private System.Windows.Forms.ComboBox arr1_2;
        private System.Windows.Forms.TextBox Dest2;
        private System.Windows.Forms.TextBox Depa2;
        private System.Windows.Forms.TextBox Date2;
        private System.Windows.Forms.TextBox Grad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Grad2;
        private System.Windows.Forms.Label label6;
    }
}
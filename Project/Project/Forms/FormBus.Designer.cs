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
            this.button1 = new System.Windows.Forms.Button();
            this.flpnlDetail = new System.Windows.Forms.Panel();
            this.BusGrade = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.TextBox();
            this.Departure = new System.Windows.Forms.TextBox();
            this.Go = new System.Windows.Forms.Label();
            this.arr2 = new System.Windows.Forms.ComboBox();
            this.dep2 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // 
            // btnBusMenu_SeatClass
            // 
            this.btnBusMenu_SeatClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBusMenu_SeatClass.FlatAppearance.BorderSize = 0;
            this.btnBusMenu_SeatClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusMenu_SeatClass.Font = new System.Drawing.Font("서울남산체 B", 13F);
            this.btnBusMenu_SeatClass.ForeColor = System.Drawing.Color.White;
            this.btnBusMenu_SeatClass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusMenu_SeatClass.Location = new System.Drawing.Point(0, 280);
            this.btnBusMenu_SeatClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBusMenu_SeatClass.Name = "btnBusMenu_SeatClass";
            this.btnBusMenu_SeatClass.Size = new System.Drawing.Size(175, 56);
            this.btnBusMenu_SeatClass.TabIndex = 9;
            this.btnBusMenu_SeatClass.Text = " 버스등급";
            this.btnBusMenu_SeatClass.UseVisualStyleBackColor = true;
            this.btnBusMenu_SeatClass.Click += new System.EventHandler(this.btnBusMenu_SeatClass_Click);
            // 
            // btnBusMenu_Date
            // 
            this.btnBusMenu_Date.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBusMenu_Date.FlatAppearance.BorderSize = 0;
            this.btnBusMenu_Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusMenu_Date.Font = new System.Drawing.Font("서울남산체 B", 13F);
            this.btnBusMenu_Date.ForeColor = System.Drawing.Color.White;
            this.btnBusMenu_Date.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusMenu_Date.Location = new System.Drawing.Point(0, 224);
            this.btnBusMenu_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBusMenu_Date.Name = "btnBusMenu_Date";
            this.btnBusMenu_Date.Size = new System.Drawing.Size(175, 56);
            this.btnBusMenu_Date.TabIndex = 8;
            this.btnBusMenu_Date.Text = "  날짜";
            this.btnBusMenu_Date.UseVisualStyleBackColor = true;
            this.btnBusMenu_Date.Click += new System.EventHandler(this.btnBusMenu_Date_Click);
            // 
            // btnBusMenu_Destination
            // 
            this.btnBusMenu_Destination.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBusMenu_Destination.FlatAppearance.BorderSize = 0;
            this.btnBusMenu_Destination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusMenu_Destination.Font = new System.Drawing.Font("서울남산체 B", 13F);
            this.btnBusMenu_Destination.ForeColor = System.Drawing.Color.White;
            this.btnBusMenu_Destination.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusMenu_Destination.Location = new System.Drawing.Point(0, 168);
            this.btnBusMenu_Destination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBusMenu_Destination.Name = "btnBusMenu_Destination";
            this.btnBusMenu_Destination.Size = new System.Drawing.Size(175, 56);
            this.btnBusMenu_Destination.TabIndex = 7;
            this.btnBusMenu_Destination.Text = "  도착지";
            this.btnBusMenu_Destination.UseVisualStyleBackColor = true;
            this.btnBusMenu_Destination.Click += new System.EventHandler(this.btnBusMenu_Destination_Click);
            // 
            // btnBusMenu_Departure
            // 
            this.btnBusMenu_Departure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBusMenu_Departure.FlatAppearance.BorderSize = 0;
            this.btnBusMenu_Departure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusMenu_Departure.Font = new System.Drawing.Font("서울남산체 B", 13F);
            this.btnBusMenu_Departure.ForeColor = System.Drawing.Color.White;
            this.btnBusMenu_Departure.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusMenu_Departure.Location = new System.Drawing.Point(0, 112);
            this.btnBusMenu_Departure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBusMenu_Departure.Name = "btnBusMenu_Departure";
            this.btnBusMenu_Departure.Size = new System.Drawing.Size(175, 56);
            this.btnBusMenu_Departure.TabIndex = 6;
            this.btnBusMenu_Departure.Text = "  출발지";
            this.btnBusMenu_Departure.UseVisualStyleBackColor = true;
            this.btnBusMenu_Departure.Click += new System.EventHandler(this.btnBusMenu_Departure_Click);
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
            this.btnWayToggle_Single.Font = new System.Drawing.Font("서울남산체 B", 13F);
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
            this.btnWayToggle_RoundTrip.Font = new System.Drawing.Font("서울남산체 B", 13F);
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
            this.btnWayToggle_CountrySide.Font = new System.Drawing.Font("서울남산체 B", 13F);
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
            this.btnWayToggle_Express.Font = new System.Drawing.Font("서울남산체 B", 13F);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.button1.Font = new System.Drawing.Font("서울남산체 B", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(139, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flpnlDetail
            // 
            this.flpnlDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpnlDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.flpnlDetail.Controls.Add(this.BusGrade);
            this.flpnlDetail.Controls.Add(this.Back);
            this.flpnlDetail.Controls.Add(this.Destination);
            this.flpnlDetail.Controls.Add(this.Departure);
            this.flpnlDetail.Controls.Add(this.dateTimePicker2);
            this.flpnlDetail.Controls.Add(this.Go);
            this.flpnlDetail.Controls.Add(this.dateTimePicker1);
            this.flpnlDetail.Controls.Add(this.arr2);
            this.flpnlDetail.Controls.Add(this.arr1);
            this.flpnlDetail.Controls.Add(this.dep2);
            this.flpnlDetail.Controls.Add(this.dep1);
            this.flpnlDetail.Controls.Add(this.button1);
            this.flpnlDetail.Font = new System.Drawing.Font("서울남산체 B", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.flpnlDetail.ForeColor = System.Drawing.Color.White;
            this.flpnlDetail.Location = new System.Drawing.Point(175, 0);
            this.flpnlDetail.Margin = new System.Windows.Forms.Padding(0);
            this.flpnlDetail.MaximumSize = new System.Drawing.Size(350, 2400);
            this.flpnlDetail.MinimumSize = new System.Drawing.Size(0, 2400);
            this.flpnlDetail.Name = "flpnlDetail";
            this.flpnlDetail.Size = new System.Drawing.Size(350, 2400);
            this.flpnlDetail.TabIndex = 3;
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
            // Destination
            // 
            this.Destination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.Destination.Font = new System.Drawing.Font("서울남산체 B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.Departure.Font = new System.Drawing.Font("서울남산체 B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            // arr2
            // 
            this.arr2.FormattingEnabled = true;
            this.arr2.Items.AddRange(new object[] {
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
            this.arr2.Location = new System.Drawing.Point(206, 185);
            this.arr2.Name = "arr2";
            this.arr2.Size = new System.Drawing.Size(103, 25);
            this.arr2.TabIndex = 12;
            // 
            // dep2
            // 
            this.dep2.FormattingEnabled = true;
            this.dep2.Items.AddRange(new object[] {
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
            this.dep2.Location = new System.Drawing.Point(206, 129);
            this.dep2.Name = "dep2";
            this.dep2.Size = new System.Drawing.Size(103, 25);
            this.dep2.TabIndex = 13;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(628, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(447, 403);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "노선ID";
            this.columnHeader8.Width = 64;
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
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView2.ForeColor = System.Drawing.Color.White;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(175, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(447, 403);
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "노선ID";
            this.columnHeader1.Width = 64;
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
            this.label10.Font = new System.Drawing.Font("남양주고딕EB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1096, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "왕복";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.label9.Font = new System.Drawing.Font("남양주고딕EB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1094, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "편도";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Location = new System.Drawing.Point(1094, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 147);
            this.panel2.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(73, 111);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(66, 21);
            this.textBox5.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "날짜";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(73, 80);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(66, 21);
            this.textBox6.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "소요시간";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(73, 50);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(66, 21);
            this.textBox7.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "도착";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "출발";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(73, 19);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(66, 21);
            this.textBox8.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(1094, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 147);
            this.panel3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(73, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(66, 21);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "날짜";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 21);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "소요시간";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 21);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "도착";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "출발";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 21);
            this.textBox1.TabIndex = 0;
            // 
            // FormBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 554);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flpnlDetail);
            this.Controls.Add(this.pnlBusMenu);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel flpnlDetail;
        private System.Windows.Forms.ComboBox arr2;
        private System.Windows.Forms.ComboBox dep2;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.TextBox Departure;
        private System.Windows.Forms.Label Go;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
namespace Project.Forms {
	partial class FormRouteSearch {
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
            this.pnlRSMenu = new System.Windows.Forms.Panel();
            this.btnRSMenu_RSSearch = new System.Windows.Forms.Button();
            this.btnRSMenu_HeadCount = new System.Windows.Forms.Button();
            this.btnRSMenu_Destination = new System.Windows.Forms.Button();
            this.btnRSMenu_Departure = new System.Windows.Forms.Button();
            this.pnlWayToggle = new System.Windows.Forms.Panel();
            this.btnWayToggle_Single = new System.Windows.Forms.Button();
            this.btnWayToggle_RoundTrip = new System.Windows.Forms.Button();
            this.tmrPanelMove = new System.Windows.Forms.Timer(this.components);
            this.lvTransport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvStartLoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEndLoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSpendTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvResult = new System.Windows.Forms.ListView();
            this.lvStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button36 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flpnlDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.cldDatePicker = new System.Windows.Forms.MonthCalendar();
            this.pnlRSMenu.SuspendLayout();
            this.pnlWayToggle.SuspendLayout();
            this.flpnlDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRSMenu
            // 
            this.pnlRSMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.pnlRSMenu.Controls.Add(this.btnRSMenu_RSSearch);
            this.pnlRSMenu.Controls.Add(this.btnRSMenu_HeadCount);
            this.pnlRSMenu.Controls.Add(this.btnRSMenu_Destination);
            this.pnlRSMenu.Controls.Add(this.btnRSMenu_Departure);
            this.pnlRSMenu.Controls.Add(this.pnlWayToggle);
            this.pnlRSMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlRSMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRSMenu.Name = "pnlRSMenu";
            this.pnlRSMenu.Size = new System.Drawing.Size(175, 2400);
            this.pnlRSMenu.TabIndex = 3;
            // 
            // btnRSMenu_RSSearch
            // 
            this.btnRSMenu_RSSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRSMenu_RSSearch.FlatAppearance.BorderSize = 0;
            this.btnRSMenu_RSSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSMenu_RSSearch.Font = new System.Drawing.Font("서울남산체 B", 13F);
            this.btnRSMenu_RSSearch.ForeColor = System.Drawing.Color.White;
            this.btnRSMenu_RSSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRSMenu_RSSearch.Location = new System.Drawing.Point(0, 224);
            this.btnRSMenu_RSSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRSMenu_RSSearch.Name = "btnRSMenu_RSSearch";
            this.btnRSMenu_RSSearch.Size = new System.Drawing.Size(175, 56);
            this.btnRSMenu_RSSearch.TabIndex = 5;
            this.btnRSMenu_RSSearch.Text = "  경로탐색";
            this.btnRSMenu_RSSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRSMenu_RSSearch.UseVisualStyleBackColor = true;
            this.btnRSMenu_RSSearch.Click += new System.EventHandler(this.btnRSMenu_RSSearch_Click);
            // 
            // btnRSMenu_HeadCount
            // 
            this.btnRSMenu_HeadCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRSMenu_HeadCount.FlatAppearance.BorderSize = 0;
            this.btnRSMenu_HeadCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSMenu_HeadCount.Font = new System.Drawing.Font("서울남산체 B", 13F);
            this.btnRSMenu_HeadCount.ForeColor = System.Drawing.Color.White;
            this.btnRSMenu_HeadCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRSMenu_HeadCount.Location = new System.Drawing.Point(0, 168);
            this.btnRSMenu_HeadCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRSMenu_HeadCount.Name = "btnRSMenu_HeadCount";
            this.btnRSMenu_HeadCount.Size = new System.Drawing.Size(175, 56);
            this.btnRSMenu_HeadCount.TabIndex = 3;
            this.btnRSMenu_HeadCount.Text = "  출발날짜";
            this.btnRSMenu_HeadCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRSMenu_HeadCount.UseVisualStyleBackColor = true;
            this.btnRSMenu_HeadCount.Click += new System.EventHandler(this.btnRSMenu_HeadCount_Click);
            // 
            // btnRSMenu_Destination
            // 
            this.btnRSMenu_Destination.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRSMenu_Destination.FlatAppearance.BorderSize = 0;
            this.btnRSMenu_Destination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSMenu_Destination.Font = new System.Drawing.Font("서울남산체 B", 13F);
            this.btnRSMenu_Destination.ForeColor = System.Drawing.Color.White;
            this.btnRSMenu_Destination.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRSMenu_Destination.Location = new System.Drawing.Point(0, 112);
            this.btnRSMenu_Destination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRSMenu_Destination.Name = "btnRSMenu_Destination";
            this.btnRSMenu_Destination.Size = new System.Drawing.Size(175, 56);
            this.btnRSMenu_Destination.TabIndex = 2;
            this.btnRSMenu_Destination.Text = "  도착지";
            this.btnRSMenu_Destination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRSMenu_Destination.UseVisualStyleBackColor = true;
            this.btnRSMenu_Destination.Click += new System.EventHandler(this.btnRSMenu_Destination_Click);
            // 
            // btnRSMenu_Departure
            // 
            this.btnRSMenu_Departure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRSMenu_Departure.FlatAppearance.BorderSize = 0;
            this.btnRSMenu_Departure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSMenu_Departure.Font = new System.Drawing.Font("서울남산체 B", 13F);
            this.btnRSMenu_Departure.ForeColor = System.Drawing.Color.White;
            this.btnRSMenu_Departure.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRSMenu_Departure.Location = new System.Drawing.Point(0, 56);
            this.btnRSMenu_Departure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRSMenu_Departure.Name = "btnRSMenu_Departure";
            this.btnRSMenu_Departure.Size = new System.Drawing.Size(175, 56);
            this.btnRSMenu_Departure.TabIndex = 1;
            this.btnRSMenu_Departure.Text = "  출발지";
            this.btnRSMenu_Departure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRSMenu_Departure.UseVisualStyleBackColor = true;
            this.btnRSMenu_Departure.Click += new System.EventHandler(this.btnRSMenu_Departure_Click);
            // 
            // pnlWayToggle
            // 
            this.pnlWayToggle.Controls.Add(this.btnWayToggle_Single);
            this.pnlWayToggle.Controls.Add(this.btnWayToggle_RoundTrip);
            this.pnlWayToggle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWayToggle.Location = new System.Drawing.Point(0, 0);
            this.pnlWayToggle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlWayToggle.Name = "pnlWayToggle";
            this.pnlWayToggle.Size = new System.Drawing.Size(175, 56);
            this.pnlWayToggle.TabIndex = 0;
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
            // tmrPanelMove
            // 
            this.tmrPanelMove.Enabled = true;
            this.tmrPanelMove.Interval = 15;
            this.tmrPanelMove.Tick += new System.EventHandler(this.tmrPanelMove_Tick);
            // 
            // lvTransport
            // 
            this.lvTransport.Text = "교통수단";
            this.lvTransport.Width = 100;
            // 
            // lvStartLoc
            // 
            this.lvStartLoc.Text = "출발위치";
            this.lvStartLoc.Width = 160;
            // 
            // lvEndLoc
            // 
            this.lvEndLoc.Text = "도착위치";
            this.lvEndLoc.Width = 160;
            // 
            // lvCost
            // 
            this.lvCost.Text = "요금(원)";
            this.lvCost.Width = 100;
            // 
            // lvSpendTime
            // 
            this.lvSpendTime.Text = "소요시간";
            this.lvSpendTime.Width = 100;
            // 
            // lvResult
            // 
            this.lvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvTransport,
            this.lvStartLoc,
            this.lvStartTime,
            this.lvEndLoc,
            this.lvEndTime,
            this.lvCost,
            this.lvSpendTime});
            this.lvResult.Font = new System.Drawing.Font("서울남산체 B", 10F);
            this.lvResult.ForeColor = System.Drawing.Color.White;
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(174, -1);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(534, 390);
            this.lvResult.TabIndex = 5;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            this.lvResult.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_ColumnClick);
            // 
            // lvStartTime
            // 
            this.lvStartTime.Text = "출발시각";
            this.lvStartTime.Width = 100;
            // 
            // lvEndTime
            // 
            this.lvEndTime.Text = "도착시각";
            this.lvEndTime.Width = 100;
            // 
            // button36
            // 
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button36.ForeColor = System.Drawing.Color.White;
            this.button36.Location = new System.Drawing.Point(3, 380);
            this.button36.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(63, 50);
            this.button36.TabIndex = 37;
            this.button36.Text = "대구";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button35
            // 
            this.button35.FlatAppearance.BorderSize = 0;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button35.ForeColor = System.Drawing.Color.White;
            this.button35.Location = new System.Drawing.Point(279, 326);
            this.button35.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(63, 50);
            this.button35.TabIndex = 36;
            this.button35.Text = "대구";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button34
            // 
            this.button34.FlatAppearance.BorderSize = 0;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button34.ForeColor = System.Drawing.Color.White;
            this.button34.Location = new System.Drawing.Point(210, 326);
            this.button34.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(63, 50);
            this.button34.TabIndex = 35;
            this.button34.Text = "대구";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button33
            // 
            this.button33.FlatAppearance.BorderSize = 0;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button33.ForeColor = System.Drawing.Color.White;
            this.button33.Location = new System.Drawing.Point(141, 326);
            this.button33.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(63, 50);
            this.button33.TabIndex = 34;
            this.button33.Text = "대구";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button32
            // 
            this.button32.FlatAppearance.BorderSize = 0;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button32.ForeColor = System.Drawing.Color.White;
            this.button32.Location = new System.Drawing.Point(72, 326);
            this.button32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(63, 50);
            this.button32.TabIndex = 33;
            this.button32.Text = "대구";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button31
            // 
            this.button31.FlatAppearance.BorderSize = 0;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button31.ForeColor = System.Drawing.Color.White;
            this.button31.Location = new System.Drawing.Point(3, 326);
            this.button31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(63, 50);
            this.button31.TabIndex = 32;
            this.button31.Text = "대구";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button30
            // 
            this.button30.FlatAppearance.BorderSize = 0;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button30.ForeColor = System.Drawing.Color.White;
            this.button30.Location = new System.Drawing.Point(279, 272);
            this.button30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(63, 50);
            this.button30.TabIndex = 31;
            this.button30.Text = "대구";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button29
            // 
            this.button29.FlatAppearance.BorderSize = 0;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button29.ForeColor = System.Drawing.Color.White;
            this.button29.Location = new System.Drawing.Point(210, 272);
            this.button29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(63, 50);
            this.button29.TabIndex = 30;
            this.button29.Text = "대구";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button28
            // 
            this.button28.FlatAppearance.BorderSize = 0;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button28.ForeColor = System.Drawing.Color.White;
            this.button28.Location = new System.Drawing.Point(141, 272);
            this.button28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(63, 50);
            this.button28.TabIndex = 29;
            this.button28.Text = "대구";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button27
            // 
            this.button27.FlatAppearance.BorderSize = 0;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button27.ForeColor = System.Drawing.Color.White;
            this.button27.Location = new System.Drawing.Point(72, 272);
            this.button27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(63, 50);
            this.button27.TabIndex = 28;
            this.button27.Text = "대구";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button26
            // 
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button26.ForeColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(3, 272);
            this.button26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(63, 50);
            this.button26.TabIndex = 27;
            this.button26.Text = "대구";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button25
            // 
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button25.ForeColor = System.Drawing.Color.White;
            this.button25.Location = new System.Drawing.Point(279, 218);
            this.button25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(63, 50);
            this.button25.TabIndex = 26;
            this.button25.Text = "대구";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button24
            // 
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button24.ForeColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(210, 218);
            this.button24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(63, 50);
            this.button24.TabIndex = 25;
            this.button24.Text = "대구";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button23
            // 
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(141, 218);
            this.button23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(63, 50);
            this.button23.TabIndex = 24;
            this.button23.Text = "대구";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button22
            // 
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(72, 218);
            this.button22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(63, 50);
            this.button22.TabIndex = 23;
            this.button22.Text = "대구";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button21
            // 
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(3, 218);
            this.button21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(63, 50);
            this.button21.TabIndex = 22;
            this.button21.Text = "대구";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button20
            // 
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(279, 164);
            this.button20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(63, 50);
            this.button20.TabIndex = 21;
            this.button20.Text = "대구";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button19
            // 
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(210, 164);
            this.button19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(63, 50);
            this.button19.TabIndex = 20;
            this.button19.Text = "대구";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(141, 164);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(63, 50);
            this.button18.TabIndex = 19;
            this.button18.Text = "대구";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button17
            // 
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(72, 164);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(63, 50);
            this.button17.TabIndex = 18;
            this.button17.Text = "제주";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button16
            // 
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(3, 164);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(63, 50);
            this.button16.TabIndex = 17;
            this.button16.Text = "경남";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(279, 110);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(63, 50);
            this.button15.TabIndex = 16;
            this.button15.Text = "경북";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(210, 110);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(63, 50);
            this.button14.TabIndex = 15;
            this.button14.Text = "전남";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(141, 110);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(63, 50);
            this.button13.TabIndex = 14;
            this.button13.Text = "전북";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(72, 110);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(63, 50);
            this.button12.TabIndex = 13;
            this.button12.Text = "충남";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(3, 110);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(63, 50);
            this.button11.TabIndex = 12;
            this.button11.Text = "충북";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(279, 56);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(63, 50);
            this.button10.TabIndex = 11;
            this.button10.Text = "강원";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(210, 56);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 50);
            this.button9.TabIndex = 10;
            this.button9.Text = "경기";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(141, 56);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(63, 50);
            this.button8.TabIndex = 9;
            this.button8.Text = "세종";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(72, 56);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 50);
            this.button7.TabIndex = 8;
            this.button7.Text = "울산";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(3, 56);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 50);
            this.button6.TabIndex = 7;
            this.button6.Text = "대전";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(279, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 50);
            this.button5.TabIndex = 6;
            this.button5.Text = "광주";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(210, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "인천";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(141, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "대구";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(72, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "부산";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "서울";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMetro_Click);
            // 
            // flpnlDetail
            // 
            this.flpnlDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpnlDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.flpnlDetail.Controls.Add(this.button1);
            this.flpnlDetail.Controls.Add(this.button2);
            this.flpnlDetail.Controls.Add(this.button3);
            this.flpnlDetail.Controls.Add(this.button4);
            this.flpnlDetail.Controls.Add(this.button5);
            this.flpnlDetail.Controls.Add(this.button6);
            this.flpnlDetail.Controls.Add(this.button7);
            this.flpnlDetail.Controls.Add(this.button8);
            this.flpnlDetail.Controls.Add(this.button9);
            this.flpnlDetail.Controls.Add(this.button10);
            this.flpnlDetail.Controls.Add(this.button11);
            this.flpnlDetail.Controls.Add(this.button12);
            this.flpnlDetail.Controls.Add(this.button13);
            this.flpnlDetail.Controls.Add(this.button14);
            this.flpnlDetail.Controls.Add(this.button15);
            this.flpnlDetail.Controls.Add(this.button16);
            this.flpnlDetail.Controls.Add(this.button17);
            this.flpnlDetail.Controls.Add(this.button18);
            this.flpnlDetail.Controls.Add(this.button19);
            this.flpnlDetail.Controls.Add(this.button20);
            this.flpnlDetail.Controls.Add(this.button21);
            this.flpnlDetail.Controls.Add(this.button22);
            this.flpnlDetail.Controls.Add(this.button23);
            this.flpnlDetail.Controls.Add(this.button24);
            this.flpnlDetail.Controls.Add(this.button25);
            this.flpnlDetail.Controls.Add(this.button26);
            this.flpnlDetail.Controls.Add(this.button27);
            this.flpnlDetail.Controls.Add(this.button28);
            this.flpnlDetail.Controls.Add(this.button29);
            this.flpnlDetail.Controls.Add(this.button30);
            this.flpnlDetail.Controls.Add(this.button31);
            this.flpnlDetail.Controls.Add(this.button32);
            this.flpnlDetail.Controls.Add(this.button33);
            this.flpnlDetail.Controls.Add(this.button34);
            this.flpnlDetail.Controls.Add(this.button35);
            this.flpnlDetail.Controls.Add(this.button36);
            this.flpnlDetail.Font = new System.Drawing.Font("서울남산체 B", 13F, System.Drawing.FontStyle.Bold);
            this.flpnlDetail.ForeColor = System.Drawing.Color.White;
            this.flpnlDetail.Location = new System.Drawing.Point(176, 0);
            this.flpnlDetail.Margin = new System.Windows.Forms.Padding(0);
            this.flpnlDetail.MaximumSize = new System.Drawing.Size(350, 2400);
            this.flpnlDetail.MinimumSize = new System.Drawing.Size(0, 2400);
            this.flpnlDetail.Name = "flpnlDetail";
            this.flpnlDetail.Size = new System.Drawing.Size(350, 2400);
            this.flpnlDetail.TabIndex = 4;
            // 
            // cldDatePicker
            // 
            this.cldDatePicker.Font = new System.Drawing.Font("서울남산체 B", 12F);
            this.cldDatePicker.Location = new System.Drawing.Point(240, 83);
            this.cldDatePicker.Name = "cldDatePicker";
            this.cldDatePicker.TabIndex = 6;
            this.cldDatePicker.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cldDatePicker_DateChanged);
            // 
            // FormRouteSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 347);
            this.Controls.Add(this.cldDatePicker);
            this.Controls.Add(this.flpnlDetail);
            this.Controls.Add(this.pnlRSMenu);
            this.Controls.Add(this.lvResult);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRouteSearch";
            this.Text = "통합경로검색";
            this.Load += new System.EventHandler(this.FormRouteSearch_Load);
            this.pnlRSMenu.ResumeLayout(false);
            this.pnlWayToggle.ResumeLayout(false);
            this.flpnlDetail.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel pnlRSMenu;
        private System.Windows.Forms.Button btnRSMenu_HeadCount;
        private System.Windows.Forms.Button btnRSMenu_Departure;
        private System.Windows.Forms.Panel pnlWayToggle;
        private System.Windows.Forms.Button btnWayToggle_Single;
        private System.Windows.Forms.Button btnWayToggle_RoundTrip;
        private System.Windows.Forms.Timer tmrPanelMove;
        private System.Windows.Forms.Button btnRSMenu_RSSearch;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader lvTransport;
        private System.Windows.Forms.ColumnHeader lvStartLoc;
        private System.Windows.Forms.ColumnHeader lvEndLoc;
        private System.Windows.Forms.ColumnHeader lvCost;
        private System.Windows.Forms.ColumnHeader lvSpendTime;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flpnlDetail;
        private System.Windows.Forms.Button btnRSMenu_Destination;
        private System.Windows.Forms.MonthCalendar cldDatePicker;
        private System.Windows.Forms.ColumnHeader lvEndTime;
        private System.Windows.Forms.ColumnHeader lvStartTime;
    }
}
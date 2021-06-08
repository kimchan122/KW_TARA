namespace Project.Forms {
	partial class FormTrain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrain));
            this.pnlPlaneMenu = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnTrainMenu_TrainSort = new System.Windows.Forms.Button();
            this.btnTrainMenu_Destination = new System.Windows.Forms.Button();
            this.btnTrainMenu_Departure = new System.Windows.Forms.Button();
            this.pnlWayToggle = new System.Windows.Forms.Panel();
            this.btnWayToggle_Single = new System.Windows.Forms.Button();
            this.btnWayToggle_RoundTrip = new System.Windows.Forms.Button();
            this.tmrPanelMove = new System.Windows.Forms.Timer(this.components);
            this.flpnlDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.tPnlCity = new System.Windows.Forms.TableLayoutPanel();
            this.tPnlStation = new System.Windows.Forms.TableLayoutPanel();
            this.tPnlSort = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateToGo = new System.Windows.Forms.Label();
            this.goCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblDateToCome = new System.Windows.Forms.Label();
            this.comeCalendar = new System.Windows.Forms.MonthCalendar();
            this.listResultToGo = new System.Windows.Forms.ListView();
            this.colTrainSort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDepTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArrTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flpnlResult = new System.Windows.Forms.FlowLayoutPanel();
            this.lblResultToGo = new System.Windows.Forms.Label();
            this.lblResultToCome = new System.Windows.Forms.Label();
            this.listResultToCome = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlPlaneMenu.SuspendLayout();
            this.pnlWayToggle.SuspendLayout();
            this.flpnlDetail.SuspendLayout();
            this.flpnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlaneMenu
            // 
            this.pnlPlaneMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.pnlPlaneMenu.Controls.Add(this.btnSearch);
            this.pnlPlaneMenu.Controls.Add(this.btnDate);
            this.pnlPlaneMenu.Controls.Add(this.btnTrainMenu_TrainSort);
            this.pnlPlaneMenu.Controls.Add(this.btnTrainMenu_Destination);
            this.pnlPlaneMenu.Controls.Add(this.btnTrainMenu_Departure);
            this.pnlPlaneMenu.Controls.Add(this.pnlWayToggle);
            this.pnlPlaneMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPlaneMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlPlaneMenu.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pnlPlaneMenu.Name = "pnlPlaneMenu";
            this.pnlPlaneMenu.Size = new System.Drawing.Size(325, 852);
            this.pnlPlaneMenu.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(0, 740);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(325, 112);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "열차 조회";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDate
            // 
            this.btnDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDate.FlatAppearance.BorderSize = 0;
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDate.ForeColor = System.Drawing.Color.White;
            this.btnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDate.Location = new System.Drawing.Point(0, 448);
            this.btnDate.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(325, 112);
            this.btnDate.TabIndex = 5;
            this.btnDate.Text = "날짜 선택";
            this.btnDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnTrainMenu_TrainSort
            // 
            this.btnTrainMenu_TrainSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrainMenu_TrainSort.FlatAppearance.BorderSize = 0;
            this.btnTrainMenu_TrainSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainMenu_TrainSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTrainMenu_TrainSort.ForeColor = System.Drawing.Color.White;
            this.btnTrainMenu_TrainSort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrainMenu_TrainSort.Location = new System.Drawing.Point(0, 336);
            this.btnTrainMenu_TrainSort.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnTrainMenu_TrainSort.Name = "btnTrainMenu_TrainSort";
            this.btnTrainMenu_TrainSort.Size = new System.Drawing.Size(325, 112);
            this.btnTrainMenu_TrainSort.TabIndex = 4;
            this.btnTrainMenu_TrainSort.Text = "열차 종류";
            this.btnTrainMenu_TrainSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainMenu_TrainSort.UseVisualStyleBackColor = true;
            this.btnTrainMenu_TrainSort.Click += new System.EventHandler(this.btnTrainMenu_TrainSort_Click);
            // 
            // btnTrainMenu_Destination
            // 
            this.btnTrainMenu_Destination.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrainMenu_Destination.FlatAppearance.BorderSize = 0;
            this.btnTrainMenu_Destination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainMenu_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTrainMenu_Destination.ForeColor = System.Drawing.Color.White;
            this.btnTrainMenu_Destination.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrainMenu_Destination.Location = new System.Drawing.Point(0, 224);
            this.btnTrainMenu_Destination.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnTrainMenu_Destination.Name = "btnTrainMenu_Destination";
            this.btnTrainMenu_Destination.Size = new System.Drawing.Size(325, 112);
            this.btnTrainMenu_Destination.TabIndex = 2;
            this.btnTrainMenu_Destination.Text = "  도착지";
            this.btnTrainMenu_Destination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainMenu_Destination.UseVisualStyleBackColor = true;
            this.btnTrainMenu_Destination.Click += new System.EventHandler(this.btnTrainMenu_Destination_Click);
            // 
            // btnTrainMenu_Departure
            // 
            this.btnTrainMenu_Departure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrainMenu_Departure.FlatAppearance.BorderSize = 0;
            this.btnTrainMenu_Departure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainMenu_Departure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTrainMenu_Departure.ForeColor = System.Drawing.Color.White;
            this.btnTrainMenu_Departure.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrainMenu_Departure.Location = new System.Drawing.Point(0, 112);
            this.btnTrainMenu_Departure.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnTrainMenu_Departure.Name = "btnTrainMenu_Departure";
            this.btnTrainMenu_Departure.Size = new System.Drawing.Size(325, 112);
            this.btnTrainMenu_Departure.TabIndex = 1;
            this.btnTrainMenu_Departure.Text = "  출발지";
            this.btnTrainMenu_Departure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainMenu_Departure.UseVisualStyleBackColor = true;
            this.btnTrainMenu_Departure.Click += new System.EventHandler(this.btnPlaneMenu_Departure_Click);
            // 
            // pnlWayToggle
            // 
            this.pnlWayToggle.Controls.Add(this.btnWayToggle_Single);
            this.pnlWayToggle.Controls.Add(this.btnWayToggle_RoundTrip);
            this.pnlWayToggle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWayToggle.Location = new System.Drawing.Point(0, 0);
            this.pnlWayToggle.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pnlWayToggle.Name = "pnlWayToggle";
            this.pnlWayToggle.Size = new System.Drawing.Size(325, 112);
            this.pnlWayToggle.TabIndex = 0;
            // 
            // btnWayToggle_Single
            // 
            this.btnWayToggle_Single.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnWayToggle_Single.FlatAppearance.BorderSize = 0;
            this.btnWayToggle_Single.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWayToggle_Single.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnWayToggle_Single.ForeColor = System.Drawing.Color.White;
            this.btnWayToggle_Single.Location = new System.Drawing.Point(165, 0);
            this.btnWayToggle_Single.Margin = new System.Windows.Forms.Padding(2);
            this.btnWayToggle_Single.Name = "btnWayToggle_Single";
            this.btnWayToggle_Single.Size = new System.Drawing.Size(160, 112);
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
            this.btnWayToggle_RoundTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnWayToggle_RoundTrip.ForeColor = System.Drawing.Color.White;
            this.btnWayToggle_RoundTrip.Location = new System.Drawing.Point(0, 0);
            this.btnWayToggle_RoundTrip.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnWayToggle_RoundTrip.Name = "btnWayToggle_RoundTrip";
            this.btnWayToggle_RoundTrip.Size = new System.Drawing.Size(162, 112);
            this.btnWayToggle_RoundTrip.TabIndex = 0;
            this.btnWayToggle_RoundTrip.Text = "왕복";
            this.btnWayToggle_RoundTrip.UseVisualStyleBackColor = true;
            this.btnWayToggle_RoundTrip.Click += new System.EventHandler(this.btnWayToggle_RoundTrip_Click);
            // 
            // tmrPanelMove
            // 
            this.tmrPanelMove.Enabled = true;
            this.tmrPanelMove.Interval = 15;
            // 
            // flpnlDetail
            // 
            this.flpnlDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpnlDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.flpnlDetail.Controls.Add(this.tPnlCity);
            this.flpnlDetail.Controls.Add(this.tPnlStation);
            this.flpnlDetail.Controls.Add(this.tPnlSort);
            this.flpnlDetail.Controls.Add(this.lblDateToGo);
            this.flpnlDetail.Controls.Add(this.goCalendar);
            this.flpnlDetail.Controls.Add(this.lblDateToCome);
            this.flpnlDetail.Controls.Add(this.comeCalendar);
            this.flpnlDetail.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnlDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.flpnlDetail.ForeColor = System.Drawing.Color.White;
            this.flpnlDetail.Location = new System.Drawing.Point(325, 0);
            this.flpnlDetail.Margin = new System.Windows.Forms.Padding(0);
            this.flpnlDetail.MaximumSize = new System.Drawing.Size(650, 4800);
            this.flpnlDetail.MinimumSize = new System.Drawing.Size(0, 4800);
            this.flpnlDetail.Name = "flpnlDetail";
            this.flpnlDetail.Size = new System.Drawing.Size(650, 4800);
            this.flpnlDetail.TabIndex = 9;
            // 
            // tPnlCity
            // 
            this.tPnlCity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tPnlCity.ColumnCount = 5;
            this.tPnlCity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlCity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlCity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlCity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlCity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlCity.Location = new System.Drawing.Point(3, 3);
            this.tPnlCity.Name = "tPnlCity";
            this.tPnlCity.RowCount = 2;
            this.tPnlCity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tPnlCity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tPnlCity.Size = new System.Drawing.Size(650, 100);
            this.tPnlCity.TabIndex = 0;
            // 
            // tPnlStation
            // 
            this.tPnlStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tPnlStation.ColumnCount = 5;
            this.tPnlStation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlStation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlStation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlStation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlStation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlStation.Location = new System.Drawing.Point(3, 109);
            this.tPnlStation.Name = "tPnlStation";
            this.tPnlStation.RowCount = 2;
            this.tPnlStation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tPnlStation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tPnlStation.Size = new System.Drawing.Size(650, 100);
            this.tPnlStation.TabIndex = 10;
            // 
            // tPnlSort
            // 
            this.tPnlSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tPnlSort.ColumnCount = 3;
            this.tPnlSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPnlSort.Location = new System.Drawing.Point(3, 215);
            this.tPnlSort.Name = "tPnlSort";
            this.tPnlSort.RowCount = 2;
            this.tPnlSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tPnlSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tPnlSort.Size = new System.Drawing.Size(650, 100);
            this.tPnlSort.TabIndex = 11;
            // 
            // lblDateToGo
            // 
            this.lblDateToGo.AutoSize = true;
            this.lblDateToGo.Location = new System.Drawing.Point(3, 318);
            this.lblDateToGo.Name = "lblDateToGo";
            this.lblDateToGo.Size = new System.Drawing.Size(95, 39);
            this.lblDateToGo.TabIndex = 13;
            this.lblDateToGo.Text = "가는날";
            // 
            // goCalendar
            // 
            this.goCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goCalendar.Location = new System.Drawing.Point(137, 366);
            this.goCalendar.Name = "goCalendar";
            this.goCalendar.TabIndex = 12;
            this.goCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.goCalendar_DateChanged);
            // 
            // lblDateToCome
            // 
            this.lblDateToCome.AutoSize = true;
            this.lblDateToCome.Location = new System.Drawing.Point(3, 690);
            this.lblDateToCome.Name = "lblDateToCome";
            this.lblDateToCome.Size = new System.Drawing.Size(105, 39);
            this.lblDateToCome.TabIndex = 14;
            this.lblDateToCome.Text = "오는 날";
            // 
            // comeCalendar
            // 
            this.comeCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comeCalendar.Location = new System.Drawing.Point(137, 738);
            this.comeCalendar.Name = "comeCalendar";
            this.comeCalendar.TabIndex = 15;
            this.comeCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.comeCalendar_DateChanged);
            // 
            // listResultToGo
            // 
            this.listResultToGo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTrainSort,
            this.colDepTime,
            this.colArrTime,
            this.colDep,
            this.colArr,
            this.colPrice});
            this.listResultToGo.FullRowSelect = true;
            this.listResultToGo.GridLines = true;
            this.listResultToGo.HideSelection = false;
            this.listResultToGo.Location = new System.Drawing.Point(3, 42);
            this.listResultToGo.Name = "listResultToGo";
            this.listResultToGo.Size = new System.Drawing.Size(1241, 557);
            this.listResultToGo.TabIndex = 10;
            this.listResultToGo.UseCompatibleStateImageBehavior = false;
            this.listResultToGo.View = System.Windows.Forms.View.Details;
            // 
            // colTrainSort
            // 
            this.colTrainSort.Text = "기차종류";
            this.colTrainSort.Width = 100;
            // 
            // colDepTime
            // 
            this.colDepTime.Text = "출발시간";
            this.colDepTime.Width = 134;
            // 
            // colArrTime
            // 
            this.colArrTime.Text = "도착시간";
            this.colArrTime.Width = 155;
            // 
            // colDep
            // 
            this.colDep.Text = "출발지";
            this.colDep.Width = 100;
            // 
            // colArr
            // 
            this.colArr.Text = "도착지";
            this.colArr.Width = 101;
            // 
            // colPrice
            // 
            this.colPrice.Text = "운임요금";
            this.colPrice.Width = 126;
            // 
            // flpnlResult
            // 
            this.flpnlResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpnlResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.flpnlResult.Controls.Add(this.lblResultToGo);
            this.flpnlResult.Controls.Add(this.listResultToGo);
            this.flpnlResult.Controls.Add(this.lblResultToCome);
            this.flpnlResult.Controls.Add(this.listResultToCome);
            this.flpnlResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpnlResult.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.flpnlResult.ForeColor = System.Drawing.Color.White;
            this.flpnlResult.Location = new System.Drawing.Point(325, 0);
            this.flpnlResult.Margin = new System.Windows.Forms.Padding(0);
            this.flpnlResult.MaximumSize = new System.Drawing.Size(1500, 4800);
            this.flpnlResult.MinimumSize = new System.Drawing.Size(0, 4800);
            this.flpnlResult.Name = "flpnlResult";
            this.flpnlResult.Size = new System.Drawing.Size(1367, 4800);
            this.flpnlResult.TabIndex = 11;
            // 
            // lblResultToGo
            // 
            this.lblResultToGo.AutoSize = true;
            this.lblResultToGo.Location = new System.Drawing.Point(3, 0);
            this.lblResultToGo.Name = "lblResultToGo";
            this.lblResultToGo.Size = new System.Drawing.Size(157, 39);
            this.lblResultToGo.TabIndex = 0;
            this.lblResultToGo.Text = "가는편 열차";
            // 
            // lblResultToCome
            // 
            this.lblResultToCome.AutoSize = true;
            this.lblResultToCome.Location = new System.Drawing.Point(3, 602);
            this.lblResultToCome.Name = "lblResultToCome";
            this.lblResultToCome.Size = new System.Drawing.Size(157, 39);
            this.lblResultToCome.TabIndex = 11;
            this.lblResultToCome.Text = "오는편 열차";
            // 
            // listResultToCome
            // 
            this.listResultToCome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listResultToCome.FullRowSelect = true;
            this.listResultToCome.GridLines = true;
            this.listResultToCome.HideSelection = false;
            this.listResultToCome.Location = new System.Drawing.Point(3, 644);
            this.listResultToCome.Name = "listResultToCome";
            this.listResultToCome.Size = new System.Drawing.Size(1241, 557);
            this.listResultToCome.TabIndex = 12;
            this.listResultToCome.UseCompatibleStateImageBehavior = false;
            this.listResultToCome.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "기차종류";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "출발시간";
            this.columnHeader2.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "도착시간";
            this.columnHeader3.Width = 155;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "출발지";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "도착지";
            this.columnHeader5.Width = 101;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "운임요금";
            this.columnHeader6.Width = 126;
            // 
            // FormTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1729, 852);
            this.Controls.Add(this.flpnlResult);
            this.Controls.Add(this.flpnlDetail);
            this.Controls.Add(this.pnlPlaneMenu);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FormTrain";
            this.Text = "열차/지하철";
            this.Load += new System.EventHandler(this.FormTrain_Load);
            this.pnlPlaneMenu.ResumeLayout(false);
            this.pnlWayToggle.ResumeLayout(false);
            this.flpnlDetail.ResumeLayout(false);
            this.flpnlDetail.PerformLayout();
            this.flpnlResult.ResumeLayout(false);
            this.flpnlResult.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel pnlPlaneMenu;
        private System.Windows.Forms.Button btnTrainMenu_TrainSort;
        private System.Windows.Forms.Button btnTrainMenu_Destination;
        private System.Windows.Forms.Button btnTrainMenu_Departure;
        private System.Windows.Forms.Panel pnlWayToggle;
        private System.Windows.Forms.Button btnWayToggle_Single;
        private System.Windows.Forms.Button btnWayToggle_RoundTrip;
        private System.Windows.Forms.Timer tmrPanelMove;
        private System.Windows.Forms.FlowLayoutPanel flpnlDetail;
        private System.Windows.Forms.TableLayoutPanel tPnlCity;
        private System.Windows.Forms.TableLayoutPanel tPnlStation;
        private System.Windows.Forms.TableLayoutPanel tPnlSort;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDateToGo;
        private System.Windows.Forms.MonthCalendar goCalendar;
        private System.Windows.Forms.Label lblDateToCome;
        private System.Windows.Forms.MonthCalendar comeCalendar;
        private System.Windows.Forms.ListView listResultToGo;
        private System.Windows.Forms.ColumnHeader colTrainSort;
        private System.Windows.Forms.ColumnHeader colDepTime;
        private System.Windows.Forms.ColumnHeader colArrTime;
        private System.Windows.Forms.ColumnHeader colDep;
        private System.Windows.Forms.ColumnHeader colArr;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.FlowLayoutPanel flpnlResult;
        private System.Windows.Forms.Label lblResultToGo;
        private System.Windows.Forms.Label lblResultToCome;
        private System.Windows.Forms.ListView listResultToCome;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
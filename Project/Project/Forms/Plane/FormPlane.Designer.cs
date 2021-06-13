namespace Project.Forms.Plane {
	partial class FormPlane {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlane));
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnOptions_Airline = new System.Windows.Forms.Button();
            this.btnOptions_SeatClass = new System.Windows.Forms.Button();
            this.btnOptions_Date = new System.Windows.Forms.Button();
            this.btnOptions_Arrival = new System.Windows.Forms.Button();
            this.btnOptions_Departure = new System.Windows.Forms.Button();
            this.pnlCourse = new System.Windows.Forms.Panel();
            this.btnCourse_Single = new System.Windows.Forms.Button();
            this.btnCourse_RoundTrip = new System.Windows.Forms.Button();
            this.tmrDetailsPanel_Move = new System.Windows.Forms.Timer(this.components);
            this.tmrAirportsPanel_Move = new System.Windows.Forms.Timer(this.components);
            this.imgArrow = new System.Windows.Forms.ImageList(this.components);
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.pnlDetail_Airlines = new System.Windows.Forms.Panel();
            this.tpnlAirlines = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDetail_SeatClass = new System.Windows.Forms.Panel();
            this.btnDetail_SeatClass_Business = new System.Windows.Forms.Button();
            this.btnDetail_SeatClass_Economy = new System.Windows.Forms.Button();
            this.pnlDetail_Date = new System.Windows.Forms.Panel();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpLeaveDate = new System.Windows.Forms.DateTimePicker();
            this.lblDetail_Date_Return = new System.Windows.Forms.Label();
            this.lblDetail_Date_Leave = new System.Windows.Forms.Label();
            this.pnlDetail_Arrival = new System.Windows.Forms.Panel();
            this.pnlArrAirports = new System.Windows.Forms.Panel();
            this.tpnlArrAirports = new System.Windows.Forms.TableLayoutPanel();
            this.pnlArr_Input = new System.Windows.Forms.Panel();
            this.btnShowArrAirports = new System.Windows.Forms.Button();
            this.lblDetail_Arrival_Name = new System.Windows.Forms.Label();
            this.txtArrAirport_Name = new System.Windows.Forms.TextBox();
            this.pnlDetail_Departure = new System.Windows.Forms.Panel();
            this.pnlDepAirports = new System.Windows.Forms.Panel();
            this.tpnlDepAirports = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDep_Input = new System.Windows.Forms.Panel();
            this.btnShowDepAirports = new System.Windows.Forms.Button();
            this.lblDetail_Departure_Name = new System.Windows.Forms.Label();
            this.txtDepAirport_Name = new System.Windows.Forms.TextBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.tpnlResults = new System.Windows.Forms.TableLayoutPanel();
            this.lvwLeaveFlights = new System.Windows.Forms.ListView();
            this.l_depTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.l_arrTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.l_airline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.l_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwReturnFlights = new System.Windows.Forms.ListView();
            this.r_depTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_arrTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_airline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlLeaveStatus = new System.Windows.Forms.Panel();
            this.btnLeaveInfo = new System.Windows.Forms.Button();
            this.pnlReturnStatus = new System.Windows.Forms.Panel();
            this.btnReturnInfo = new System.Windows.Forms.Button();
            this.btnLeaveTotal = new System.Windows.Forms.Button();
            this.btnReturnTotal = new System.Windows.Forms.Button();
            this.imgAirlineLogo = new System.Windows.Forms.ImageList(this.components);
            this.pnlOptions.SuspendLayout();
            this.pnlCourse.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlDetail_Airlines.SuspendLayout();
            this.pnlDetail_SeatClass.SuspendLayout();
            this.pnlDetail_Date.SuspendLayout();
            this.pnlDetail_Arrival.SuspendLayout();
            this.pnlArrAirports.SuspendLayout();
            this.pnlArr_Input.SuspendLayout();
            this.pnlDetail_Departure.SuspendLayout();
            this.pnlDepAirports.SuspendLayout();
            this.pnlDep_Input.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.tpnlResults.SuspendLayout();
            this.pnlLeaveStatus.SuspendLayout();
            this.pnlReturnStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.pnlOptions.Controls.Add(this.btnOptions_Airline);
            this.pnlOptions.Controls.Add(this.btnOptions_SeatClass);
            this.pnlOptions.Controls.Add(this.btnOptions_Date);
            this.pnlOptions.Controls.Add(this.btnOptions_Arrival);
            this.pnlOptions.Controls.Add(this.btnOptions_Departure);
            this.pnlOptions.Controls.Add(this.pnlCourse);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOptions.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.pnlOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(325, 1120);
            this.pnlOptions.TabIndex = 2;
            // 
            // btnOptions_Airline
            // 
            this.btnOptions_Airline.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions_Airline.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptions_Airline.FlatAppearance.BorderSize = 0;
            this.btnOptions_Airline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions_Airline.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnOptions_Airline.ForeColor = System.Drawing.Color.White;
            this.btnOptions_Airline.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOptions_Airline.Location = new System.Drawing.Point(0, 560);
            this.btnOptions_Airline.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOptions_Airline.Name = "btnOptions_Airline";
            this.btnOptions_Airline.Size = new System.Drawing.Size(325, 112);
            this.btnOptions_Airline.TabIndex = 5;
            this.btnOptions_Airline.Text = "  항공사";
            this.btnOptions_Airline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions_Airline.UseVisualStyleBackColor = false;
            this.btnOptions_Airline.Click += new System.EventHandler(this.btnOptions_Airline_Click);
            // 
            // btnOptions_SeatClass
            // 
            this.btnOptions_SeatClass.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions_SeatClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptions_SeatClass.FlatAppearance.BorderSize = 0;
            this.btnOptions_SeatClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions_SeatClass.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnOptions_SeatClass.ForeColor = System.Drawing.Color.White;
            this.btnOptions_SeatClass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOptions_SeatClass.Location = new System.Drawing.Point(0, 448);
            this.btnOptions_SeatClass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOptions_SeatClass.Name = "btnOptions_SeatClass";
            this.btnOptions_SeatClass.Size = new System.Drawing.Size(325, 112);
            this.btnOptions_SeatClass.TabIndex = 4;
            this.btnOptions_SeatClass.Text = "  좌석 등급";
            this.btnOptions_SeatClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions_SeatClass.UseVisualStyleBackColor = false;
            this.btnOptions_SeatClass.Click += new System.EventHandler(this.btnOptions_SeatClass_Click);
            // 
            // btnOptions_Date
            // 
            this.btnOptions_Date.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions_Date.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptions_Date.FlatAppearance.BorderSize = 0;
            this.btnOptions_Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions_Date.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnOptions_Date.ForeColor = System.Drawing.Color.White;
            this.btnOptions_Date.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOptions_Date.Location = new System.Drawing.Point(0, 336);
            this.btnOptions_Date.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOptions_Date.Name = "btnOptions_Date";
            this.btnOptions_Date.Size = new System.Drawing.Size(325, 112);
            this.btnOptions_Date.TabIndex = 3;
            this.btnOptions_Date.Text = "  날짜";
            this.btnOptions_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions_Date.UseVisualStyleBackColor = false;
            this.btnOptions_Date.Click += new System.EventHandler(this.btnOptions_Date_Click);
            // 
            // btnOptions_Arrival
            // 
            this.btnOptions_Arrival.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions_Arrival.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptions_Arrival.FlatAppearance.BorderSize = 0;
            this.btnOptions_Arrival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions_Arrival.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnOptions_Arrival.ForeColor = System.Drawing.Color.White;
            this.btnOptions_Arrival.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOptions_Arrival.Location = new System.Drawing.Point(0, 224);
            this.btnOptions_Arrival.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOptions_Arrival.Name = "btnOptions_Arrival";
            this.btnOptions_Arrival.Size = new System.Drawing.Size(325, 112);
            this.btnOptions_Arrival.TabIndex = 2;
            this.btnOptions_Arrival.Text = "  도착지";
            this.btnOptions_Arrival.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions_Arrival.UseVisualStyleBackColor = false;
            this.btnOptions_Arrival.Click += new System.EventHandler(this.btnOptions_Arrival_Click);
            // 
            // btnOptions_Departure
            // 
            this.btnOptions_Departure.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions_Departure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptions_Departure.FlatAppearance.BorderSize = 0;
            this.btnOptions_Departure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions_Departure.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnOptions_Departure.ForeColor = System.Drawing.Color.White;
            this.btnOptions_Departure.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOptions_Departure.Location = new System.Drawing.Point(0, 112);
            this.btnOptions_Departure.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOptions_Departure.Name = "btnOptions_Departure";
            this.btnOptions_Departure.Size = new System.Drawing.Size(325, 112);
            this.btnOptions_Departure.TabIndex = 1;
            this.btnOptions_Departure.Text = "  출발지";
            this.btnOptions_Departure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions_Departure.UseVisualStyleBackColor = false;
            this.btnOptions_Departure.Click += new System.EventHandler(this.btnOptions_Departure_Click);
            // 
            // pnlCourse
            // 
            this.pnlCourse.BackColor = System.Drawing.Color.Transparent;
            this.pnlCourse.Controls.Add(this.btnCourse_Single);
            this.pnlCourse.Controls.Add(this.btnCourse_RoundTrip);
            this.pnlCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCourse.Location = new System.Drawing.Point(0, 0);
            this.pnlCourse.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlCourse.Name = "pnlCourse";
            this.pnlCourse.Size = new System.Drawing.Size(325, 112);
            this.pnlCourse.TabIndex = 0;
            // 
            // btnCourse_Single
            // 
            this.btnCourse_Single.BackColor = System.Drawing.Color.Transparent;
            this.btnCourse_Single.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCourse_Single.FlatAppearance.BorderSize = 0;
            this.btnCourse_Single.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse_Single.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnCourse_Single.ForeColor = System.Drawing.Color.White;
            this.btnCourse_Single.Location = new System.Drawing.Point(163, 0);
            this.btnCourse_Single.Margin = new System.Windows.Forms.Padding(0);
            this.btnCourse_Single.Name = "btnCourse_Single";
            this.btnCourse_Single.Size = new System.Drawing.Size(162, 112);
            this.btnCourse_Single.TabIndex = 1;
            this.btnCourse_Single.Text = "편도";
            this.btnCourse_Single.UseVisualStyleBackColor = false;
            this.btnCourse_Single.Click += new System.EventHandler(this.btnCourseName_Click);
            // 
            // btnCourse_RoundTrip
            // 
            this.btnCourse_RoundTrip.BackColor = System.Drawing.Color.Transparent;
            this.btnCourse_RoundTrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCourse_RoundTrip.FlatAppearance.BorderSize = 0;
            this.btnCourse_RoundTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse_RoundTrip.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnCourse_RoundTrip.ForeColor = System.Drawing.Color.White;
            this.btnCourse_RoundTrip.Location = new System.Drawing.Point(0, 0);
            this.btnCourse_RoundTrip.Margin = new System.Windows.Forms.Padding(0);
            this.btnCourse_RoundTrip.Name = "btnCourse_RoundTrip";
            this.btnCourse_RoundTrip.Size = new System.Drawing.Size(162, 112);
            this.btnCourse_RoundTrip.TabIndex = 0;
            this.btnCourse_RoundTrip.Text = "왕복";
            this.btnCourse_RoundTrip.UseVisualStyleBackColor = false;
            this.btnCourse_RoundTrip.Click += new System.EventHandler(this.btnCourseName_Click);
            // 
            // tmrDetailsPanel_Move
            // 
            this.tmrDetailsPanel_Move.Interval = 10;
            this.tmrDetailsPanel_Move.Tick += new System.EventHandler(this.tmrDetailsPanel_Move_Tick);
            // 
            // tmrAirportsPanel_Move
            // 
            this.tmrAirportsPanel_Move.Interval = 10;
            this.tmrAirportsPanel_Move.Tick += new System.EventHandler(this.tmrAirportsPanel_Move_Tick);
            // 
            // imgArrow
            // 
            this.imgArrow.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgArrow.ImageStream")));
            this.imgArrow.TransparentColor = System.Drawing.Color.Transparent;
            this.imgArrow.Images.SetKeyName(0, "downarrow.png");
            this.imgArrow.Images.SetKeyName(1, "uparrow.png");
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.pnlDetails.Controls.Add(this.pnlDetail_Airlines);
            this.pnlDetails.Controls.Add(this.pnlDetail_SeatClass);
            this.pnlDetails.Controls.Add(this.pnlDetail_Date);
            this.pnlDetails.Controls.Add(this.pnlDetail_Arrival);
            this.pnlDetails.Controls.Add(this.pnlDetail_Departure);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDetails.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.pnlDetails.ForeColor = System.Drawing.Color.White;
            this.pnlDetails.Location = new System.Drawing.Point(325, 0);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetails.MaximumSize = new System.Drawing.Size(650, 4800);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(0, 1120);
            this.pnlDetails.TabIndex = 4;
            // 
            // pnlDetail_Airlines
            // 
            this.pnlDetail_Airlines.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDetail_Airlines.Controls.Add(this.tpnlAirlines);
            this.pnlDetail_Airlines.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetail_Airlines.Location = new System.Drawing.Point(0, 858);
            this.pnlDetail_Airlines.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetail_Airlines.MaximumSize = new System.Drawing.Size(650, 3200);
            this.pnlDetail_Airlines.MinimumSize = new System.Drawing.Size(650, 0);
            this.pnlDetail_Airlines.Name = "pnlDetail_Airlines";
            this.pnlDetail_Airlines.Size = new System.Drawing.Size(650, 80);
            this.pnlDetail_Airlines.TabIndex = 5;
            // 
            // tpnlAirlines
            // 
            this.tpnlAirlines.AutoSize = true;
            this.tpnlAirlines.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tpnlAirlines.BackColor = System.Drawing.Color.Transparent;
            this.tpnlAirlines.ColumnCount = 1;
            this.tpnlAirlines.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlAirlines.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 15F);
            this.tpnlAirlines.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tpnlAirlines.Location = new System.Drawing.Point(0, 0);
            this.tpnlAirlines.Margin = new System.Windows.Forms.Padding(0);
            this.tpnlAirlines.Name = "tpnlAirlines";
            this.tpnlAirlines.RowCount = 1;
            this.tpnlAirlines.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlAirlines.Size = new System.Drawing.Size(0, 0);
            this.tpnlAirlines.TabIndex = 0;
            // 
            // pnlDetail_SeatClass
            // 
            this.pnlDetail_SeatClass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDetail_SeatClass.BackColor = System.Drawing.Color.Transparent;
            this.pnlDetail_SeatClass.Controls.Add(this.btnDetail_SeatClass_Business);
            this.pnlDetail_SeatClass.Controls.Add(this.btnDetail_SeatClass_Economy);
            this.pnlDetail_SeatClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetail_SeatClass.Location = new System.Drawing.Point(0, 746);
            this.pnlDetail_SeatClass.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetail_SeatClass.MaximumSize = new System.Drawing.Size(650, 112);
            this.pnlDetail_SeatClass.MinimumSize = new System.Drawing.Size(650, 0);
            this.pnlDetail_SeatClass.Name = "pnlDetail_SeatClass";
            this.pnlDetail_SeatClass.Size = new System.Drawing.Size(650, 112);
            this.pnlDetail_SeatClass.TabIndex = 4;
            // 
            // btnDetail_SeatClass_Business
            // 
            this.btnDetail_SeatClass_Business.BackColor = System.Drawing.Color.Transparent;
            this.btnDetail_SeatClass_Business.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDetail_SeatClass_Business.FlatAppearance.BorderSize = 0;
            this.btnDetail_SeatClass_Business.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail_SeatClass_Business.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnDetail_SeatClass_Business.Location = new System.Drawing.Point(325, 0);
            this.btnDetail_SeatClass_Business.Margin = new System.Windows.Forms.Padding(0);
            this.btnDetail_SeatClass_Business.Name = "btnDetail_SeatClass_Business";
            this.btnDetail_SeatClass_Business.Size = new System.Drawing.Size(325, 112);
            this.btnDetail_SeatClass_Business.TabIndex = 1;
            this.btnDetail_SeatClass_Business.Text = "비즈니스";
            this.btnDetail_SeatClass_Business.UseVisualStyleBackColor = false;
            this.btnDetail_SeatClass_Business.Click += new System.EventHandler(this.btnSeatClassName_Click);
            // 
            // btnDetail_SeatClass_Economy
            // 
            this.btnDetail_SeatClass_Economy.BackColor = System.Drawing.Color.Transparent;
            this.btnDetail_SeatClass_Economy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDetail_SeatClass_Economy.FlatAppearance.BorderSize = 0;
            this.btnDetail_SeatClass_Economy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail_SeatClass_Economy.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnDetail_SeatClass_Economy.Location = new System.Drawing.Point(0, 0);
            this.btnDetail_SeatClass_Economy.Margin = new System.Windows.Forms.Padding(0);
            this.btnDetail_SeatClass_Economy.Name = "btnDetail_SeatClass_Economy";
            this.btnDetail_SeatClass_Economy.Size = new System.Drawing.Size(325, 112);
            this.btnDetail_SeatClass_Economy.TabIndex = 0;
            this.btnDetail_SeatClass_Economy.Text = "이코노미";
            this.btnDetail_SeatClass_Economy.UseVisualStyleBackColor = false;
            this.btnDetail_SeatClass_Economy.Click += new System.EventHandler(this.btnSeatClassName_Click);
            // 
            // pnlDetail_Date
            // 
            this.pnlDetail_Date.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDetail_Date.Controls.Add(this.dtpReturnDate);
            this.pnlDetail_Date.Controls.Add(this.dtpLeaveDate);
            this.pnlDetail_Date.Controls.Add(this.lblDetail_Date_Return);
            this.pnlDetail_Date.Controls.Add(this.lblDetail_Date_Leave);
            this.pnlDetail_Date.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetail_Date.Location = new System.Drawing.Point(0, 522);
            this.pnlDetail_Date.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetail_Date.MaximumSize = new System.Drawing.Size(650, 224);
            this.pnlDetail_Date.MinimumSize = new System.Drawing.Size(650, 0);
            this.pnlDetail_Date.Name = "pnlDetail_Date";
            this.pnlDetail_Date.Size = new System.Drawing.Size(650, 224);
            this.pnlDetail_Date.TabIndex = 3;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 17F);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(224, 136);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(388, 59);
            this.dtpReturnDate.TabIndex = 11;
            // 
            // dtpLeaveDate
            // 
            this.dtpLeaveDate.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 17F);
            this.dtpLeaveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLeaveDate.Location = new System.Drawing.Point(224, 32);
            this.dtpLeaveDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpLeaveDate.Name = "dtpLeaveDate";
            this.dtpLeaveDate.Size = new System.Drawing.Size(388, 59);
            this.dtpLeaveDate.TabIndex = 10;
            // 
            // lblDetail_Date_Return
            // 
            this.lblDetail_Date_Return.AutoSize = true;
            this.lblDetail_Date_Return.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.lblDetail_Date_Return.Location = new System.Drawing.Point(34, 144);
            this.lblDetail_Date_Return.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDetail_Date_Return.Name = "lblDetail_Date_Return";
            this.lblDetail_Date_Return.Size = new System.Drawing.Size(150, 39);
            this.lblDetail_Date_Return.TabIndex = 9;
            this.lblDetail_Date_Return.Text = "오는 날    :";
            // 
            // lblDetail_Date_Leave
            // 
            this.lblDetail_Date_Leave.AutoSize = true;
            this.lblDetail_Date_Leave.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.lblDetail_Date_Leave.Location = new System.Drawing.Point(34, 40);
            this.lblDetail_Date_Leave.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDetail_Date_Leave.Name = "lblDetail_Date_Leave";
            this.lblDetail_Date_Leave.Size = new System.Drawing.Size(150, 39);
            this.lblDetail_Date_Leave.TabIndex = 8;
            this.lblDetail_Date_Leave.Text = "가는 날    :";
            // 
            // pnlDetail_Arrival
            // 
            this.pnlDetail_Arrival.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDetail_Arrival.Controls.Add(this.pnlArrAirports);
            this.pnlDetail_Arrival.Controls.Add(this.pnlArr_Input);
            this.pnlDetail_Arrival.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetail_Arrival.Location = new System.Drawing.Point(0, 261);
            this.pnlDetail_Arrival.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetail_Arrival.MaximumSize = new System.Drawing.Size(650, 560);
            this.pnlDetail_Arrival.MinimumSize = new System.Drawing.Size(650, 0);
            this.pnlDetail_Arrival.Name = "pnlDetail_Arrival";
            this.pnlDetail_Arrival.Size = new System.Drawing.Size(650, 261);
            this.pnlDetail_Arrival.TabIndex = 2;
            // 
            // pnlArrAirports
            // 
            this.pnlArrAirports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlArrAirports.Controls.Add(this.tpnlArrAirports);
            this.pnlArrAirports.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArrAirports.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 12F);
            this.pnlArrAirports.Location = new System.Drawing.Point(0, 181);
            this.pnlArrAirports.Margin = new System.Windows.Forms.Padding(0);
            this.pnlArrAirports.MaximumSize = new System.Drawing.Size(650, 480);
            this.pnlArrAirports.MinimumSize = new System.Drawing.Size(650, 0);
            this.pnlArrAirports.Name = "pnlArrAirports";
            this.pnlArrAirports.Size = new System.Drawing.Size(650, 0);
            this.pnlArrAirports.TabIndex = 8;
            // 
            // tpnlArrAirports
            // 
            this.tpnlArrAirports.AutoSize = true;
            this.tpnlArrAirports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tpnlArrAirports.BackColor = System.Drawing.Color.Transparent;
            this.tpnlArrAirports.ColumnCount = 1;
            this.tpnlArrAirports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlArrAirports.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tpnlArrAirports.Location = new System.Drawing.Point(0, 0);
            this.tpnlArrAirports.Margin = new System.Windows.Forms.Padding(0);
            this.tpnlArrAirports.Name = "tpnlArrAirports";
            this.tpnlArrAirports.RowCount = 1;
            this.tpnlArrAirports.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlArrAirports.Size = new System.Drawing.Size(0, 0);
            this.tpnlArrAirports.TabIndex = 0;
            // 
            // pnlArr_Input
            // 
            this.pnlArr_Input.Controls.Add(this.btnShowArrAirports);
            this.pnlArr_Input.Controls.Add(this.lblDetail_Arrival_Name);
            this.pnlArr_Input.Controls.Add(this.txtArrAirport_Name);
            this.pnlArr_Input.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArr_Input.Location = new System.Drawing.Point(0, 0);
            this.pnlArr_Input.Margin = new System.Windows.Forms.Padding(0);
            this.pnlArr_Input.Name = "pnlArr_Input";
            this.pnlArr_Input.Size = new System.Drawing.Size(650, 181);
            this.pnlArr_Input.TabIndex = 7;
            // 
            // btnShowArrAirports
            // 
            this.btnShowArrAirports.BackColor = System.Drawing.Color.Transparent;
            this.btnShowArrAirports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.btnShowArrAirports.FlatAppearance.BorderSize = 0;
            this.btnShowArrAirports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowArrAirports.Location = new System.Drawing.Point(0, 112);
            this.btnShowArrAirports.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowArrAirports.Name = "btnShowArrAirports";
            this.btnShowArrAirports.Size = new System.Drawing.Size(650, 64);
            this.btnShowArrAirports.TabIndex = 9;
            this.btnShowArrAirports.UseVisualStyleBackColor = false;
            this.btnShowArrAirports.Click += new System.EventHandler(this.btnShowAirports_Click);
            // 
            // lblDetail_Arrival_Name
            // 
            this.lblDetail_Arrival_Name.AutoSize = true;
            this.lblDetail_Arrival_Name.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.lblDetail_Arrival_Name.Location = new System.Drawing.Point(34, 38);
            this.lblDetail_Arrival_Name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDetail_Arrival_Name.Name = "lblDetail_Arrival_Name";
            this.lblDetail_Arrival_Name.Size = new System.Drawing.Size(158, 39);
            this.lblDetail_Arrival_Name.TabIndex = 8;
            this.lblDetail_Arrival_Name.Text = "도착 공항  :";
            // 
            // txtArrAirport_Name
            // 
            this.txtArrAirport_Name.BackColor = System.Drawing.Color.White;
            this.txtArrAirport_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArrAirport_Name.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 17F);
            this.txtArrAirport_Name.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtArrAirport_Name.Location = new System.Drawing.Point(260, 27);
            this.txtArrAirport_Name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtArrAirport_Name.Name = "txtArrAirport_Name";
            this.txtArrAirport_Name.Size = new System.Drawing.Size(353, 59);
            this.txtArrAirport_Name.TabIndex = 7;
            this.txtArrAirport_Name.Text = "제주";
            this.txtArrAirport_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlDetail_Departure
            // 
            this.pnlDetail_Departure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDetail_Departure.Controls.Add(this.pnlDepAirports);
            this.pnlDetail_Departure.Controls.Add(this.pnlDep_Input);
            this.pnlDetail_Departure.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetail_Departure.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.pnlDetail_Departure.Location = new System.Drawing.Point(0, 0);
            this.pnlDetail_Departure.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetail_Departure.MaximumSize = new System.Drawing.Size(650, 560);
            this.pnlDetail_Departure.MinimumSize = new System.Drawing.Size(650, 0);
            this.pnlDetail_Departure.Name = "pnlDetail_Departure";
            this.pnlDetail_Departure.Size = new System.Drawing.Size(650, 261);
            this.pnlDetail_Departure.TabIndex = 1;
            // 
            // pnlDepAirports
            // 
            this.pnlDepAirports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDepAirports.Controls.Add(this.tpnlDepAirports);
            this.pnlDepAirports.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDepAirports.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 12F);
            this.pnlDepAirports.Location = new System.Drawing.Point(0, 181);
            this.pnlDepAirports.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDepAirports.MaximumSize = new System.Drawing.Size(650, 480);
            this.pnlDepAirports.MinimumSize = new System.Drawing.Size(650, 0);
            this.pnlDepAirports.Name = "pnlDepAirports";
            this.pnlDepAirports.Size = new System.Drawing.Size(650, 0);
            this.pnlDepAirports.TabIndex = 4;
            // 
            // tpnlDepAirports
            // 
            this.tpnlDepAirports.AutoSize = true;
            this.tpnlDepAirports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tpnlDepAirports.BackColor = System.Drawing.Color.Transparent;
            this.tpnlDepAirports.ColumnCount = 1;
            this.tpnlDepAirports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpnlDepAirports.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tpnlDepAirports.Location = new System.Drawing.Point(0, 0);
            this.tpnlDepAirports.Margin = new System.Windows.Forms.Padding(0);
            this.tpnlDepAirports.Name = "tpnlDepAirports";
            this.tpnlDepAirports.RowCount = 1;
            this.tpnlDepAirports.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlDepAirports.Size = new System.Drawing.Size(0, 0);
            this.tpnlDepAirports.TabIndex = 0;
            // 
            // pnlDep_Input
            // 
            this.pnlDep_Input.Controls.Add(this.btnShowDepAirports);
            this.pnlDep_Input.Controls.Add(this.lblDetail_Departure_Name);
            this.pnlDep_Input.Controls.Add(this.txtDepAirport_Name);
            this.pnlDep_Input.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDep_Input.Location = new System.Drawing.Point(0, 0);
            this.pnlDep_Input.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDep_Input.Name = "pnlDep_Input";
            this.pnlDep_Input.Size = new System.Drawing.Size(650, 181);
            this.pnlDep_Input.TabIndex = 3;
            // 
            // btnShowDepAirports
            // 
            this.btnShowDepAirports.BackColor = System.Drawing.Color.Transparent;
            this.btnShowDepAirports.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShowDepAirports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.btnShowDepAirports.FlatAppearance.BorderSize = 0;
            this.btnShowDepAirports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDepAirports.Location = new System.Drawing.Point(0, 117);
            this.btnShowDepAirports.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowDepAirports.Name = "btnShowDepAirports";
            this.btnShowDepAirports.Size = new System.Drawing.Size(650, 64);
            this.btnShowDepAirports.TabIndex = 5;
            this.btnShowDepAirports.UseVisualStyleBackColor = false;
            this.btnShowDepAirports.Click += new System.EventHandler(this.btnShowAirports_Click);
            // 
            // lblDetail_Departure_Name
            // 
            this.lblDetail_Departure_Name.AutoSize = true;
            this.lblDetail_Departure_Name.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.lblDetail_Departure_Name.Location = new System.Drawing.Point(32, 32);
            this.lblDetail_Departure_Name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDetail_Departure_Name.Name = "lblDetail_Departure_Name";
            this.lblDetail_Departure_Name.Size = new System.Drawing.Size(158, 39);
            this.lblDetail_Departure_Name.TabIndex = 3;
            this.lblDetail_Departure_Name.Text = "출발 공항  :";
            // 
            // txtDepAirport_Name
            // 
            this.txtDepAirport_Name.BackColor = System.Drawing.Color.White;
            this.txtDepAirport_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepAirport_Name.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 17F);
            this.txtDepAirport_Name.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDepAirport_Name.Location = new System.Drawing.Point(258, 22);
            this.txtDepAirport_Name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDepAirport_Name.Multiline = true;
            this.txtDepAirport_Name.Name = "txtDepAirport_Name";
            this.txtDepAirport_Name.Size = new System.Drawing.Size(353, 58);
            this.txtDepAirport_Name.TabIndex = 2;
            this.txtDepAirport_Name.Text = "김포";
            this.txtDepAirport_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.AutoSize = true;
            this.pnlBody.Controls.Add(this.tpnlResults);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(325, 0);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1199, 1120);
            this.pnlBody.TabIndex = 5;
            // 
            // tpnlResults
            // 
            this.tpnlResults.AutoSize = true;
            this.tpnlResults.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tpnlResults.ColumnCount = 2;
            this.tpnlResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlResults.Controls.Add(this.lvwLeaveFlights, 0, 1);
            this.tpnlResults.Controls.Add(this.lvwReturnFlights, 1, 1);
            this.tpnlResults.Controls.Add(this.pnlLeaveStatus, 0, 0);
            this.tpnlResults.Controls.Add(this.pnlReturnStatus, 1, 0);
            this.tpnlResults.Controls.Add(this.btnLeaveTotal, 0, 2);
            this.tpnlResults.Controls.Add(this.btnReturnTotal, 1, 2);
            this.tpnlResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlResults.Location = new System.Drawing.Point(0, 0);
            this.tpnlResults.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpnlResults.Name = "tpnlResults";
            this.tpnlResults.RowCount = 3;
            this.tpnlResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpnlResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tpnlResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpnlResults.Size = new System.Drawing.Size(1199, 1120);
            this.tpnlResults.TabIndex = 0;
            this.tpnlResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultArea_MouseDown);
            // 
            // lvwLeaveFlights
            // 
            this.lvwLeaveFlights.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvwLeaveFlights.BackColor = System.Drawing.SystemColors.Window;
            this.lvwLeaveFlights.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwLeaveFlights.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.l_depTime,
            this.l_arrTime,
            this.l_airline,
            this.l_price});
            this.lvwLeaveFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwLeaveFlights.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvwLeaveFlights.FullRowSelect = true;
            this.lvwLeaveFlights.HideSelection = false;
            this.lvwLeaveFlights.Location = new System.Drawing.Point(6, 230);
            this.lvwLeaveFlights.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lvwLeaveFlights.Name = "lvwLeaveFlights";
            this.lvwLeaveFlights.Size = new System.Drawing.Size(588, 771);
            this.lvwLeaveFlights.TabIndex = 0;
            this.lvwLeaveFlights.UseCompatibleStateImageBehavior = false;
            this.lvwLeaveFlights.View = System.Windows.Forms.View.Details;
            this.lvwLeaveFlights.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultArea_MouseDown);
            // 
            // l_depTime
            // 
            this.l_depTime.Text = "출발시간";
            this.l_depTime.Width = 100;
            // 
            // l_arrTime
            // 
            this.l_arrTime.Text = "도착시간";
            this.l_arrTime.Width = 100;
            // 
            // l_airline
            // 
            this.l_airline.Text = "항공사";
            this.l_airline.Width = 100;
            // 
            // l_price
            // 
            this.l_price.Text = "요금(이코노미석)";
            this.l_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.l_price.Width = 120;
            // 
            // lvwReturnFlights
            // 
            this.lvwReturnFlights.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwReturnFlights.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.r_depTime,
            this.r_arrTime,
            this.r_airline,
            this.r_price});
            this.lvwReturnFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwReturnFlights.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwReturnFlights.FullRowSelect = true;
            this.lvwReturnFlights.HideSelection = false;
            this.lvwReturnFlights.Location = new System.Drawing.Point(605, 230);
            this.lvwReturnFlights.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lvwReturnFlights.Name = "lvwReturnFlights";
            this.lvwReturnFlights.Size = new System.Drawing.Size(588, 771);
            this.lvwReturnFlights.TabIndex = 1;
            this.lvwReturnFlights.UseCompatibleStateImageBehavior = false;
            this.lvwReturnFlights.View = System.Windows.Forms.View.Details;
            this.lvwReturnFlights.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultArea_MouseDown);
            // 
            // r_depTime
            // 
            this.r_depTime.Text = "출발시간";
            this.r_depTime.Width = 100;
            // 
            // r_arrTime
            // 
            this.r_arrTime.Text = "도착시간";
            this.r_arrTime.Width = 100;
            // 
            // r_airline
            // 
            this.r_airline.Text = "항공사";
            this.r_airline.Width = 100;
            // 
            // r_price
            // 
            this.r_price.Text = "요금(이코노미석)";
            this.r_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.r_price.Width = 120;
            // 
            // pnlLeaveStatus
            // 
            this.pnlLeaveStatus.Controls.Add(this.btnLeaveInfo);
            this.pnlLeaveStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeaveStatus.Location = new System.Drawing.Point(6, 6);
            this.pnlLeaveStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlLeaveStatus.Name = "pnlLeaveStatus";
            this.pnlLeaveStatus.Size = new System.Drawing.Size(588, 213);
            this.pnlLeaveStatus.TabIndex = 2;
            // 
            // btnLeaveInfo
            // 
            this.btnLeaveInfo.AutoSize = true;
            this.btnLeaveInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeaveInfo.FlatAppearance.BorderSize = 0;
            this.btnLeaveInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLeaveInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLeaveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveInfo.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnLeaveInfo.Location = new System.Drawing.Point(0, 0);
            this.btnLeaveInfo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLeaveInfo.Name = "btnLeaveInfo";
            this.btnLeaveInfo.Size = new System.Drawing.Size(588, 213);
            this.btnLeaveInfo.TabIndex = 0;
            this.btnLeaveInfo.UseVisualStyleBackColor = true;
            this.btnLeaveInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultArea_MouseDown);
            // 
            // pnlReturnStatus
            // 
            this.pnlReturnStatus.Controls.Add(this.btnReturnInfo);
            this.pnlReturnStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReturnStatus.Location = new System.Drawing.Point(605, 6);
            this.pnlReturnStatus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlReturnStatus.Name = "pnlReturnStatus";
            this.pnlReturnStatus.Size = new System.Drawing.Size(588, 213);
            this.pnlReturnStatus.TabIndex = 3;
            // 
            // btnReturnInfo
            // 
            this.btnReturnInfo.AutoSize = true;
            this.btnReturnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturnInfo.FlatAppearance.BorderSize = 0;
            this.btnReturnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReturnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReturnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnInfo.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnReturnInfo.Location = new System.Drawing.Point(0, 0);
            this.btnReturnInfo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnReturnInfo.Name = "btnReturnInfo";
            this.btnReturnInfo.Size = new System.Drawing.Size(588, 213);
            this.btnReturnInfo.TabIndex = 0;
            this.btnReturnInfo.UseVisualStyleBackColor = true;
            this.btnReturnInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultArea_MouseDown);
            // 
            // btnLeaveTotal
            // 
            this.btnLeaveTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeaveTotal.FlatAppearance.BorderSize = 0;
            this.btnLeaveTotal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLeaveTotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLeaveTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveTotal.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnLeaveTotal.Location = new System.Drawing.Point(6, 1012);
            this.btnLeaveTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLeaveTotal.Name = "btnLeaveTotal";
            this.btnLeaveTotal.Size = new System.Drawing.Size(588, 102);
            this.btnLeaveTotal.TabIndex = 4;
            this.btnLeaveTotal.Text = "총  0  개의  결과";
            this.btnLeaveTotal.UseVisualStyleBackColor = true;
            this.btnLeaveTotal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultArea_MouseDown);
            // 
            // btnReturnTotal
            // 
            this.btnReturnTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturnTotal.FlatAppearance.BorderSize = 0;
            this.btnReturnTotal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReturnTotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReturnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnTotal.Font = new System.Drawing.Font(ThemeFont.PrimaryFont.Families[0], 13F);
            this.btnReturnTotal.Location = new System.Drawing.Point(605, 1012);
            this.btnReturnTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnReturnTotal.Name = "btnReturnTotal";
            this.btnReturnTotal.Size = new System.Drawing.Size(588, 102);
            this.btnReturnTotal.TabIndex = 5;
            this.btnReturnTotal.Text = "총  0  개의  결과";
            this.btnReturnTotal.UseVisualStyleBackColor = true;
            // 
            // imgAirlineLogo
            // 
            this.imgAirlineLogo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgAirlineLogo.ImageStream")));
            this.imgAirlineLogo.TransparentColor = System.Drawing.Color.Transparent;
            this.imgAirlineLogo.Images.SetKeyName(0, "대한항공.png");
            this.imgAirlineLogo.Images.SetKeyName(1, "아시아나항공.png");
            this.imgAirlineLogo.Images.SetKeyName(2, "에어부산.png");
            this.imgAirlineLogo.Images.SetKeyName(3, "에어서울.png");
            this.imgAirlineLogo.Images.SetKeyName(4, "이스타항공.png");
            this.imgAirlineLogo.Images.SetKeyName(5, "제주항공.png");
            this.imgAirlineLogo.Images.SetKeyName(6, "진에어.png");
            this.imgAirlineLogo.Images.SetKeyName(7, "티웨이항공.png");
            this.imgAirlineLogo.Images.SetKeyName(8, "플라이강원로고.png");
            this.imgAirlineLogo.Images.SetKeyName(9, "하이에어로고.png");
            // 
            // FormPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1524, 1120);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlOptions);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormPlane";
            this.Text = "항공편(국내선)";
            this.pnlOptions.ResumeLayout(false);
            this.pnlCourse.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetail_Airlines.ResumeLayout(false);
            this.pnlDetail_Airlines.PerformLayout();
            this.pnlDetail_SeatClass.ResumeLayout(false);
            this.pnlDetail_Date.ResumeLayout(false);
            this.pnlDetail_Date.PerformLayout();
            this.pnlDetail_Arrival.ResumeLayout(false);
            this.pnlArrAirports.ResumeLayout(false);
            this.pnlArrAirports.PerformLayout();
            this.pnlArr_Input.ResumeLayout(false);
            this.pnlArr_Input.PerformLayout();
            this.pnlDetail_Departure.ResumeLayout(false);
            this.pnlDepAirports.ResumeLayout(false);
            this.pnlDepAirports.PerformLayout();
            this.pnlDep_Input.ResumeLayout(false);
            this.pnlDep_Input.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.tpnlResults.ResumeLayout(false);
            this.pnlLeaveStatus.ResumeLayout(false);
            this.pnlLeaveStatus.PerformLayout();
            this.pnlReturnStatus.ResumeLayout(false);
            this.pnlReturnStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlOptions;
		private System.Windows.Forms.Button btnOptions_SeatClass;
		private System.Windows.Forms.Button btnOptions_Date;
		private System.Windows.Forms.Button btnOptions_Arrival;
		private System.Windows.Forms.Button btnOptions_Departure;
		private System.Windows.Forms.Panel pnlCourse;
		private System.Windows.Forms.Button btnCourse_Single;
		private System.Windows.Forms.Button btnCourse_RoundTrip;
		private System.Windows.Forms.Timer tmrDetailsPanel_Move;
		private System.Windows.Forms.Timer tmrAirportsPanel_Move;
		private System.Windows.Forms.ImageList imgArrow;
		private System.Windows.Forms.Panel pnlDetails;
		private System.Windows.Forms.Panel pnlDetail_SeatClass;
		private System.Windows.Forms.Button btnDetail_SeatClass_Business;
		private System.Windows.Forms.Button btnDetail_SeatClass_Economy;
		private System.Windows.Forms.Panel pnlDetail_Date;
		private System.Windows.Forms.DateTimePicker dtpReturnDate;
		private System.Windows.Forms.DateTimePicker dtpLeaveDate;
		private System.Windows.Forms.Label lblDetail_Date_Return;
		private System.Windows.Forms.Label lblDetail_Date_Leave;
		private System.Windows.Forms.Panel pnlDetail_Arrival;
		private System.Windows.Forms.Panel pnlArrAirports;
		private System.Windows.Forms.TableLayoutPanel tpnlArrAirports;
		private System.Windows.Forms.Panel pnlArr_Input;
		private System.Windows.Forms.Button btnShowArrAirports;
		private System.Windows.Forms.Label lblDetail_Arrival_Name;
		private System.Windows.Forms.TextBox txtArrAirport_Name;
		private System.Windows.Forms.Panel pnlDetail_Departure;
		private System.Windows.Forms.Panel pnlDepAirports;
		private System.Windows.Forms.TableLayoutPanel tpnlDepAirports;
		private System.Windows.Forms.Panel pnlDep_Input;
		private System.Windows.Forms.Button btnShowDepAirports;
		private System.Windows.Forms.Label lblDetail_Departure_Name;
		private System.Windows.Forms.TextBox txtDepAirport_Name;
		private System.Windows.Forms.Panel pnlBody;
		private System.Windows.Forms.TableLayoutPanel tpnlResults;
		private System.Windows.Forms.ListView lvwLeaveFlights;
		private System.Windows.Forms.ListView lvwReturnFlights;
		private System.Windows.Forms.Panel pnlLeaveStatus;
		private System.Windows.Forms.Panel pnlReturnStatus;
		private System.Windows.Forms.ColumnHeader l_depTime;
		private System.Windows.Forms.ColumnHeader l_arrTime;
		private System.Windows.Forms.ColumnHeader l_airline;
		private System.Windows.Forms.ColumnHeader l_price;
		private System.Windows.Forms.ColumnHeader r_depTime;
		private System.Windows.Forms.ColumnHeader r_arrTime;
		private System.Windows.Forms.ColumnHeader r_airline;
		private System.Windows.Forms.ColumnHeader r_price;
		private System.Windows.Forms.Button btnLeaveInfo;
		private System.Windows.Forms.Button btnReturnInfo;
		private System.Windows.Forms.Button btnOptions_Airline;
		private System.Windows.Forms.Panel pnlDetail_Airlines;
		private System.Windows.Forms.TableLayoutPanel tpnlAirlines;
		private System.Windows.Forms.Button btnLeaveTotal;
		private System.Windows.Forms.Button btnReturnTotal;
		private System.Windows.Forms.ImageList imgAirlineLogo;
	}
}
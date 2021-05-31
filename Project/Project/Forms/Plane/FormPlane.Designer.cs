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
			this.btnOptions_SeatClass = new System.Windows.Forms.Button();
			this.btnOptions_Date = new System.Windows.Forms.Button();
			this.btnOptions_Arrival = new System.Windows.Forms.Button();
			this.btnOptions_Departure = new System.Windows.Forms.Button();
			this.pnlCourse = new System.Windows.Forms.Panel();
			this.btnCourse_Single = new System.Windows.Forms.Button();
			this.btnCourse_RoundTrip = new System.Windows.Forms.Button();
			this.tmrDetailsPanel_Move = new System.Windows.Forms.Timer(this.components);
			this.tmrAirportsPanel_Move = new System.Windows.Forms.Timer(this.components);
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.pnlDetails = new System.Windows.Forms.Panel();
			this.pnlDetail_SeatClass = new System.Windows.Forms.Panel();
			this.btnDetail_SeatClass_Business = new System.Windows.Forms.Button();
			this.btnDetail_SeatClass_Economy = new System.Windows.Forms.Button();
			this.pnlDetail_Date = new System.Windows.Forms.Panel();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.l_depTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.l_arrTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.l_airline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.l_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listView2 = new System.Windows.Forms.ListView();
			this.r_depTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.r_arrTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.r_airline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.r_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pnlLeaveStatus = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlReturnStatus = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pnlOptions.SuspendLayout();
			this.pnlCourse.SuspendLayout();
			this.pnlDetails.SuspendLayout();
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
			this.pnlOptions.Controls.Add(this.btnOptions_SeatClass);
			this.pnlOptions.Controls.Add(this.btnOptions_Date);
			this.pnlOptions.Controls.Add(this.btnOptions_Arrival);
			this.pnlOptions.Controls.Add(this.btnOptions_Departure);
			this.pnlOptions.Controls.Add(this.pnlCourse);
			this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlOptions.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.pnlOptions.Location = new System.Drawing.Point(0, 0);
			this.pnlOptions.Name = "pnlOptions";
			this.pnlOptions.Size = new System.Drawing.Size(200, 448);
			this.pnlOptions.TabIndex = 2;
			// 
			// btnOptions_SeatClass
			// 
			this.btnOptions_SeatClass.BackColor = System.Drawing.Color.Transparent;
			this.btnOptions_SeatClass.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnOptions_SeatClass.FlatAppearance.BorderSize = 0;
			this.btnOptions_SeatClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOptions_SeatClass.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.btnOptions_SeatClass.ForeColor = System.Drawing.Color.White;
			this.btnOptions_SeatClass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOptions_SeatClass.Location = new System.Drawing.Point(0, 280);
			this.btnOptions_SeatClass.Name = "btnOptions_SeatClass";
			this.btnOptions_SeatClass.Size = new System.Drawing.Size(200, 70);
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
			this.btnOptions_Date.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.btnOptions_Date.ForeColor = System.Drawing.Color.White;
			this.btnOptions_Date.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOptions_Date.Location = new System.Drawing.Point(0, 210);
			this.btnOptions_Date.Name = "btnOptions_Date";
			this.btnOptions_Date.Size = new System.Drawing.Size(200, 70);
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
			this.btnOptions_Arrival.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.btnOptions_Arrival.ForeColor = System.Drawing.Color.White;
			this.btnOptions_Arrival.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOptions_Arrival.Location = new System.Drawing.Point(0, 140);
			this.btnOptions_Arrival.Name = "btnOptions_Arrival";
			this.btnOptions_Arrival.Size = new System.Drawing.Size(200, 70);
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
			this.btnOptions_Departure.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.btnOptions_Departure.ForeColor = System.Drawing.Color.White;
			this.btnOptions_Departure.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOptions_Departure.Location = new System.Drawing.Point(0, 70);
			this.btnOptions_Departure.Name = "btnOptions_Departure";
			this.btnOptions_Departure.Size = new System.Drawing.Size(200, 70);
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
			this.pnlCourse.Name = "pnlCourse";
			this.pnlCourse.Size = new System.Drawing.Size(200, 70);
			this.pnlCourse.TabIndex = 0;
			// 
			// btnCourse_Single
			// 
			this.btnCourse_Single.BackColor = System.Drawing.Color.Transparent;
			this.btnCourse_Single.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCourse_Single.FlatAppearance.BorderSize = 0;
			this.btnCourse_Single.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCourse_Single.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.btnCourse_Single.ForeColor = System.Drawing.Color.White;
			this.btnCourse_Single.Location = new System.Drawing.Point(100, 0);
			this.btnCourse_Single.Margin = new System.Windows.Forms.Padding(0);
			this.btnCourse_Single.Name = "btnCourse_Single";
			this.btnCourse_Single.Size = new System.Drawing.Size(100, 70);
			this.btnCourse_Single.TabIndex = 1;
			this.btnCourse_Single.Text = "편도";
			this.btnCourse_Single.UseVisualStyleBackColor = false;
			this.btnCourse_Single.Click += new System.EventHandler(this.btnCourse_Single_Click);
			// 
			// btnCourse_RoundTrip
			// 
			this.btnCourse_RoundTrip.BackColor = System.Drawing.Color.Transparent;
			this.btnCourse_RoundTrip.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnCourse_RoundTrip.FlatAppearance.BorderSize = 0;
			this.btnCourse_RoundTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCourse_RoundTrip.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.btnCourse_RoundTrip.ForeColor = System.Drawing.Color.White;
			this.btnCourse_RoundTrip.Location = new System.Drawing.Point(0, 0);
			this.btnCourse_RoundTrip.Margin = new System.Windows.Forms.Padding(0);
			this.btnCourse_RoundTrip.Name = "btnCourse_RoundTrip";
			this.btnCourse_RoundTrip.Size = new System.Drawing.Size(100, 70);
			this.btnCourse_RoundTrip.TabIndex = 0;
			this.btnCourse_RoundTrip.Text = "왕복";
			this.btnCourse_RoundTrip.UseVisualStyleBackColor = false;
			this.btnCourse_RoundTrip.Click += new System.EventHandler(this.btnCourse_RoundTrip_Click);
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
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "downarrow.png");
			this.imageList1.Images.SetKeyName(1, "uparrow.png");
			// 
			// pnlDetails
			// 
			this.pnlDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
			this.pnlDetails.Controls.Add(this.pnlDetail_SeatClass);
			this.pnlDetails.Controls.Add(this.pnlDetail_Date);
			this.pnlDetails.Controls.Add(this.pnlDetail_Arrival);
			this.pnlDetails.Controls.Add(this.pnlDetail_Departure);
			this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlDetails.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.pnlDetails.ForeColor = System.Drawing.Color.White;
			this.pnlDetails.Location = new System.Drawing.Point(200, 0);
			this.pnlDetails.Margin = new System.Windows.Forms.Padding(0);
			this.pnlDetails.MaximumSize = new System.Drawing.Size(400, 3000);
			this.pnlDetails.Name = "pnlDetails";
			this.pnlDetails.Size = new System.Drawing.Size(0, 448);
			this.pnlDetails.TabIndex = 4;
			this.pnlDetails.Visible = false;
			// 
			// pnlDetail_SeatClass
			// 
			this.pnlDetail_SeatClass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlDetail_SeatClass.BackColor = System.Drawing.Color.Transparent;
			this.pnlDetail_SeatClass.Controls.Add(this.btnDetail_SeatClass_Business);
			this.pnlDetail_SeatClass.Controls.Add(this.btnDetail_SeatClass_Economy);
			this.pnlDetail_SeatClass.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDetail_SeatClass.Location = new System.Drawing.Point(0, 466);
			this.pnlDetail_SeatClass.Margin = new System.Windows.Forms.Padding(0);
			this.pnlDetail_SeatClass.MaximumSize = new System.Drawing.Size(400, 70);
			this.pnlDetail_SeatClass.MinimumSize = new System.Drawing.Size(400, 0);
			this.pnlDetail_SeatClass.Name = "pnlDetail_SeatClass";
			this.pnlDetail_SeatClass.Size = new System.Drawing.Size(400, 70);
			this.pnlDetail_SeatClass.TabIndex = 4;
			// 
			// btnDetail_SeatClass_Business
			// 
			this.btnDetail_SeatClass_Business.BackColor = System.Drawing.Color.Transparent;
			this.btnDetail_SeatClass_Business.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnDetail_SeatClass_Business.FlatAppearance.BorderSize = 0;
			this.btnDetail_SeatClass_Business.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDetail_SeatClass_Business.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.btnDetail_SeatClass_Business.Location = new System.Drawing.Point(200, 0);
			this.btnDetail_SeatClass_Business.Margin = new System.Windows.Forms.Padding(0);
			this.btnDetail_SeatClass_Business.Name = "btnDetail_SeatClass_Business";
			this.btnDetail_SeatClass_Business.Size = new System.Drawing.Size(200, 70);
			this.btnDetail_SeatClass_Business.TabIndex = 1;
			this.btnDetail_SeatClass_Business.Text = "비즈니스";
			this.btnDetail_SeatClass_Business.UseVisualStyleBackColor = false;
			this.btnDetail_SeatClass_Business.Click += new System.EventHandler(this.btnDetail_SeatClass_Business_Click);
			// 
			// btnDetail_SeatClass_Economy
			// 
			this.btnDetail_SeatClass_Economy.BackColor = System.Drawing.Color.Transparent;
			this.btnDetail_SeatClass_Economy.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnDetail_SeatClass_Economy.FlatAppearance.BorderSize = 0;
			this.btnDetail_SeatClass_Economy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDetail_SeatClass_Economy.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.btnDetail_SeatClass_Economy.Location = new System.Drawing.Point(0, 0);
			this.btnDetail_SeatClass_Economy.Margin = new System.Windows.Forms.Padding(0);
			this.btnDetail_SeatClass_Economy.Name = "btnDetail_SeatClass_Economy";
			this.btnDetail_SeatClass_Economy.Size = new System.Drawing.Size(200, 70);
			this.btnDetail_SeatClass_Economy.TabIndex = 0;
			this.btnDetail_SeatClass_Economy.Text = "이코노미";
			this.btnDetail_SeatClass_Economy.UseVisualStyleBackColor = false;
			this.btnDetail_SeatClass_Economy.Click += new System.EventHandler(this.btnDetail_SeatClass_Economy_Click);
			// 
			// pnlDetail_Date
			// 
			this.pnlDetail_Date.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlDetail_Date.Controls.Add(this.dateTimePicker2);
			this.pnlDetail_Date.Controls.Add(this.dateTimePicker1);
			this.pnlDetail_Date.Controls.Add(this.lblDetail_Date_Return);
			this.pnlDetail_Date.Controls.Add(this.lblDetail_Date_Leave);
			this.pnlDetail_Date.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDetail_Date.Location = new System.Drawing.Point(0, 326);
			this.pnlDetail_Date.Margin = new System.Windows.Forms.Padding(0);
			this.pnlDetail_Date.MaximumSize = new System.Drawing.Size(400, 140);
			this.pnlDetail_Date.MinimumSize = new System.Drawing.Size(400, 0);
			this.pnlDetail_Date.Name = "pnlDetail_Date";
			this.pnlDetail_Date.Size = new System.Drawing.Size(400, 140);
			this.pnlDetail_Date.TabIndex = 3;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Font = new System.Drawing.Font("서울남산체 B", 17F);
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(138, 85);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(240, 36);
			this.dateTimePicker2.TabIndex = 11;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("서울남산체 B", 17F);
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(138, 20);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(240, 36);
			this.dateTimePicker1.TabIndex = 10;
			// 
			// lblDetail_Date_Return
			// 
			this.lblDetail_Date_Return.AutoSize = true;
			this.lblDetail_Date_Return.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.lblDetail_Date_Return.Location = new System.Drawing.Point(21, 90);
			this.lblDetail_Date_Return.Name = "lblDetail_Date_Return";
			this.lblDetail_Date_Return.Size = new System.Drawing.Size(111, 22);
			this.lblDetail_Date_Return.TabIndex = 9;
			this.lblDetail_Date_Return.Text = "오는 날    :";
			// 
			// lblDetail_Date_Leave
			// 
			this.lblDetail_Date_Leave.AutoSize = true;
			this.lblDetail_Date_Leave.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.lblDetail_Date_Leave.Location = new System.Drawing.Point(21, 25);
			this.lblDetail_Date_Leave.Name = "lblDetail_Date_Leave";
			this.lblDetail_Date_Leave.Size = new System.Drawing.Size(111, 22);
			this.lblDetail_Date_Leave.TabIndex = 8;
			this.lblDetail_Date_Leave.Text = "가는 날    :";
			// 
			// pnlDetail_Arrival
			// 
			this.pnlDetail_Arrival.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlDetail_Arrival.Controls.Add(this.pnlArrAirports);
			this.pnlDetail_Arrival.Controls.Add(this.pnlArr_Input);
			this.pnlDetail_Arrival.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDetail_Arrival.Location = new System.Drawing.Point(0, 163);
			this.pnlDetail_Arrival.Margin = new System.Windows.Forms.Padding(0);
			this.pnlDetail_Arrival.MaximumSize = new System.Drawing.Size(400, 350);
			this.pnlDetail_Arrival.MinimumSize = new System.Drawing.Size(400, 0);
			this.pnlDetail_Arrival.Name = "pnlDetail_Arrival";
			this.pnlDetail_Arrival.Size = new System.Drawing.Size(400, 163);
			this.pnlDetail_Arrival.TabIndex = 2;
			// 
			// pnlArrAirports
			// 
			this.pnlArrAirports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlArrAirports.Controls.Add(this.tpnlArrAirports);
			this.pnlArrAirports.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlArrAirports.Font = new System.Drawing.Font("서울남산체 B", 12F);
			this.pnlArrAirports.Location = new System.Drawing.Point(0, 113);
			this.pnlArrAirports.Margin = new System.Windows.Forms.Padding(0);
			this.pnlArrAirports.MaximumSize = new System.Drawing.Size(400, 250);
			this.pnlArrAirports.MinimumSize = new System.Drawing.Size(400, 0);
			this.pnlArrAirports.Name = "pnlArrAirports";
			this.pnlArrAirports.Size = new System.Drawing.Size(400, 50);
			this.pnlArrAirports.TabIndex = 8;
			// 
			// tpnlArrAirports
			// 
			this.tpnlArrAirports.AutoSize = true;
			this.tpnlArrAirports.BackColor = System.Drawing.Color.Transparent;
			this.tpnlArrAirports.ColumnCount = 1;
			this.tpnlArrAirports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tpnlArrAirports.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tpnlArrAirports.Location = new System.Drawing.Point(0, 0);
			this.tpnlArrAirports.Margin = new System.Windows.Forms.Padding(0);
			this.tpnlArrAirports.Name = "tpnlArrAirports";
			this.tpnlArrAirports.RowCount = 1;
			this.tpnlArrAirports.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tpnlArrAirports.Size = new System.Drawing.Size(100, 50);
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
			this.pnlArr_Input.Size = new System.Drawing.Size(400, 113);
			this.pnlArr_Input.TabIndex = 7;
			// 
			// btnShowArrAirports
			// 
			this.btnShowArrAirports.BackColor = System.Drawing.Color.Transparent;
			this.btnShowArrAirports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
			this.btnShowArrAirports.FlatAppearance.BorderSize = 0;
			this.btnShowArrAirports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShowArrAirports.Image = global::Project.Properties.Resources.downarrow;
			this.btnShowArrAirports.Location = new System.Drawing.Point(0, 70);
			this.btnShowArrAirports.Margin = new System.Windows.Forms.Padding(0);
			this.btnShowArrAirports.Name = "btnShowArrAirports";
			this.btnShowArrAirports.Size = new System.Drawing.Size(400, 40);
			this.btnShowArrAirports.TabIndex = 9;
			this.btnShowArrAirports.UseVisualStyleBackColor = false;
			this.btnShowArrAirports.Click += new System.EventHandler(this.btnShowArrAirports_Click);
			// 
			// lblDetail_Arrival_Name
			// 
			this.lblDetail_Arrival_Name.AutoSize = true;
			this.lblDetail_Arrival_Name.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.lblDetail_Arrival_Name.Location = new System.Drawing.Point(21, 24);
			this.lblDetail_Arrival_Name.Name = "lblDetail_Arrival_Name";
			this.lblDetail_Arrival_Name.Size = new System.Drawing.Size(117, 22);
			this.lblDetail_Arrival_Name.TabIndex = 8;
			this.lblDetail_Arrival_Name.Text = "도착 공항  :";
			// 
			// txtArrAirport_Name
			// 
			this.txtArrAirport_Name.BackColor = System.Drawing.Color.White;
			this.txtArrAirport_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtArrAirport_Name.Font = new System.Drawing.Font("서울남산체 B", 17F);
			this.txtArrAirport_Name.ForeColor = System.Drawing.Color.Gainsboro;
			this.txtArrAirport_Name.Location = new System.Drawing.Point(160, 17);
			this.txtArrAirport_Name.Name = "txtArrAirport_Name";
			this.txtArrAirport_Name.Size = new System.Drawing.Size(218, 36);
			this.txtArrAirport_Name.TabIndex = 7;
			this.txtArrAirport_Name.Text = "인천  ( ICN )";
			this.txtArrAirport_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pnlDetail_Departure
			// 
			this.pnlDetail_Departure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlDetail_Departure.Controls.Add(this.pnlDepAirports);
			this.pnlDetail_Departure.Controls.Add(this.pnlDep_Input);
			this.pnlDetail_Departure.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDetail_Departure.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.pnlDetail_Departure.Location = new System.Drawing.Point(0, 0);
			this.pnlDetail_Departure.Margin = new System.Windows.Forms.Padding(2);
			this.pnlDetail_Departure.MaximumSize = new System.Drawing.Size(396, 420);
			this.pnlDetail_Departure.MinimumSize = new System.Drawing.Size(396, 0);
			this.pnlDetail_Departure.Name = "pnlDetail_Departure";
			this.pnlDetail_Departure.Size = new System.Drawing.Size(396, 163);
			this.pnlDetail_Departure.TabIndex = 1;
			// 
			// pnlDepAirports
			// 
			this.pnlDepAirports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlDepAirports.Controls.Add(this.tpnlDepAirports);
			this.pnlDepAirports.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDepAirports.Font = new System.Drawing.Font("서울남산체 B", 12F);
			this.pnlDepAirports.Location = new System.Drawing.Point(0, 113);
			this.pnlDepAirports.Margin = new System.Windows.Forms.Padding(0);
			this.pnlDepAirports.MaximumSize = new System.Drawing.Size(400, 250);
			this.pnlDepAirports.MinimumSize = new System.Drawing.Size(400, 0);
			this.pnlDepAirports.Name = "pnlDepAirports";
			this.pnlDepAirports.Size = new System.Drawing.Size(400, 50);
			this.pnlDepAirports.TabIndex = 4;
			// 
			// tpnlDepAirports
			// 
			this.tpnlDepAirports.AutoSize = true;
			this.tpnlDepAirports.BackColor = System.Drawing.Color.Transparent;
			this.tpnlDepAirports.ColumnCount = 1;
			this.tpnlDepAirports.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tpnlDepAirports.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tpnlDepAirports.Location = new System.Drawing.Point(0, 0);
			this.tpnlDepAirports.Margin = new System.Windows.Forms.Padding(0);
			this.tpnlDepAirports.Name = "tpnlDepAirports";
			this.tpnlDepAirports.RowCount = 1;
			this.tpnlDepAirports.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tpnlDepAirports.Size = new System.Drawing.Size(100, 50);
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
			this.pnlDep_Input.Size = new System.Drawing.Size(396, 113);
			this.pnlDep_Input.TabIndex = 3;
			// 
			// btnShowDepAirports
			// 
			this.btnShowDepAirports.BackColor = System.Drawing.Color.Transparent;
			this.btnShowDepAirports.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnShowDepAirports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
			this.btnShowDepAirports.FlatAppearance.BorderSize = 0;
			this.btnShowDepAirports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShowDepAirports.Image = global::Project.Properties.Resources.downarrow;
			this.btnShowDepAirports.Location = new System.Drawing.Point(0, 73);
			this.btnShowDepAirports.Margin = new System.Windows.Forms.Padding(0);
			this.btnShowDepAirports.Name = "btnShowDepAirports";
			this.btnShowDepAirports.Size = new System.Drawing.Size(396, 40);
			this.btnShowDepAirports.TabIndex = 5;
			this.btnShowDepAirports.UseVisualStyleBackColor = false;
			this.btnShowDepAirports.Click += new System.EventHandler(this.btnShowDepAirports_Click);
			// 
			// lblDetail_Departure_Name
			// 
			this.lblDetail_Departure_Name.AutoSize = true;
			this.lblDetail_Departure_Name.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.lblDetail_Departure_Name.Location = new System.Drawing.Point(20, 20);
			this.lblDetail_Departure_Name.Name = "lblDetail_Departure_Name";
			this.lblDetail_Departure_Name.Size = new System.Drawing.Size(117, 22);
			this.lblDetail_Departure_Name.TabIndex = 3;
			this.lblDetail_Departure_Name.Text = "출발 공항  :";
			// 
			// txtDepAirport_Name
			// 
			this.txtDepAirport_Name.BackColor = System.Drawing.Color.White;
			this.txtDepAirport_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDepAirport_Name.Font = new System.Drawing.Font("서울남산체 B", 17F);
			this.txtDepAirport_Name.ForeColor = System.Drawing.Color.Gainsboro;
			this.txtDepAirport_Name.Location = new System.Drawing.Point(159, 14);
			this.txtDepAirport_Name.Multiline = true;
			this.txtDepAirport_Name.Name = "txtDepAirport_Name";
			this.txtDepAirport_Name.Size = new System.Drawing.Size(218, 37);
			this.txtDepAirport_Name.TabIndex = 2;
			this.txtDepAirport_Name.Text = "인천  ( ICN )";
			this.txtDepAirport_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pnlBody
			// 
			this.pnlBody.AutoScroll = true;
			this.pnlBody.Controls.Add(this.tpnlResults);
			this.pnlBody.Location = new System.Drawing.Point(200, 0);
			this.pnlBody.Name = "pnlBody";
			this.pnlBody.Size = new System.Drawing.Size(738, 448);
			this.pnlBody.TabIndex = 5;
			// 
			// tpnlResults
			// 
			this.tpnlResults.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tpnlResults.ColumnCount = 2;
			this.tpnlResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tpnlResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tpnlResults.Controls.Add(this.listView1, 0, 1);
			this.tpnlResults.Controls.Add(this.listView2, 1, 1);
			this.tpnlResults.Controls.Add(this.pnlLeaveStatus, 0, 0);
			this.tpnlResults.Controls.Add(this.pnlReturnStatus, 1, 0);
			this.tpnlResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tpnlResults.Location = new System.Drawing.Point(0, 0);
			this.tpnlResults.Name = "tpnlResults";
			this.tpnlResults.RowCount = 2;
			this.tpnlResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tpnlResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
			this.tpnlResults.Size = new System.Drawing.Size(738, 448);
			this.tpnlResults.TabIndex = 0;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.l_depTime,
            this.l_arrTime,
            this.l_airline,
            this.l_price});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(4, 155);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(361, 494);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// l_depTime
			// 
			this.l_depTime.Text = "출발시간";
			this.l_depTime.Width = 95;
			// 
			// l_arrTime
			// 
			this.l_arrTime.Text = "도착시간";
			this.l_arrTime.Width = 88;
			// 
			// l_airline
			// 
			this.l_airline.Text = "항공사";
			this.l_airline.Width = 82;
			// 
			// l_price
			// 
			this.l_price.Text = "요금";
			this.l_price.Width = 93;
			// 
			// listView2
			// 
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.r_depTime,
            this.r_arrTime,
            this.r_airline,
            this.r_price});
			this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView2.HideSelection = false;
			this.listView2.Location = new System.Drawing.Point(372, 155);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(362, 494);
			this.listView2.TabIndex = 1;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			// 
			// r_depTime
			// 
			this.r_depTime.Text = "출발시간";
			this.r_depTime.Width = 93;
			// 
			// r_arrTime
			// 
			this.r_arrTime.Text = "도착시간";
			this.r_arrTime.Width = 90;
			// 
			// r_airline
			// 
			this.r_airline.Text = "항공사";
			this.r_airline.Width = 82;
			// 
			// r_price
			// 
			this.r_price.Text = "요금";
			this.r_price.Width = 90;
			// 
			// pnlLeaveStatus
			// 
			this.pnlLeaveStatus.Controls.Add(this.label2);
			this.pnlLeaveStatus.Controls.Add(this.label1);
			this.pnlLeaveStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlLeaveStatus.Location = new System.Drawing.Point(4, 4);
			this.pnlLeaveStatus.Name = "pnlLeaveStatus";
			this.pnlLeaveStatus.Size = new System.Drawing.Size(361, 144);
			this.pnlLeaveStatus.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("서울남산체 B", 15F);
			this.label2.Location = new System.Drawing.Point(70, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(220, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "2021 년  07 월  23일";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("서울남산체 B", 18F);
			this.label1.Location = new System.Drawing.Point(65, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(227, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "김포    →    부산";
			// 
			// pnlReturnStatus
			// 
			this.pnlReturnStatus.Controls.Add(this.label4);
			this.pnlReturnStatus.Controls.Add(this.label3);
			this.pnlReturnStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlReturnStatus.Location = new System.Drawing.Point(372, 4);
			this.pnlReturnStatus.Name = "pnlReturnStatus";
			this.pnlReturnStatus.Size = new System.Drawing.Size(362, 144);
			this.pnlReturnStatus.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("서울남산체 B", 15F);
			this.label4.Location = new System.Drawing.Point(73, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(220, 25);
			this.label4.TabIndex = 2;
			this.label4.Text = "2021 년  07 월  23일";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("서울남산체 B", 18F);
			this.label3.Location = new System.Drawing.Point(68, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(227, 30);
			this.label3.TabIndex = 2;
			this.label3.Text = "김포    →    부산";
			// 
			// FormPlane
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(938, 448);
			this.Controls.Add(this.pnlBody);
			this.Controls.Add(this.pnlDetails);
			this.Controls.Add(this.pnlOptions);
			this.Name = "FormPlane";
			this.Text = "항공편(국내선)";
			this.Load += new System.EventHandler(this.FormPlane_Load);
			this.pnlOptions.ResumeLayout(false);
			this.pnlCourse.ResumeLayout(false);
			this.pnlDetails.ResumeLayout(false);
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
			this.tpnlResults.ResumeLayout(false);
			this.pnlLeaveStatus.ResumeLayout(false);
			this.pnlLeaveStatus.PerformLayout();
			this.pnlReturnStatus.ResumeLayout(false);
			this.pnlReturnStatus.PerformLayout();
			this.ResumeLayout(false);

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
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel pnlDetails;
		private System.Windows.Forms.Panel pnlDetail_SeatClass;
		private System.Windows.Forms.Button btnDetail_SeatClass_Business;
		private System.Windows.Forms.Button btnDetail_SeatClass_Economy;
		private System.Windows.Forms.Panel pnlDetail_Date;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.Panel pnlLeaveStatus;
		private System.Windows.Forms.Panel pnlReturnStatus;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader l_depTime;
		private System.Windows.Forms.ColumnHeader l_arrTime;
		private System.Windows.Forms.ColumnHeader l_airline;
		private System.Windows.Forms.ColumnHeader l_price;
		private System.Windows.Forms.ColumnHeader r_depTime;
		private System.Windows.Forms.ColumnHeader r_arrTime;
		private System.Windows.Forms.ColumnHeader r_airline;
		private System.Windows.Forms.ColumnHeader r_price;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
	}
}
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flpnlDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.tPnlCity = new System.Windows.Forms.TableLayoutPanel();
            this.tPnlStation = new System.Windows.Forms.TableLayoutPanel();
            this.tPnlSort = new System.Windows.Forms.TableLayoutPanel();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.pnlPlaneMenu.SuspendLayout();
            this.pnlWayToggle.SuspendLayout();
            this.flpnlDetail.SuspendLayout();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1054, 503);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(491, 252);
            this.textBox1.TabIndex = 6;
            // 
            // flpnlDetail
            // 
            this.flpnlDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpnlDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.flpnlDetail.Controls.Add(this.tPnlCity);
            this.flpnlDetail.Controls.Add(this.tPnlStation);
            this.flpnlDetail.Controls.Add(this.tPnlSort);
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
            this.tPnlSort.ColumnCount = 5;
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
            // calendar
            // 
            this.calendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calendar.Location = new System.Drawing.Point(900, 100);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 12;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // FormTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1729, 852);
            this.Controls.Add(this.flpnlDetail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.pnlPlaneMenu);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FormTrain";
            this.Text = "열차/지하철";
            this.Load += new System.EventHandler(this.FormTrain_Load);
            this.pnlPlaneMenu.ResumeLayout(false);
            this.pnlWayToggle.ResumeLayout(false);
            this.flpnlDetail.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flpnlDetail;
        private System.Windows.Forms.TableLayoutPanel tPnlCity;
        private System.Windows.Forms.TableLayoutPanel tPnlStation;
        private System.Windows.Forms.TableLayoutPanel tPnlSort;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Button btnSearch;
    }
}
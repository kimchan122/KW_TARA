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
            this.btnRSMenu_HeadCount = new System.Windows.Forms.Button();
            this.btnRSMenu_Destination = new System.Windows.Forms.Button();
            this.btnRSMenu_Departure = new System.Windows.Forms.Button();
            this.pnlWayToggle = new System.Windows.Forms.Panel();
            this.btnWayToggle_Single = new System.Windows.Forms.Button();
            this.btnWayToggle_RoundTrip = new System.Windows.Forms.Button();
            this.flpnlDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tmrPanelMove = new System.Windows.Forms.Timer(this.components);
            this.btnRSMenu_RSSearch = new System.Windows.Forms.Button();
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
            this.btnRSMenu_HeadCount.Text = "  인원";
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
            // flpnlDetail
            // 
            this.flpnlDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpnlDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.flpnlDetail.Controls.Add(this.btn1);
            this.flpnlDetail.Controls.Add(this.btn2);
            this.flpnlDetail.Controls.Add(this.dateTimePicker1);
            this.flpnlDetail.Controls.Add(this.dateTimePicker2);
            this.flpnlDetail.Font = new System.Drawing.Font("서울남산체 B", 13F, System.Drawing.FontStyle.Bold);
            this.flpnlDetail.ForeColor = System.Drawing.Color.White;
            this.flpnlDetail.Location = new System.Drawing.Point(175, 0);
            this.flpnlDetail.Margin = new System.Windows.Forms.Padding(0);
            this.flpnlDetail.MaximumSize = new System.Drawing.Size(350, 2400);
            this.flpnlDetail.MinimumSize = new System.Drawing.Size(0, 2400);
            this.flpnlDetail.Name = "flpnlDetail";
            this.flpnlDetail.Size = new System.Drawing.Size(350, 2400);
            this.flpnlDetail.TabIndex = 4;
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("서울남산체 B", 13F);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(3, 2);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(87, 56);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "서울";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddDeporArr);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("서울남산체 B", 13F);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(96, 2);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(87, 56);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "부산";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddDeporArr);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 28);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 30, 21, 56, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(169, 63);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(160, 28);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Value = new System.DateTime(2021, 5, 30, 21, 56, 0, 0);
            // 
            // tmrPanelMove
            // 
            this.tmrPanelMove.Enabled = true;
            this.tmrPanelMove.Interval = 15;
            this.tmrPanelMove.Tick += new System.EventHandler(this.tmrPanelMove_Tick);
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
            this.btnRSMenu_RSSearch.Text = "  경로 탐색";
            this.btnRSMenu_RSSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRSMenu_RSSearch.UseVisualStyleBackColor = true;
            this.btnRSMenu_RSSearch.Click += new System.EventHandler(this.btnRSMenu_RSSearch_Click);
            // 
            // FormRouteSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 347);
            this.Controls.Add(this.flpnlDetail);
            this.Controls.Add(this.pnlRSMenu);
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
        private System.Windows.Forms.Button btnRSMenu_Destination;
        private System.Windows.Forms.Button btnRSMenu_Departure;
        private System.Windows.Forms.Panel pnlWayToggle;
        private System.Windows.Forms.Button btnWayToggle_Single;
        private System.Windows.Forms.Button btnWayToggle_RoundTrip;
        private System.Windows.Forms.FlowLayoutPanel flpnlDetail;
        private System.Windows.Forms.Timer tmrPanelMove;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnRSMenu_RSSearch;
    }
}
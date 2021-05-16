namespace Project.Forms {
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
            this.pnlPlaneMenu = new System.Windows.Forms.Panel();
            this.btnPlaneMenu_SeatClass = new System.Windows.Forms.Button();
            this.btnPlaneMenu_HeadCount = new System.Windows.Forms.Button();
            this.btnPlaneMenu_Destination = new System.Windows.Forms.Button();
            this.btnPlaneMenu_Departure = new System.Windows.Forms.Button();
            this.pnlWayToggle = new System.Windows.Forms.Panel();
            this.btnWayToggle_Single = new System.Windows.Forms.Button();
            this.btnWayToggle_RoundTrip = new System.Windows.Forms.Button();
            this.flpnlDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrPanelMove = new System.Windows.Forms.Timer(this.components);
            this.pnlPlaneMenu.SuspendLayout();
            this.pnlWayToggle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlaneMenu
            // 
            this.pnlPlaneMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.pnlPlaneMenu.Controls.Add(this.btnPlaneMenu_SeatClass);
            this.pnlPlaneMenu.Controls.Add(this.btnPlaneMenu_HeadCount);
            this.pnlPlaneMenu.Controls.Add(this.btnPlaneMenu_Destination);
            this.pnlPlaneMenu.Controls.Add(this.btnPlaneMenu_Departure);
            this.pnlPlaneMenu.Controls.Add(this.pnlWayToggle);
            this.pnlPlaneMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlPlaneMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPlaneMenu.Name = "pnlPlaneMenu";
            this.pnlPlaneMenu.Size = new System.Drawing.Size(175, 2400);
            this.pnlPlaneMenu.TabIndex = 2;
            // 
            // btnPlaneMenu_SeatClass
            // 
            this.btnPlaneMenu_SeatClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaneMenu_SeatClass.FlatAppearance.BorderSize = 0;
            this.btnPlaneMenu_SeatClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaneMenu_SeatClass.Font = new System.Drawing.Font("서울남산체 B", 13F);
            this.btnPlaneMenu_SeatClass.ForeColor = System.Drawing.Color.White;
            this.btnPlaneMenu_SeatClass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaneMenu_SeatClass.Location = new System.Drawing.Point(0, 224);
            this.btnPlaneMenu_SeatClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlaneMenu_SeatClass.Name = "btnPlaneMenu_SeatClass";
            this.btnPlaneMenu_SeatClass.Size = new System.Drawing.Size(175, 56);
            this.btnPlaneMenu_SeatClass.TabIndex = 4;
            this.btnPlaneMenu_SeatClass.Text = "  좌석 등급";
            this.btnPlaneMenu_SeatClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaneMenu_SeatClass.UseVisualStyleBackColor = true;
            this.btnPlaneMenu_SeatClass.Click += new System.EventHandler(this.btnPlaneMenu_SeatClass_Click);
            // 
            // btnPlaneMenu_HeadCount
            // 
            this.btnPlaneMenu_HeadCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaneMenu_HeadCount.FlatAppearance.BorderSize = 0;
            this.btnPlaneMenu_HeadCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaneMenu_HeadCount.Font = new System.Drawing.Font("서울남산체 B", 13F);
            this.btnPlaneMenu_HeadCount.ForeColor = System.Drawing.Color.White;
            this.btnPlaneMenu_HeadCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaneMenu_HeadCount.Location = new System.Drawing.Point(0, 168);
            this.btnPlaneMenu_HeadCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlaneMenu_HeadCount.Name = "btnPlaneMenu_HeadCount";
            this.btnPlaneMenu_HeadCount.Size = new System.Drawing.Size(175, 56);
            this.btnPlaneMenu_HeadCount.TabIndex = 3;
            this.btnPlaneMenu_HeadCount.Text = "  인원";
            this.btnPlaneMenu_HeadCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaneMenu_HeadCount.UseVisualStyleBackColor = true;
            this.btnPlaneMenu_HeadCount.Click += new System.EventHandler(this.btnPlaneMenu_HeadCount_Click);
            // 
            // btnPlaneMenu_Destination
            // 
            this.btnPlaneMenu_Destination.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaneMenu_Destination.FlatAppearance.BorderSize = 0;
            this.btnPlaneMenu_Destination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaneMenu_Destination.Font = new System.Drawing.Font("서울남산체 B", 13F);
            this.btnPlaneMenu_Destination.ForeColor = System.Drawing.Color.White;
            this.btnPlaneMenu_Destination.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaneMenu_Destination.Location = new System.Drawing.Point(0, 112);
            this.btnPlaneMenu_Destination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlaneMenu_Destination.Name = "btnPlaneMenu_Destination";
            this.btnPlaneMenu_Destination.Size = new System.Drawing.Size(175, 56);
            this.btnPlaneMenu_Destination.TabIndex = 2;
            this.btnPlaneMenu_Destination.Text = "  도착지";
            this.btnPlaneMenu_Destination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaneMenu_Destination.UseVisualStyleBackColor = true;
            this.btnPlaneMenu_Destination.Click += new System.EventHandler(this.btnPlaneMenu_Destination_Click);
            // 
            // btnPlaneMenu_Departure
            // 
            this.btnPlaneMenu_Departure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaneMenu_Departure.FlatAppearance.BorderSize = 0;
            this.btnPlaneMenu_Departure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaneMenu_Departure.Font = new System.Drawing.Font("서울남산체 B", 13F);
            this.btnPlaneMenu_Departure.ForeColor = System.Drawing.Color.White;
            this.btnPlaneMenu_Departure.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaneMenu_Departure.Location = new System.Drawing.Point(0, 56);
            this.btnPlaneMenu_Departure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlaneMenu_Departure.Name = "btnPlaneMenu_Departure";
            this.btnPlaneMenu_Departure.Size = new System.Drawing.Size(175, 56);
            this.btnPlaneMenu_Departure.TabIndex = 1;
            this.btnPlaneMenu_Departure.Text = "  출발지";
            this.btnPlaneMenu_Departure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaneMenu_Departure.UseVisualStyleBackColor = true;
            this.btnPlaneMenu_Departure.Click += new System.EventHandler(this.btnPlaneMenu_Departure_Click);
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
            this.flpnlDetail.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnlDetail.Font = new System.Drawing.Font("서울남산체 B", 13F, System.Drawing.FontStyle.Bold);
            this.flpnlDetail.ForeColor = System.Drawing.Color.White;
            this.flpnlDetail.Location = new System.Drawing.Point(175, 0);
            this.flpnlDetail.Margin = new System.Windows.Forms.Padding(0);
            this.flpnlDetail.MaximumSize = new System.Drawing.Size(350, 2400);
            this.flpnlDetail.MinimumSize = new System.Drawing.Size(0, 2400);
            this.flpnlDetail.Name = "flpnlDetail";
            this.flpnlDetail.Size = new System.Drawing.Size(350, 2400);
            this.flpnlDetail.TabIndex = 3;
            // 
            // tmrPanelMove
            // 
            this.tmrPanelMove.Enabled = true;
            this.tmrPanelMove.Interval = 15;
            this.tmrPanelMove.Tick += new System.EventHandler(this.tmrPanelMove_Tick);
            // 
            // FormPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 385);
            this.Controls.Add(this.pnlPlaneMenu);
            this.Controls.Add(this.flpnlDetail);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPlane";
            this.Text = "항공편(국내선)";
            this.Load += new System.EventHandler(this.FormPlane_Load);
            this.pnlPlaneMenu.ResumeLayout(false);
            this.pnlWayToggle.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlPlaneMenu;
		private System.Windows.Forms.Button btnPlaneMenu_SeatClass;
		private System.Windows.Forms.Button btnPlaneMenu_HeadCount;
		private System.Windows.Forms.Button btnPlaneMenu_Destination;
		private System.Windows.Forms.Button btnPlaneMenu_Departure;
		private System.Windows.Forms.Panel pnlWayToggle;
		private System.Windows.Forms.Button btnWayToggle_Single;
		private System.Windows.Forms.Button btnWayToggle_RoundTrip;
		private System.Windows.Forms.FlowLayoutPanel flpnlDetail;
		private System.Windows.Forms.Timer tmrPanelMove;
	}
}
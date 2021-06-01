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
            this.btnTrainMenu_TrainSort = new System.Windows.Forms.Button();
            this.btnTrainMenu_Destination = new System.Windows.Forms.Button();
            this.btnTrainMenu_Departure = new System.Windows.Forms.Button();
            this.pnlWayToggle = new System.Windows.Forms.Panel();
            this.btnWayToggle_Single = new System.Windows.Forms.Button();
            this.btnWayToggle_RoundTrip = new System.Windows.Forms.Button();
            this.tmrPanelMove = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.flpnlDetail_station = new System.Windows.Forms.FlowLayoutPanel();
            this.flpnlDetail_sort = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPlaneMenu.SuspendLayout();
            this.pnlWayToggle.SuspendLayout();
            this.flpnlDetail_station.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlaneMenu
            // 
            this.pnlPlaneMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
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
            this.tmrPanelMove.Tick += new System.EventHandler(this.tmrPanelMove_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1470, 112);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 360);
            this.textBox1.TabIndex = 6;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(1444, 570);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(179, 70);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "조회";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // flpnlDetail_station
            // 
            this.flpnlDetail_station.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpnlDetail_station.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.flpnlDetail_station.Controls.Add(this.flpnlDetail_sort);
            this.flpnlDetail_station.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpnlDetail_station.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnlDetail_station.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.flpnlDetail_station.ForeColor = System.Drawing.Color.White;
            this.flpnlDetail_station.Location = new System.Drawing.Point(325, 0);
            this.flpnlDetail_station.Margin = new System.Windows.Forms.Padding(0);
            this.flpnlDetail_station.MaximumSize = new System.Drawing.Size(650, 4800);
            this.flpnlDetail_station.MinimumSize = new System.Drawing.Size(0, 4800);
            this.flpnlDetail_station.Name = "flpnlDetail_station";
            this.flpnlDetail_station.Size = new System.Drawing.Size(504, 4800);
            this.flpnlDetail_station.TabIndex = 9;
            // 
            // flpnlDetail_sort
            // 
            this.flpnlDetail_sort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpnlDetail_sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.flpnlDetail_sort.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpnlDetail_sort.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnlDetail_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.flpnlDetail_sort.ForeColor = System.Drawing.Color.White;
            this.flpnlDetail_sort.Location = new System.Drawing.Point(0, 0);
            this.flpnlDetail_sort.Margin = new System.Windows.Forms.Padding(0);
            this.flpnlDetail_sort.MaximumSize = new System.Drawing.Size(650, 4800);
            this.flpnlDetail_sort.MinimumSize = new System.Drawing.Size(0, 4800);
            this.flpnlDetail_sort.Name = "flpnlDetail_sort";
            this.flpnlDetail_sort.Size = new System.Drawing.Size(504, 4800);
            this.flpnlDetail_sort.TabIndex = 10;
            // 
            // FormTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1729, 852);
            this.Controls.Add(this.flpnlDetail_station);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnlPlaneMenu);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FormTrain";
            this.Text = "열차/지하철";
            this.Load += new System.EventHandler(this.FormTrain_Load);
            this.pnlPlaneMenu.ResumeLayout(false);
            this.pnlWayToggle.ResumeLayout(false);
            this.flpnlDetail_station.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.FlowLayoutPanel flpnlDetail_station;
        private System.Windows.Forms.FlowLayoutPanel flpnlDetail_sort;
    }
}
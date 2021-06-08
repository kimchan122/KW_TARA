namespace Project {
	partial class FormMainMenu {
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
			this.pnlMenu = new System.Windows.Forms.Panel();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnRouteSearch = new System.Windows.Forms.Button();
			this.btnPlane = new System.Windows.Forms.Button();
			this.btnBus = new System.Windows.Forms.Button();
			this.btnTrain = new System.Windows.Forms.Button();
			this.pnlLogo = new System.Windows.Forms.Panel();
			this.lblLogo = new System.Windows.Forms.Label();
			this.pnlTitleBar = new System.Windows.Forms.Panel();
			this.btnMaximize = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnGoHome = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlDesktopPanel = new System.Windows.Forms.Panel();
			this.pnlMenu.SuspendLayout();
			this.pnlLogo.SuspendLayout();
			this.pnlTitleBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMenu
			// 
			this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.pnlMenu.Controls.Add(this.btnSettings);
			this.pnlMenu.Controls.Add(this.btnRouteSearch);
			this.pnlMenu.Controls.Add(this.btnPlane);
			this.pnlMenu.Controls.Add(this.btnBus);
			this.pnlMenu.Controls.Add(this.btnTrain);
			this.pnlMenu.Controls.Add(this.pnlLogo);
			this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlMenu.Location = new System.Drawing.Point(0, 0);
			this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlMenu.Name = "pnlMenu";
			this.pnlMenu.Size = new System.Drawing.Size(270, 582);
			this.pnlMenu.TabIndex = 0;
			// 
			// btnSettings
			// 
			this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSettings.FlatAppearance.BorderSize = 0;
			this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSettings.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.btnSettings.ForeColor = System.Drawing.Color.White;
			this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
			this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSettings.Location = new System.Drawing.Point(0, 460);
			this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnSettings.Size = new System.Drawing.Size(270, 90);
			this.btnSettings.TabIndex = 5;
			this.btnSettings.Text = "설정         ";
			this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// btnRouteSearch
			// 
			this.btnRouteSearch.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnRouteSearch.FlatAppearance.BorderSize = 0;
			this.btnRouteSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRouteSearch.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.btnRouteSearch.ForeColor = System.Drawing.Color.White;
			this.btnRouteSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnRouteSearch.Image")));
			this.btnRouteSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRouteSearch.Location = new System.Drawing.Point(0, 370);
			this.btnRouteSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRouteSearch.Name = "btnRouteSearch";
			this.btnRouteSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnRouteSearch.Size = new System.Drawing.Size(270, 90);
			this.btnRouteSearch.TabIndex = 4;
			this.btnRouteSearch.Text = "통합경로검색   ";
			this.btnRouteSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRouteSearch.UseVisualStyleBackColor = true;
			this.btnRouteSearch.Click += new System.EventHandler(this.btnRouteSearch_Click);
			// 
			// btnPlane
			// 
			this.btnPlane.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPlane.FlatAppearance.BorderSize = 0;
			this.btnPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlane.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.btnPlane.ForeColor = System.Drawing.Color.White;
			this.btnPlane.Image = ((System.Drawing.Image)(resources.GetObject("btnPlane.Image")));
			this.btnPlane.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPlane.Location = new System.Drawing.Point(0, 280);
			this.btnPlane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPlane.Name = "btnPlane";
			this.btnPlane.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnPlane.Size = new System.Drawing.Size(270, 90);
			this.btnPlane.TabIndex = 3;
			this.btnPlane.Text = "항공편(국내선) ";
			this.btnPlane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPlane.UseVisualStyleBackColor = true;
			this.btnPlane.Click += new System.EventHandler(this.btnPlane_Click);
			// 
			// btnBus
			// 
			this.btnBus.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnBus.FlatAppearance.BorderSize = 0;
			this.btnBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBus.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.btnBus.ForeColor = System.Drawing.Color.White;
			this.btnBus.Image = ((System.Drawing.Image)(resources.GetObject("btnBus.Image")));
			this.btnBus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBus.Location = new System.Drawing.Point(0, 190);
			this.btnBus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBus.Name = "btnBus";
			this.btnBus.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnBus.Size = new System.Drawing.Size(270, 90);
			this.btnBus.TabIndex = 2;
			this.btnBus.Text = "고속/일반버스  ";
			this.btnBus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBus.UseVisualStyleBackColor = true;
			this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
			// 
			// btnTrain
			// 
			this.btnTrain.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTrain.FlatAppearance.BorderSize = 0;
			this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTrain.Font = new System.Drawing.Font("서울남산체 B", 13F);
			this.btnTrain.ForeColor = System.Drawing.Color.White;
			this.btnTrain.Image = ((System.Drawing.Image)(resources.GetObject("btnTrain.Image")));
			this.btnTrain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTrain.Location = new System.Drawing.Point(0, 100);
			this.btnTrain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnTrain.Name = "btnTrain";
			this.btnTrain.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnTrain.Size = new System.Drawing.Size(270, 90);
			this.btnTrain.TabIndex = 1;
			this.btnTrain.Text = "열차/지하철    ";
			this.btnTrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTrain.UseVisualStyleBackColor = true;
			this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
			// 
			// pnlLogo
			// 
			this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.pnlLogo.Controls.Add(this.lblLogo);
			this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlLogo.Location = new System.Drawing.Point(0, 0);
			this.pnlLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlLogo.Name = "pnlLogo";
			this.pnlLogo.Size = new System.Drawing.Size(270, 100);
			this.pnlLogo.TabIndex = 0;
			// 
			// lblLogo
			// 
			this.lblLogo.AutoSize = true;
			this.lblLogo.Font = new System.Drawing.Font("서울남산체 B", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblLogo.ForeColor = System.Drawing.Color.White;
			this.lblLogo.Location = new System.Drawing.Point(25, 35);
			this.lblLogo.Name = "lblLogo";
			this.lblLogo.Size = new System.Drawing.Size(218, 33);
			this.lblLogo.TabIndex = 0;
			this.lblLogo.Text = "TARA Project";
			// 
			// pnlTitleBar
			// 
			this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
			this.pnlTitleBar.Controls.Add(this.btnMaximize);
			this.pnlTitleBar.Controls.Add(this.btnClose);
			this.pnlTitleBar.Controls.Add(this.btnMinimize);
			this.pnlTitleBar.Controls.Add(this.btnGoHome);
			this.pnlTitleBar.Controls.Add(this.lblTitle);
			this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitleBar.Location = new System.Drawing.Point(270, 0);
			this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlTitleBar.Name = "pnlTitleBar";
			this.pnlTitleBar.Size = new System.Drawing.Size(805, 100);
			this.pnlTitleBar.TabIndex = 1;
			this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
			// 
			// btnMaximize
			// 
			this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMaximize.FlatAppearance.BorderSize = 0;
			this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnMaximize.Location = new System.Drawing.Point(734, -5);
			this.btnMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Size = new System.Drawing.Size(35, 40);
			this.btnMaximize.TabIndex = 4;
			this.btnMaximize.Text = "ㅇ";
			this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMaximize.UseVisualStyleBackColor = true;
			this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnClose.Location = new System.Drawing.Point(772, -5);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(35, 40);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "ㅇ";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
			this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnMinimize.Location = new System.Drawing.Point(696, -5);
			this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(35, 40);
			this.btnMinimize.TabIndex = 2;
			this.btnMinimize.Text = "ㅇ";
			this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// btnGoHome
			// 
			this.btnGoHome.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnGoHome.FlatAppearance.BorderSize = 0;
			this.btnGoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGoHome.Image = ((System.Drawing.Image)(resources.GetObject("btnGoHome.Image")));
			this.btnGoHome.Location = new System.Drawing.Point(0, 0);
			this.btnGoHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGoHome.Name = "btnGoHome";
			this.btnGoHome.Size = new System.Drawing.Size(101, 100);
			this.btnGoHome.TabIndex = 1;
			this.btnGoHome.UseVisualStyleBackColor = true;
			this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("서울남산체 B", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(105, 35);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(432, 33);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "한눈에 보는 교통수단, TARA!";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlDesktopPanel
			// 
			this.pnlDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDesktopPanel.Location = new System.Drawing.Point(270, 100);
			this.pnlDesktopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlDesktopPanel.Name = "pnlDesktopPanel";
			this.pnlDesktopPanel.Size = new System.Drawing.Size(805, 482);
			this.pnlDesktopPanel.TabIndex = 2;
			// 
			// FormMainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1075, 582);
			this.Controls.Add(this.pnlDesktopPanel);
			this.Controls.Add(this.pnlTitleBar);
			this.Controls.Add(this.pnlMenu);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormMainMenu";
			this.Text = "Form1";
			this.pnlMenu.ResumeLayout(false);
			this.pnlLogo.ResumeLayout(false);
			this.pnlLogo.PerformLayout();
			this.pnlTitleBar.ResumeLayout(false);
			this.pnlTitleBar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlMenu;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Button btnRouteSearch;
		private System.Windows.Forms.Button btnPlane;
		private System.Windows.Forms.Button btnBus;
		private System.Windows.Forms.Button btnTrain;
		private System.Windows.Forms.Panel pnlLogo;
		private System.Windows.Forms.Panel pnlTitleBar;
		private System.Windows.Forms.Panel pnlDesktopPanel;
		private System.Windows.Forms.Label lblLogo;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnGoHome;
		private System.Windows.Forms.Button btnMaximize;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnMinimize;
	}
}


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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grbStorTr = new System.Windows.Forms.GroupBox();
            this.rdoTransfer = new System.Windows.Forms.RadioButton();
            this.rdoStraight = new System.Windows.Forms.RadioButton();
            this.txtEndloc = new System.Windows.Forms.TextBox();
            this.txtStartloc = new System.Windows.Forms.TextBox();
            this.btnEndloc = new System.Windows.Forms.Button();
            this.btnStartloc = new System.Windows.Forms.Button();
            this.grbStorTr.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-169, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "출발지";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-156, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "선택";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grbStorTr
            // 
            this.grbStorTr.Controls.Add(this.rdoTransfer);
            this.grbStorTr.Controls.Add(this.rdoStraight);
            this.grbStorTr.Location = new System.Drawing.Point(397, 12);
            this.grbStorTr.Name = "grbStorTr";
            this.grbStorTr.Size = new System.Drawing.Size(200, 69);
            this.grbStorTr.TabIndex = 12;
            this.grbStorTr.TabStop = false;
            this.grbStorTr.Text = "이동구분";
            // 
            // rdoTransfer
            // 
            this.rdoTransfer.AutoSize = true;
            this.rdoTransfer.Location = new System.Drawing.Point(7, 44);
            this.rdoTransfer.Name = "rdoTransfer";
            this.rdoTransfer.Size = new System.Drawing.Size(47, 16);
            this.rdoTransfer.TabIndex = 1;
            this.rdoTransfer.TabStop = true;
            this.rdoTransfer.Text = "환승";
            this.rdoTransfer.UseVisualStyleBackColor = true;
            // 
            // rdoStraight
            // 
            this.rdoStraight.AutoSize = true;
            this.rdoStraight.Location = new System.Drawing.Point(7, 21);
            this.rdoStraight.Name = "rdoStraight";
            this.rdoStraight.Size = new System.Drawing.Size(47, 16);
            this.rdoStraight.TabIndex = 0;
            this.rdoStraight.TabStop = true;
            this.rdoStraight.Text = "직통";
            this.rdoStraight.UseVisualStyleBackColor = true;
            // 
            // txtEndloc
            // 
            this.txtEndloc.Location = new System.Drawing.Point(196, 12);
            this.txtEndloc.Name = "txtEndloc";
            this.txtEndloc.Size = new System.Drawing.Size(100, 21);
            this.txtEndloc.TabIndex = 11;
            this.txtEndloc.Text = "도착지";
            this.txtEndloc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartloc
            // 
            this.txtStartloc.Location = new System.Drawing.Point(13, 12);
            this.txtStartloc.Name = "txtStartloc";
            this.txtStartloc.Size = new System.Drawing.Size(100, 21);
            this.txtStartloc.TabIndex = 10;
            this.txtStartloc.Text = "출발지";
            this.txtStartloc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEndloc
            // 
            this.btnEndloc.Location = new System.Drawing.Point(209, 50);
            this.btnEndloc.Name = "btnEndloc";
            this.btnEndloc.Size = new System.Drawing.Size(75, 23);
            this.btnEndloc.TabIndex = 9;
            this.btnEndloc.Text = "선택";
            this.btnEndloc.UseVisualStyleBackColor = true;
            // 
            // btnStartloc
            // 
            this.btnStartloc.Location = new System.Drawing.Point(26, 50);
            this.btnStartloc.Name = "btnStartloc";
            this.btnStartloc.Size = new System.Drawing.Size(75, 23);
            this.btnStartloc.TabIndex = 8;
            this.btnStartloc.Text = "선택";
            this.btnStartloc.UseVisualStyleBackColor = true;
            // 
            // FormRouteSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 347);
            this.Controls.Add(this.grbStorTr);
            this.Controls.Add(this.txtEndloc);
            this.Controls.Add(this.txtStartloc);
            this.Controls.Add(this.btnEndloc);
            this.Controls.Add(this.btnStartloc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRouteSearch";
            this.Text = "통합경로검색";
            this.grbStorTr.ResumeLayout(false);
            this.grbStorTr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbStorTr;
        private System.Windows.Forms.RadioButton rdoTransfer;
        private System.Windows.Forms.RadioButton rdoStraight;
        private System.Windows.Forms.TextBox txtEndloc;
        private System.Windows.Forms.TextBox txtStartloc;
        private System.Windows.Forms.Button btnEndloc;
        private System.Windows.Forms.Button btnStartloc;
    }
}
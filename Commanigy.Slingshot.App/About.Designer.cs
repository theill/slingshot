namespace Commanigy.Slingshot.App {
	partial class About {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.LblAppName = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.PnlHorizontalLine = new System.Windows.Forms.Panel();
			this.LblVersion = new System.Windows.Forms.Label();
			this.BtnOk = new System.Windows.Forms.Button();
			this.LnkPreferences = new System.Windows.Forms.LinkLabel();
			this.LnkCopyright = new System.Windows.Forms.LinkLabel();
			this.LnkGettingStarted = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Commanigy.Slingshot.App.Properties.Resources._1269548545_redhat_internet;
			this.pictureBox1.Location = new System.Drawing.Point(-12, 19);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 128);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// LblAppName
			// 
			this.LblAppName.AutoSize = true;
			this.LblAppName.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblAppName.Location = new System.Drawing.Point(140, 19);
			this.LblAppName.Margin = new System.Windows.Forms.Padding(0);
			this.LblAppName.Name = "LblAppName";
			this.LblAppName.Size = new System.Drawing.Size(141, 32);
			this.LblAppName.TabIndex = 2;
			this.LblAppName.Text = "Slingshot";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.PnlHorizontalLine);
			this.panel1.Controls.Add(this.LblVersion);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.LblAppName);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(474, 100);
			this.panel1.TabIndex = 3;
			// 
			// PnlHorizontalLine
			// 
			this.PnlHorizontalLine.BackColor = System.Drawing.SystemColors.ControlDark;
			this.PnlHorizontalLine.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PnlHorizontalLine.Location = new System.Drawing.Point(0, 99);
			this.PnlHorizontalLine.Margin = new System.Windows.Forms.Padding(0);
			this.PnlHorizontalLine.Name = "PnlHorizontalLine";
			this.PnlHorizontalLine.Size = new System.Drawing.Size(474, 1);
			this.PnlHorizontalLine.TabIndex = 4;
			// 
			// LblVersion
			// 
			this.LblVersion.AutoSize = true;
			this.LblVersion.Location = new System.Drawing.Point(143, 51);
			this.LblVersion.Margin = new System.Windows.Forms.Padding(0);
			this.LblVersion.Name = "LblVersion";
			this.LblVersion.Size = new System.Drawing.Size(43, 13);
			this.LblVersion.TabIndex = 3;
			this.LblVersion.Text = "1.0.0.0";
			// 
			// BtnOk
			// 
			this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOk.Location = new System.Drawing.Point(390, 204);
			this.BtnOk.Margin = new System.Windows.Forms.Padding(0);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(75, 23);
			this.BtnOk.TabIndex = 0;
			this.BtnOk.Text = "OK";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// LnkPreferences
			// 
			this.LnkPreferences.AutoSize = true;
			this.LnkPreferences.LinkArea = new System.Windows.Forms.LinkArea(5, 11);
			this.LnkPreferences.Location = new System.Drawing.Point(9, 209);
			this.LnkPreferences.Margin = new System.Windows.Forms.Padding(0);
			this.LnkPreferences.Name = "LnkPreferences";
			this.LnkPreferences.Size = new System.Drawing.Size(212, 18);
			this.LnkPreferences.TabIndex = 6;
			this.LnkPreferences.TabStop = true;
			this.LnkPreferences.Text = "Open Preferences to modify your settings";
			this.LnkPreferences.UseCompatibleTextRendering = true;
			this.LnkPreferences.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkPreferences_LinkClicked);
			// 
			// LnkCopyright
			// 
			this.LnkCopyright.AutoSize = true;
			this.LnkCopyright.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.LnkCopyright.LinkArea = new System.Windows.Forms.LinkArea(22, 9);
			this.LnkCopyright.Location = new System.Drawing.Point(10, 113);
			this.LnkCopyright.Margin = new System.Windows.Forms.Padding(0);
			this.LnkCopyright.Name = "LnkCopyright";
			this.LnkCopyright.Size = new System.Drawing.Size(292, 18);
			this.LnkCopyright.TabIndex = 7;
			this.LnkCopyright.TabStop = true;
			this.LnkCopyright.Text = "Copyright © 2008-2010 Commanigy. All Rights Reserved.";
			this.LnkCopyright.UseCompatibleTextRendering = true;
			this.LnkCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkCopyright_LinkClicked);
			// 
			// LnkGettingStarted
			// 
			this.LnkGettingStarted.AutoSize = true;
			this.LnkGettingStarted.LinkArea = new System.Windows.Forms.LinkArea(9, 15);
			this.LnkGettingStarted.Location = new System.Drawing.Point(9, 147);
			this.LnkGettingStarted.Margin = new System.Windows.Forms.Padding(0);
			this.LnkGettingStarted.Name = "LnkGettingStarted";
			this.LnkGettingStarted.Size = new System.Drawing.Size(243, 18);
			this.LnkGettingStarted.TabIndex = 8;
			this.LnkGettingStarted.TabStop = true;
			this.LnkGettingStarted.Text = "Read our Getting Started guide for tips && tricks.";
			this.LnkGettingStarted.UseCompatibleTextRendering = true;
			this.LnkGettingStarted.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkGettingStarted_LinkClicked);
			// 
			// About
			// 
			this.AcceptButton = this.BtnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 236);
			this.Controls.Add(this.LnkGettingStarted);
			this.Controls.Add(this.LnkCopyright);
			this.Controls.Add(this.LnkPreferences);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "About Slingshot";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label LblAppName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.Panel PnlHorizontalLine;
		private System.Windows.Forms.Label LblVersion;
		private System.Windows.Forms.LinkLabel LnkPreferences;
		private System.Windows.Forms.LinkLabel LnkCopyright;
		private System.Windows.Forms.LinkLabel LnkGettingStarted;
	}
}
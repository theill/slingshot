namespace Commanigy.Slingshot.App {
	partial class Published {
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BtnCopyToClipboard = new System.Windows.Forms.Button();
			this.TbxPublicSiteUrl = new System.Windows.Forms.TextBox();
			this.PnlHeader = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.LblLinkCopied = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.PnlHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Commanigy.Slingshot.App.Properties.Resources._1269546704_ark;
			this.pictureBox1.Location = new System.Drawing.Point(-49, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 128);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// BtnCopyToClipboard
			// 
			this.BtnCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCopyToClipboard.AutoSize = true;
			this.BtnCopyToClipboard.Location = new System.Drawing.Point(418, 114);
			this.BtnCopyToClipboard.Name = "BtnCopyToClipboard";
			this.BtnCopyToClipboard.Size = new System.Drawing.Size(105, 23);
			this.BtnCopyToClipboard.TabIndex = 4;
			this.BtnCopyToClipboard.Text = "Copy To Clipboard";
			this.BtnCopyToClipboard.UseVisualStyleBackColor = true;
			this.BtnCopyToClipboard.Click += new System.EventHandler(this.BtnCopyToClipboard_Click);
			// 
			// TbxPublicSiteUrl
			// 
			this.TbxPublicSiteUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TbxPublicSiteUrl.BackColor = System.Drawing.SystemColors.Control;
			this.TbxPublicSiteUrl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TbxPublicSiteUrl.Location = new System.Drawing.Point(93, 45);
			this.TbxPublicSiteUrl.Name = "TbxPublicSiteUrl";
			this.TbxPublicSiteUrl.ReadOnly = true;
			this.TbxPublicSiteUrl.Size = new System.Drawing.Size(430, 35);
			this.TbxPublicSiteUrl.TabIndex = 5;
			this.TbxPublicSiteUrl.Text = "http://goo.gl/xyzo";
			// 
			// PnlHeader
			// 
			this.PnlHeader.BackColor = System.Drawing.Color.White;
			this.PnlHeader.Controls.Add(this.label1);
			this.PnlHeader.Controls.Add(this.TbxPublicSiteUrl);
			this.PnlHeader.Controls.Add(this.panel2);
			this.PnlHeader.Controls.Add(this.pictureBox1);
			this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlHeader.Location = new System.Drawing.Point(0, 0);
			this.PnlHeader.Name = "PnlHeader";
			this.PnlHeader.Size = new System.Drawing.Size(543, 100);
			this.PnlHeader.TabIndex = 6;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 99);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(543, 1);
			this.panel2.TabIndex = 3;
			// 
			// LblLinkCopied
			// 
			this.LblLinkCopied.AutoSize = true;
			this.LblLinkCopied.Location = new System.Drawing.Point(12, 119);
			this.LblLinkCopied.Name = "LblLinkCopied";
			this.LblLinkCopied.Size = new System.Drawing.Size(332, 13);
			this.LblLinkCopied.TabIndex = 7;
			this.LblLinkCopied.Text = "The link has been copied to your clipboard. Paste it by using Ctrl+V.";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(90, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(286, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Your file has been uploaded and is available for download.";
			// 
			// Published
			// 
			this.AcceptButton = this.BtnCopyToClipboard;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 149);
			this.Controls.Add(this.LblLinkCopied);
			this.Controls.Add(this.PnlHeader);
			this.Controls.Add(this.BtnCopyToClipboard);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Published";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Slingshot Public Address";
			this.TopMost = true;
			this.Shown += new System.EventHandler(this.Published_Shown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.PnlHeader.ResumeLayout(false);
			this.PnlHeader.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button BtnCopyToClipboard;
		private System.Windows.Forms.TextBox TbxPublicSiteUrl;
		private System.Windows.Forms.Panel PnlHeader;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label LblLinkCopied;
		private System.Windows.Forms.Label label1;
	}
}
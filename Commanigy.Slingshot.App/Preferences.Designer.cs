namespace Commanigy.Slingshot.App {
	partial class Preferences {
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
			this.BtnOK = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.TcPreferences = new System.Windows.Forms.TabControl();
			this.TpGeneral = new System.Windows.Forms.TabPage();
			this.GbWindowsIntegration = new System.Windows.Forms.GroupBox();
			this.CbCopyLinkToClipboard = new System.Windows.Forms.CheckBox();
			this.TpFtp = new System.Windows.Forms.TabPage();
			this.LnkCustomizePublicSiteUrl = new System.Windows.Forms.LinkLabel();
			this.PnlMissingConfiguration = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.LblMissingConfiguration = new System.Windows.Forms.Label();
			this.LblSiteConfigurationHeader = new System.Windows.Forms.Label();
			this.PnlSiteConfigurationHeader = new System.Windows.Forms.Panel();
			this.LblPort = new System.Windows.Forms.Label();
			this.LblFtpConfiguration = new System.Windows.Forms.Label();
			this.LblFileName = new System.Windows.Forms.Label();
			this.LblPublicSite = new System.Windows.Forms.Label();
			this.LblFtpUserName = new System.Windows.Forms.Label();
			this.PnlFtpConfigurationHeader = new System.Windows.Forms.Panel();
			this.LblFtpHost = new System.Windows.Forms.Label();
			this.TbxPassword = new System.Windows.Forms.TextBox();
			this.LblFtpPassword = new System.Windows.Forms.Label();
			this.LblFtpPath = new System.Windows.Forms.Label();
			this.TbxFtpPort = new System.Windows.Forms.TextBox();
			this.TbxPublicSite = new System.Windows.Forms.TextBox();
			this.TbxFtpFileName = new System.Windows.Forms.TextBox();
			this.TbxFtpHost = new System.Windows.Forms.TextBox();
			this.TbxPath = new System.Windows.Forms.TextBox();
			this.TbxUserName = new System.Windows.Forms.TextBox();
			this.CbShortenLinks = new System.Windows.Forms.CheckBox();
			this.TcPreferences.SuspendLayout();
			this.TpGeneral.SuspendLayout();
			this.GbWindowsIntegration.SuspendLayout();
			this.TpFtp.SuspendLayout();
			this.PnlMissingConfiguration.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnOK
			// 
			this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.BtnOK.Location = new System.Drawing.Point(227, 402);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(75, 23);
			this.BtnOK.TabIndex = 1;
			this.BtnOK.Text = "OK";
			this.BtnOK.UseVisualStyleBackColor = true;
			this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnCancel.Location = new System.Drawing.Point(307, 402);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(75, 23);
			this.BtnCancel.TabIndex = 2;
			this.BtnCancel.Text = "Cancel";
			this.BtnCancel.UseVisualStyleBackColor = true;
			// 
			// TcPreferences
			// 
			this.TcPreferences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TcPreferences.Controls.Add(this.TpGeneral);
			this.TcPreferences.Controls.Add(this.TpFtp);
			this.TcPreferences.Location = new System.Drawing.Point(12, 12);
			this.TcPreferences.Name = "TcPreferences";
			this.TcPreferences.SelectedIndex = 0;
			this.TcPreferences.Size = new System.Drawing.Size(370, 384);
			this.TcPreferences.TabIndex = 0;
			// 
			// TpGeneral
			// 
			this.TpGeneral.Controls.Add(this.GbWindowsIntegration);
			this.TpGeneral.Location = new System.Drawing.Point(4, 22);
			this.TpGeneral.Name = "TpGeneral";
			this.TpGeneral.Padding = new System.Windows.Forms.Padding(8);
			this.TpGeneral.Size = new System.Drawing.Size(362, 358);
			this.TpGeneral.TabIndex = 0;
			this.TpGeneral.Text = "General";
			this.TpGeneral.UseVisualStyleBackColor = true;
			// 
			// GbWindowsIntegration
			// 
			this.GbWindowsIntegration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.GbWindowsIntegration.Controls.Add(this.CbShortenLinks);
			this.GbWindowsIntegration.Controls.Add(this.CbCopyLinkToClipboard);
			this.GbWindowsIntegration.Location = new System.Drawing.Point(11, 11);
			this.GbWindowsIntegration.Name = "GbWindowsIntegration";
			this.GbWindowsIntegration.Size = new System.Drawing.Size(340, 104);
			this.GbWindowsIntegration.TabIndex = 0;
			this.GbWindowsIntegration.TabStop = false;
			this.GbWindowsIntegration.Text = " Integration with Windows ";
			// 
			// CbCopyLinkToClipboard
			// 
			this.CbCopyLinkToClipboard.AutoSize = true;
			this.CbCopyLinkToClipboard.Checked = global::Commanigy.Slingshot.App.Properties.Settings.Default.CopyLinkToClipboard;
			this.CbCopyLinkToClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CbCopyLinkToClipboard.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Commanigy.Slingshot.App.Properties.Settings.Default, "CopyLinkToClipboard", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.CbCopyLinkToClipboard.Location = new System.Drawing.Point(16, 48);
			this.CbCopyLinkToClipboard.Name = "CbCopyLinkToClipboard";
			this.CbCopyLinkToClipboard.Size = new System.Drawing.Size(194, 17);
			this.CbCopyLinkToClipboard.TabIndex = 1;
			this.CbCopyLinkToClipboard.Text = "Copy link to clipboard automatically";
			this.CbCopyLinkToClipboard.UseVisualStyleBackColor = true;
			// 
			// TpFtp
			// 
			this.TpFtp.Controls.Add(this.LnkCustomizePublicSiteUrl);
			this.TpFtp.Controls.Add(this.PnlMissingConfiguration);
			this.TpFtp.Controls.Add(this.LblSiteConfigurationHeader);
			this.TpFtp.Controls.Add(this.PnlSiteConfigurationHeader);
			this.TpFtp.Controls.Add(this.LblPort);
			this.TpFtp.Controls.Add(this.LblFtpConfiguration);
			this.TpFtp.Controls.Add(this.LblFileName);
			this.TpFtp.Controls.Add(this.LblPublicSite);
			this.TpFtp.Controls.Add(this.LblFtpUserName);
			this.TpFtp.Controls.Add(this.PnlFtpConfigurationHeader);
			this.TpFtp.Controls.Add(this.LblFtpHost);
			this.TpFtp.Controls.Add(this.TbxPassword);
			this.TpFtp.Controls.Add(this.LblFtpPassword);
			this.TpFtp.Controls.Add(this.LblFtpPath);
			this.TpFtp.Controls.Add(this.TbxFtpPort);
			this.TpFtp.Controls.Add(this.TbxPublicSite);
			this.TpFtp.Controls.Add(this.TbxFtpFileName);
			this.TpFtp.Controls.Add(this.TbxFtpHost);
			this.TpFtp.Controls.Add(this.TbxPath);
			this.TpFtp.Controls.Add(this.TbxUserName);
			this.TpFtp.Location = new System.Drawing.Point(4, 22);
			this.TpFtp.Name = "TpFtp";
			this.TpFtp.Padding = new System.Windows.Forms.Padding(3);
			this.TpFtp.Size = new System.Drawing.Size(362, 358);
			this.TpFtp.TabIndex = 1;
			this.TpFtp.Text = "Storage";
			this.TpFtp.UseVisualStyleBackColor = true;
			// 
			// LnkCustomizePublicSiteUrl
			// 
			this.LnkCustomizePublicSiteUrl.AutoSize = true;
			this.LnkCustomizePublicSiteUrl.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LnkCustomizePublicSiteUrl.Location = new System.Drawing.Point(106, 237);
			this.LnkCustomizePublicSiteUrl.Name = "LnkCustomizePublicSiteUrl";
			this.LnkCustomizePublicSiteUrl.Size = new System.Drawing.Size(147, 12);
			this.LnkCustomizePublicSiteUrl.TabIndex = 7;
			this.LnkCustomizePublicSiteUrl.TabStop = true;
			this.LnkCustomizePublicSiteUrl.Text = "I need to customize this address";
			this.LnkCustomizePublicSiteUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkCustomizePublicSiteUrl_LinkClicked);
			// 
			// PnlMissingConfiguration
			// 
			this.PnlMissingConfiguration.BackColor = System.Drawing.SystemColors.Info;
			this.PnlMissingConfiguration.Controls.Add(this.pictureBox1);
			this.PnlMissingConfiguration.Controls.Add(this.LblMissingConfiguration);
			this.PnlMissingConfiguration.Location = new System.Drawing.Point(6, 262);
			this.PnlMissingConfiguration.Name = "PnlMissingConfiguration";
			this.PnlMissingConfiguration.Padding = new System.Windows.Forms.Padding(10);
			this.PnlMissingConfiguration.Size = new System.Drawing.Size(350, 90);
			this.PnlMissingConfiguration.TabIndex = 34;
			this.PnlMissingConfiguration.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Commanigy.Slingshot.App.Properties.Resources.exclamation_diamond_frame;
			this.pictureBox1.Location = new System.Drawing.Point(10, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 16);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 35;
			this.pictureBox1.TabStop = false;
			// 
			// LblMissingConfiguration
			// 
			this.LblMissingConfiguration.ForeColor = System.Drawing.SystemColors.InfoText;
			this.LblMissingConfiguration.Location = new System.Drawing.Point(32, 10);
			this.LblMissingConfiguration.Name = "LblMissingConfiguration";
			this.LblMissingConfiguration.Size = new System.Drawing.Size(305, 70);
			this.LblMissingConfiguration.TabIndex = 0;
			this.LblMissingConfiguration.Text = "You need to configure your FTP server in order to upload files. Your public site " +
				"URL is required in order to access your uploaded file from a browser.";
			// 
			// LblSiteConfigurationHeader
			// 
			this.LblSiteConfigurationHeader.AutoSize = true;
			this.LblSiteConfigurationHeader.Location = new System.Drawing.Point(9, 191);
			this.LblSiteConfigurationHeader.Name = "LblSiteConfigurationHeader";
			this.LblSiteConfigurationHeader.Size = new System.Drawing.Size(123, 13);
			this.LblSiteConfigurationHeader.TabIndex = 29;
			this.LblSiteConfigurationHeader.Text = "Public Site Configuration";
			// 
			// PnlSiteConfigurationHeader
			// 
			this.PnlSiteConfigurationHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.PnlSiteConfigurationHeader.BackColor = System.Drawing.SystemColors.ControlDark;
			this.PnlSiteConfigurationHeader.Location = new System.Drawing.Point(13, 198);
			this.PnlSiteConfigurationHeader.Name = "PnlSiteConfigurationHeader";
			this.PnlSiteConfigurationHeader.Size = new System.Drawing.Size(334, 1);
			this.PnlSiteConfigurationHeader.TabIndex = 33;
			// 
			// LblPort
			// 
			this.LblPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LblPort.AutoSize = true;
			this.LblPort.Location = new System.Drawing.Point(261, 37);
			this.LblPort.Name = "LblPort";
			this.LblPort.Size = new System.Drawing.Size(31, 13);
			this.LblPort.TabIndex = 19;
			this.LblPort.Text = "Port:";
			// 
			// LblFtpConfiguration
			// 
			this.LblFtpConfiguration.AutoSize = true;
			this.LblFtpConfiguration.Location = new System.Drawing.Point(10, 11);
			this.LblFtpConfiguration.Name = "LblFtpConfiguration";
			this.LblFtpConfiguration.Size = new System.Drawing.Size(128, 13);
			this.LblFtpConfiguration.TabIndex = 0;
			this.LblFtpConfiguration.Text = "FTP Server Configuration";
			// 
			// LblFileName
			// 
			this.LblFileName.AutoSize = true;
			this.LblFileName.Location = new System.Drawing.Point(19, 90);
			this.LblFileName.Name = "LblFileName";
			this.LblFileName.Size = new System.Drawing.Size(53, 13);
			this.LblFileName.TabIndex = 23;
			this.LblFileName.Text = "Filename:";
			// 
			// LblPublicSite
			// 
			this.LblPublicSite.AutoSize = true;
			this.LblPublicSite.Location = new System.Drawing.Point(19, 216);
			this.LblPublicSite.Name = "LblPublicSite";
			this.LblPublicSite.Size = new System.Drawing.Size(50, 13);
			this.LblPublicSite.TabIndex = 31;
			this.LblPublicSite.Text = "Address:";
			// 
			// LblFtpUserName
			// 
			this.LblFtpUserName.AutoSize = true;
			this.LblFtpUserName.Location = new System.Drawing.Point(19, 117);
			this.LblFtpUserName.Name = "LblFtpUserName";
			this.LblFtpUserName.Size = new System.Drawing.Size(59, 13);
			this.LblFtpUserName.TabIndex = 25;
			this.LblFtpUserName.Text = "Username:";
			// 
			// PnlFtpConfigurationHeader
			// 
			this.PnlFtpConfigurationHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.PnlFtpConfigurationHeader.BackColor = System.Drawing.SystemColors.ControlDark;
			this.PnlFtpConfigurationHeader.Location = new System.Drawing.Point(14, 18);
			this.PnlFtpConfigurationHeader.Name = "PnlFtpConfigurationHeader";
			this.PnlFtpConfigurationHeader.Size = new System.Drawing.Size(334, 1);
			this.PnlFtpConfigurationHeader.TabIndex = 30;
			// 
			// LblFtpHost
			// 
			this.LblFtpHost.AutoSize = true;
			this.LblFtpHost.Location = new System.Drawing.Point(19, 37);
			this.LblFtpHost.Name = "LblFtpHost";
			this.LblFtpHost.Size = new System.Drawing.Size(50, 13);
			this.LblFtpHost.TabIndex = 17;
			this.LblFtpHost.Text = "Address:";
			// 
			// TbxPassword
			// 
			this.TbxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TbxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Commanigy.Slingshot.App.Properties.Settings.Default, "FtpPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TbxPassword.Location = new System.Drawing.Point(109, 141);
			this.TbxPassword.Name = "TbxPassword";
			this.TbxPassword.PasswordChar = '*';
			this.TbxPassword.Size = new System.Drawing.Size(231, 21);
			this.TbxPassword.TabIndex = 5;
			this.TbxPassword.Text = global::Commanigy.Slingshot.App.Properties.Settings.Default.FtpPassword;
			// 
			// LblFtpPassword
			// 
			this.LblFtpPassword.AutoSize = true;
			this.LblFtpPassword.Location = new System.Drawing.Point(19, 144);
			this.LblFtpPassword.Name = "LblFtpPassword";
			this.LblFtpPassword.Size = new System.Drawing.Size(57, 13);
			this.LblFtpPassword.TabIndex = 27;
			this.LblFtpPassword.Text = "Password:";
			// 
			// LblFtpPath
			// 
			this.LblFtpPath.AutoSize = true;
			this.LblFtpPath.Location = new System.Drawing.Point(19, 63);
			this.LblFtpPath.Name = "LblFtpPath";
			this.LblFtpPath.Size = new System.Drawing.Size(55, 13);
			this.LblFtpPath.TabIndex = 21;
			this.LblFtpPath.Text = "Directory:";
			// 
			// TbxFtpPort
			// 
			this.TbxFtpPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TbxFtpPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Commanigy.Slingshot.App.Properties.Settings.Default, "FtpPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TbxFtpPort.Location = new System.Drawing.Point(298, 34);
			this.TbxFtpPort.Name = "TbxFtpPort";
			this.TbxFtpPort.Size = new System.Drawing.Size(42, 21);
			this.TbxFtpPort.TabIndex = 1;
			this.TbxFtpPort.Text = global::Commanigy.Slingshot.App.Properties.Settings.Default.FtpPort;
			this.TbxFtpPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// TbxPublicSite
			// 
			this.TbxPublicSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TbxPublicSite.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Commanigy.Slingshot.App.Properties.Settings.Default, "PublicSiteUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TbxPublicSite.Location = new System.Drawing.Point(109, 213);
			this.TbxPublicSite.Name = "TbxPublicSite";
			this.TbxPublicSite.ReadOnly = true;
			this.TbxPublicSite.Size = new System.Drawing.Size(231, 21);
			this.TbxPublicSite.TabIndex = 6;
			this.TbxPublicSite.Text = global::Commanigy.Slingshot.App.Properties.Settings.Default.PublicSiteUrl;
			// 
			// TbxFtpFileName
			// 
			this.TbxFtpFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TbxFtpFileName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Commanigy.Slingshot.App.Properties.Settings.Default, "FtpFileName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TbxFtpFileName.Location = new System.Drawing.Point(109, 88);
			this.TbxFtpFileName.Name = "TbxFtpFileName";
			this.TbxFtpFileName.Size = new System.Drawing.Size(231, 21);
			this.TbxFtpFileName.TabIndex = 3;
			this.TbxFtpFileName.Text = global::Commanigy.Slingshot.App.Properties.Settings.Default.FtpFileName;
			this.TbxFtpFileName.Leave += new System.EventHandler(this.TbxFtpHost_Leave_1);
			// 
			// TbxFtpHost
			// 
			this.TbxFtpHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TbxFtpHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Commanigy.Slingshot.App.Properties.Settings.Default, "FtpHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TbxFtpHost.Location = new System.Drawing.Point(109, 34);
			this.TbxFtpHost.Name = "TbxFtpHost";
			this.TbxFtpHost.Size = new System.Drawing.Size(146, 21);
			this.TbxFtpHost.TabIndex = 0;
			this.TbxFtpHost.Text = global::Commanigy.Slingshot.App.Properties.Settings.Default.FtpHost;
			this.TbxFtpHost.Leave += new System.EventHandler(this.TbxFtpHost_Leave_1);
			// 
			// TbxPath
			// 
			this.TbxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TbxPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Commanigy.Slingshot.App.Properties.Settings.Default, "FtpPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TbxPath.Location = new System.Drawing.Point(109, 60);
			this.TbxPath.Name = "TbxPath";
			this.TbxPath.Size = new System.Drawing.Size(231, 21);
			this.TbxPath.TabIndex = 2;
			this.TbxPath.Text = global::Commanigy.Slingshot.App.Properties.Settings.Default.FtpPath;
			this.TbxPath.Leave += new System.EventHandler(this.TbxFtpHost_Leave_1);
			// 
			// TbxUserName
			// 
			this.TbxUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TbxUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Commanigy.Slingshot.App.Properties.Settings.Default, "FtpUserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TbxUserName.Location = new System.Drawing.Point(109, 115);
			this.TbxUserName.Name = "TbxUserName";
			this.TbxUserName.Size = new System.Drawing.Size(231, 21);
			this.TbxUserName.TabIndex = 4;
			this.TbxUserName.Text = global::Commanigy.Slingshot.App.Properties.Settings.Default.FtpUserName;
			// 
			// CbShortenLinks
			// 
			this.CbShortenLinks.AutoSize = true;
			this.CbShortenLinks.Checked = global::Commanigy.Slingshot.App.Properties.Settings.Default.ShortenUrl;
			this.CbShortenLinks.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CbShortenLinks.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Commanigy.Slingshot.App.Properties.Settings.Default, "ShortenUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.CbShortenLinks.Location = new System.Drawing.Point(16, 25);
			this.CbShortenLinks.Name = "CbShortenLinks";
			this.CbShortenLinks.Size = new System.Drawing.Size(148, 17);
			this.CbShortenLinks.TabIndex = 0;
			this.CbShortenLinks.Text = "Shorten links using goo.gl";
			this.CbShortenLinks.UseVisualStyleBackColor = true;
			// 
			// Preferences
			// 
			this.AcceptButton = this.BtnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.BtnCancel;
			this.ClientSize = new System.Drawing.Size(394, 437);
			this.Controls.Add(this.TcPreferences);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.BtnOK);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Preferences";
			this.ShowIcon = false;
			this.Text = "Preferences";
			this.Load += new System.EventHandler(this.Preferences_Load);
			this.TcPreferences.ResumeLayout(false);
			this.TpGeneral.ResumeLayout(false);
			this.GbWindowsIntegration.ResumeLayout(false);
			this.GbWindowsIntegration.PerformLayout();
			this.TpFtp.ResumeLayout(false);
			this.TpFtp.PerformLayout();
			this.PnlMissingConfiguration.ResumeLayout(false);
			this.PnlMissingConfiguration.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnOK;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.TabControl TcPreferences;
		private System.Windows.Forms.TabPage TpGeneral;
		private System.Windows.Forms.TabPage TpFtp;
		private System.Windows.Forms.Label LblSiteConfigurationHeader;
		private System.Windows.Forms.Panel PnlSiteConfigurationHeader;
		private System.Windows.Forms.Label LblPort;
		private System.Windows.Forms.Label LblFtpConfiguration;
		private System.Windows.Forms.TextBox TbxFtpPort;
		private System.Windows.Forms.Label LblFileName;
		private System.Windows.Forms.TextBox TbxPublicSite;
		private System.Windows.Forms.TextBox TbxFtpFileName;
		private System.Windows.Forms.Label LblPublicSite;
		private System.Windows.Forms.Label LblFtpUserName;
		private System.Windows.Forms.Panel PnlFtpConfigurationHeader;
		private System.Windows.Forms.TextBox TbxFtpHost;
		private System.Windows.Forms.Label LblFtpHost;
		private System.Windows.Forms.TextBox TbxPassword;
		private System.Windows.Forms.TextBox TbxPath;
		private System.Windows.Forms.TextBox TbxUserName;
		private System.Windows.Forms.Label LblFtpPassword;
		private System.Windows.Forms.Label LblFtpPath;
		private System.Windows.Forms.GroupBox GbWindowsIntegration;
		private System.Windows.Forms.CheckBox CbCopyLinkToClipboard;
		private System.Windows.Forms.Panel PnlMissingConfiguration;
		private System.Windows.Forms.Label LblMissingConfiguration;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.LinkLabel LnkCustomizePublicSiteUrl;
		private System.Windows.Forms.CheckBox CbShortenLinks;
	}
}
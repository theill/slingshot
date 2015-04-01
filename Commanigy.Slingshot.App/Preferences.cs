#region Using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration; 
#endregion

namespace Commanigy.Slingshot.App {
	/// <summary>
	/// 
	/// </summary>
	public partial class Preferences : Form {
		/// <summary>
		/// 
		/// </summary>
		public bool IsPublicSiteReadOnly {
			get {
				return TbxPublicSite.ReadOnly;
			}
		}

		public Preferences() {
			InitializeComponent();
		}

		private void BtnOK_Click(object sender, EventArgs e) {
			Properties.Settings.Default.Save();
			Close();
		}

		private void Preferences_Load(object sender, EventArgs e) {
			if (!Properties.Settings.Default.IsConfigured) {
				TcPreferences.SelectTab(TpFtp);
				PnlMissingConfiguration.Visible = true;
			}
		}

		private string GetPublicSiteUrl() {
			string publicSiteUrl = string.Empty;
			if (TbxFtpHost.Text.Length > 0) {
				publicSiteUrl = "http://" + (TbxFtpHost.Text.EndsWith("/") ? TbxFtpHost.Text : TbxFtpHost.Text + "/");
			}

			if (TbxPath.Text.Length > 0) {
				string path = TbxPath.Text.ToLower().Replace("/http/", "/").Replace("/web/", "/").Replace("/www/", "/").Replace("/wwwroot/", "/");
				path = path.StartsWith("/") ? path.Remove(0, 1) : path;
				publicSiteUrl += (path.EndsWith("/") ? path : path + "/");
			}

			if (TbxFtpFileName.Text.Length > 0) {
				string filename = TbxFtpFileName.Text.StartsWith("/") ? TbxFtpFileName.Text.Remove(0, 1) : TbxFtpFileName.Text;
				publicSiteUrl += filename;
			}

			return publicSiteUrl;
		}

		private void TbxFtpHost_Leave_1(object sender, EventArgs e) {
			if (IsPublicSiteReadOnly) {
				TbxPublicSite.Text = GetPublicSiteUrl();
			}
		}

		private void LnkCustomizePublicSiteUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			(sender as Control).Visible = false;
			TbxPublicSite.ReadOnly = false;
			TbxPublicSite.Focus();
		}
	}
}

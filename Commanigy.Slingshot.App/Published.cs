#region Using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Commanigy.Slingshot.App.Properties;
#endregion

namespace Commanigy.Slingshot.App {
	public partial class Published : Form {
		public string Url {
			set {
				TbxPublicSiteUrl.Text = value;
			}
		}

		public Published() {
			InitializeComponent();
		}

		public Published(string token) : this() {
			string url = string.Format(Properties.Settings.Default.PublicSiteUrl, token);
			this.Url = Properties.Settings.Default.ShortenUrl ? GoogleUrl.Shorten(url) : url;
		}

		private void BtnCopyToClipboard_Click(object sender, EventArgs e) {
			Clipboard.SetText(TbxPublicSiteUrl.Text);
		}

		private void Published_Shown(object sender, EventArgs e) {
			LblLinkCopied.Visible = Settings.Default.CopyLinkToClipboard;
			BtnCopyToClipboard.Visible = !Settings.Default.CopyLinkToClipboard;

			if (Settings.Default.CopyLinkToClipboard) {
				Clipboard.SetText(TbxPublicSiteUrl.Text);
			}

			TbxPublicSiteUrl.SelectAll();
			TbxPublicSiteUrl.Focus();
		}
	}
}
#region Using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using System.Deployment.Application;
using System.Configuration;
#endregion

namespace Commanigy.Slingshot.App {
	public partial class About : Form {
		public About() {
			InitializeComponent();

			Assembly asm = Assembly.GetExecutingAssembly();
			LblVersion.Text = asm.GetName().Version.ToString();
			//FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(asm.Location);
			//LblVersion.Text = fvi.ProductVersion;

			//if (ApplicationDeployment.IsNetworkDeployed) {
			//    ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
			//    LblVersion.Text = ad.CurrentVersion.ToString();
			//}
		}

		private void BtnOk_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void LnkPreferences_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			//Console.WriteLine(GoogleUrl.Shorten("http://www.theill.com"));
			//new Slingshot().Sling(@"C:\Users\Peter Theill\Desktop\test\");
			//new FtpSling().Sling(@"C:\Users\Peter Theill\Desktop\test\test.txt");
			//new AmazonSling().Sling(@"C:\Users\Peter Theill\Desktop\test");
			//new HttpSling(1).SlingHttp(@"C:\Users\Public\Pictures\Sample Pictures");
			//new GoogleSling(1).Sling(@"C:\Users\Public\Pictures\Sample Pictures");
			new Preferences().ShowDialog();
		}

		private void LnkCopyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(new ProcessStartInfo("http://commanigy.com"));
		}

		private void LnkGettingStarted_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(new ProcessStartInfo("http://slingshot.commanigy.com/help/started"));
		}
	}
}
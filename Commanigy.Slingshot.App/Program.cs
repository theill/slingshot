#region Using directives
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using Commanigy.Slingshot.App.Properties;
using System.Deployment.Application;
using System.Net;
using System.IO; 
#endregion

namespace Commanigy.Slingshot.App {
	/// <summary>
	/// 
	/// </summary>
	static class Program {
		private static Preferences preferences;
		private static NotifyIcon icon;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args) {
			// process any arguments passed to application
			if (ProcessCommand(args)) {
				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			if (args.Length == 0) {
				Application.Run(new About());
				return;
			}

			try {
				string token = new FtpSling().Sling(args[0]);

				Application.Run(new Published(token));
			}
			catch (UriFormatException ufx) {
				MessageBox.Show("The FTP server wasn't properly configured.\n\n" + ufx.Message + "\n\nConfigure Slingshot and try again.", "Error publishing");
				new Preferences().ShowDialog();
			}
			catch (FileNotFoundException fnfx) {
				MessageBox.Show("It wasn't possible to find a file.\n\n" + fnfx.Message, "Error publishing");
			}
			catch (WebException wx) {
				MessageBox.Show("It wasn't possible to publish your file.\n\n" + wx.Message, "Error publishing");
			}
			catch (Exception x) {
				MessageBox.Show("It was not possible to publish your file.\n\n" + x.Message, "Error publishing");
			}
		}

		/// <summary>
		/// Process command line actions (register or unregister).
		/// </summary>
		/// <param name="args">Command line arguments.</param>
		/// <returns>True if processed an action in the command line.</returns>
		static bool ProcessCommand(string[] args) {
			if (args.Length == 0) {
				return false;
			}

			switch (args[0]) {
				case "/register":
					new Slingshot().RegisterShellExtension();
					MessageBox.Show(string.Format("The {0} shell extension was registered.", Resources.ApplicationName), Resources.ApplicationName);
					return true;

				case "/unregister":
					new Slingshot().UnregisterShellExtension();
					MessageBox.Show(string.Format("The {0} shell extension was unregistered.", Resources.ApplicationName), Resources.ApplicationName);
					return true;

				case "/tray":
					StartInTraybar();
					return true;
			}

			// command line did not contain an action
			return false;
		}


		private static void StartInTraybar() {
			// start application in traybar

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			icon = new NotifyIcon();
			icon.Text = Resources.ApplicationName;
			icon.Icon = Resources._1270108092_network;
			icon.Visible = true;
			icon.ContextMenu = new ContextMenu();
			//icon.DoubleClick += new EventHandler(OpenApplicationClick);
			//icon.MouseUp += new MouseEventHandler(icon_MouseUp);
			//icon.ShowBalloonTip(1000, "Ready to empty your mind?", "Bucket is now running and ready to receive your tasks", ToolTipIcon.Info);

			MenuItem menuItem = null;

			menuItem = new MenuItem("Preferences...", PreferencesClick);
			icon.ContextMenu.MenuItems.Add(menuItem);

			menuItem = new MenuItem("E&xit", CloseApplicationClick);
			icon.ContextMenu.MenuItems.Add(menuItem);
			
			Application.Run();
		}


		static void PreferencesClick(object sender, EventArgs e) {
			if (preferences == null || preferences.IsDisposed) {
				preferences = new Preferences();
			}

			preferences.Visible = true;
			preferences.Activate();
		}


		static void CloseApplicationClick(object sender, EventArgs e) {
			// save changes such as window position
			Settings.Default.Save();

			if (preferences != null && !preferences.IsDisposed) {
				preferences.Dispose();
				preferences = null;
			}

			if (icon != null) {
				icon.Dispose();
				icon = null;
			}

			Application.Exit();
		}
	}
}
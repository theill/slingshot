#region Using directives
using Microsoft.Win32;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Configuration;
using System.Security;
using System; 
#endregion

namespace Commanigy.Slingshot.App.Properties {
	/// <summary>
	/// 
	/// </summary>
	internal sealed partial class Settings {

		public Settings() {
			// // To add event handlers for saving and changing settings, uncomment the lines below:
			//
			// this.SettingChanging += this.SettingChangingEventHandler;
			//
			this.SettingsSaving += this.SettingsSavingEventHandler;
			this.SettingsLoaded += this.SettingsLoadedEventHandler;
		}

		public bool IsConfigured {
			get {
				return !(string.IsNullOrEmpty(FtpHost) || string.IsNullOrEmpty(FtpFileName) || string.IsNullOrEmpty(FtpUserName) || string.IsNullOrEmpty(FtpPassword) || string.IsNullOrEmpty(PublicSiteUrl));
			}
		}

		private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
			// Add code to handle the SettingChangingEvent event here.
		}

		public void SettingsLoadedEventHandler(object sender, System.Configuration.SettingsLoadedEventArgs e) {
			Settings.Default.FtpPassword = ToInsecureString(DecryptString(Settings.Default.FtpPassword));
		}


		private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
			RegistryKey runOnStartupKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			if (Settings.Default.RunOnStartup) {
				if (ApplicationDeployment.IsNetworkDeployed) {
					//ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
					runOnStartupKey.SetValue(Resources.ApplicationName, string.Format("{0} /tray", Application.ExecutablePath));
				}
				else {
					runOnStartupKey.SetValue(Resources.ApplicationName, string.Format("{0} /tray", Application.ExecutablePath));
				}
			}
			else {
				runOnStartupKey.DeleteValue(Resources.ApplicationName, false);
			}

			if (Settings.Default.ShellExtensionEnabled) {
				new Slingshot().RegisterShellExtension();
			}
			else {
				new Slingshot().UnregisterShellExtension();
			}

			Settings.Default.FtpPassword = EncryptString(ToSecureString(Settings.Default.FtpPassword));
		}

		static byte[] entropy = System.Text.Encoding.Unicode.GetBytes("fnui24hrcf7weyf78sdh");

		public static string EncryptString(System.Security.SecureString input) {
			byte[] encryptedData = System.Security.Cryptography.ProtectedData.Protect(
				System.Text.Encoding.Unicode.GetBytes(ToInsecureString(input)),
				entropy,
				System.Security.Cryptography.DataProtectionScope.CurrentUser);
			return Convert.ToBase64String(encryptedData);
		}

		public static SecureString DecryptString(string encryptedData) {
			try {
				byte[] decryptedData = System.Security.Cryptography.ProtectedData.Unprotect(
					Convert.FromBase64String(encryptedData),
					entropy,
					System.Security.Cryptography.DataProtectionScope.CurrentUser);
				return ToSecureString(System.Text.Encoding.Unicode.GetString(decryptedData));
			}
			catch {
				return new SecureString();
			}
		}

		public static SecureString ToSecureString(string input) {
			SecureString secure = new SecureString();
			foreach (char c in input) {
				secure.AppendChar(c);
			}
			secure.MakeReadOnly();
			return secure;
		}

		public static string ToInsecureString(SecureString input) {
			string returnValue = string.Empty;
			IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);
			try {
				returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
			}
			finally {
				System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
			}
			return returnValue;
		}

	}
}

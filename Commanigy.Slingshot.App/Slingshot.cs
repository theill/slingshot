#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using Commanigy.Slingshot.App.Properties;
using System.Windows.Forms; 
#endregion

namespace Commanigy.Slingshot.App {
	public class Slingshot {
		const string MenuText = "Sling to Public Site";

		public void RegisterShellExtension() {
			// register context menu - full path to self, %L is placeholder for selected file
			//FileShellExtension.Register("*", Resources.ApplicationName, MenuText, string.Format("\"{0}\" \"%L\"", Application.ExecutablePath));
			//FileShellExtension.Register("Directory", Resources.ApplicationName, MenuText, string.Format("\"{0}\" \"%L\"", Application.ExecutablePath));
#if DEBUG
			FileShellExtension.Register("AllFileSystemObjects", Resources.ApplicationName + "_DEBUG", MenuText + " (debug)", string.Format("\"{0}\" \"%L\"", Application.ExecutablePath));
#else
			FileShellExtension.Register("AllFileSystemObjects", Resources.ApplicationName, MenuText, string.Format("\"{0}\" \"%L\"", Application.ExecutablePath));
#endif
		}

		public void UnregisterShellExtension() {
			// unregister the context menu
			//FileShellExtension.Unregister("*", Resources.ApplicationName);
			//FileShellExtension.Unregister("Directory", Resources.ApplicationName);
#if DEBUG
			FileShellExtension.Unregister("AllFileSystemObjects", Resources.ApplicationName + "_DEBUG");
#else
			FileShellExtension.Unregister("AllFileSystemObjects", Resources.ApplicationName);
#endif
		}
	}
}
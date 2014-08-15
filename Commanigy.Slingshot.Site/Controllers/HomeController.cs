#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 
#endregion

namespace Commanigy.Slingshot.Site.Controllers {
	[HandleError]
	public class HomeController : Controller {
		public ActionResult Index() {
			ViewData["Message"] = "Welcome to ASP.NET MVC!";

			return View();
		}

		public ActionResult About() {
			return View();
		}
	}
}

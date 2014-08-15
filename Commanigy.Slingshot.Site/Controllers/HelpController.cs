#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 
#endregion

namespace Commanigy.Slingshot.Site.Controllers {
	public class HelpController : Controller {
		//
		// GET: /Help/

		public ActionResult Index() {
			return View();
		}

		public ActionResult Started() {
			return View();
		}

	}
}

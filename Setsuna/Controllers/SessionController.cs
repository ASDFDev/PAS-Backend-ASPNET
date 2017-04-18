using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using OtpNet;

namespace Setsuna.Controllers
{
    public class SessionController : Controller
    {

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult GenerateSecret()
		{	
			return View();
		}

		public ActionResult GenerateTOTP()
		{
			return View();
		}

    }
}

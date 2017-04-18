using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Setsuna.Controllers
{
    public class AuthController : Controller
    {

        public ActionResult Index()
        {
			MySqlConnection c = new MySqlConnection("UID=root;" + // HACK: Non-secure credentials
												"PASSWORD=12345;" +
												"SERVER=localhost;" + // Note: SQL connector has no PORT value
			                                    "PORT=7355;" + 
												"DATABASE=setsuna;");
			c.Open();
			return View();
        }

		public ActionResult PostAuth(string username, string password)
		{
			return View();
		}
    }

}

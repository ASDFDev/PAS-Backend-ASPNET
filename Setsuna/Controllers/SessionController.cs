using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using OtpNet;

namespace Setsuna.Controllers
{
    public class SessionController : Controller
    {

        public string Index()
        {
			return "<h1>Step 1: <a href=./Session/GenerateSecret>Generate secret</a></h1>" +
				"<h1>Step 2: <a href=./Session/GenerateTOTP>Generate OTP</a></h1>";
        }

		public string GenerateSecret()
		{	
			Random random = new Random();
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			string secret = new string(Enumerable.Repeat(chars, 16).Select(s => s[random.Next(s.Length)]).ToArray());
			Cache.secret = secret;
			return ("Secret with value " + secret + " generated. <a href=./GenerateTOTP>Generate OTP</a>");
		}

		public string GenerateTOTP()
		{
			if (Cache.secret == null)
				return ("No secret found. <a href=./GenerateSecret>Generate secret</a>");
			Totp OTK = new OtpNet.Totp(new ASCIIEncoding().GetBytes(Cache.secret), 5, OtpHashMode.Sha512, 8, null);
			Response.AddHeader("Refresh", "5");
			return ("OTP generated with secret '" + Cache.secret + "': " + OTK.ComputeTotp());
		}

    }
}

using System;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ReportingLogin.App_Data;
using ReportingLogin.Models;

namespace ReportingLogin.Controllers
{
    public class HomeController : Controller
    {
        public class SHA512
        {
            public static string Encode(string value)
            {
                var hash = System.Security.Cryptography.SHA512.Create();
                var encoder = new ASCIIEncoding();
                var combined = encoder.GetBytes(value ?? "");
                return BitConverter.ToString(hash.ComputeHash(combined)).ToLower().Replace("-", "");
            }
        }

        public JsonResult UserLogin(LoginData d)
        {
            using (LoginDatabaseEntities dc = new LoginDatabaseEntities())
            {
                var username = d.Login;
                var pass = SHA512.Encode(d.Password);
                var user = dc.users.FirstOrDefault(a => a.Login.Equals(username) && a.Password.Equals(pass));
                return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            return View();
        }

        public ActionResult Fail()
        {
            return View();
        }
    }
}
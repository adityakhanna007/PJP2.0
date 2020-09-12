using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace InternationalisationService.Controllers
{
    public class LanguageController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/index.cshtml");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Change(String LangAbbrev)
        {
            if (LangAbbrev != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(LangAbbrev);
                Thread.CurrentThread.CurrentCulture = new CultureInfo(LangAbbrev);
            }
            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = LangAbbrev;
            Response.Cookies.Add(cookie);


            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cookie.Value);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cookie.Value);

            ViewBag.message = "locale changed successfully";

            return View("~/Views/index.cshtml");

        }
    }
}
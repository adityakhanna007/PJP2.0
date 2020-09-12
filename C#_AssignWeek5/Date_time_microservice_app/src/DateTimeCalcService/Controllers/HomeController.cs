using DateTimeCalcService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DateTimeCalcService.Controllers
{
    
    public class HomeController : Controller
    {
        DateTimeModel dtmodel = new DateTimeModel();
        public ActionResult Index()
        {
            var cookie = Request.Cookies["Language"];
            if (cookie != null && cookie.Value != null)
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cookie.Value);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cookie.Value);

            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }
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
        [HttpGet]
        public ActionResult GetChoice(int option)
        {
            if (option == 1)
                return View("~/Views/sub_dates.cshtml");
            else if (option == 2)
                return View("~/Views/add_days.cshtml");
            else if (option == 3)
                return View("~/Views/day_of_week.cshtml");
            else if (option == 4)
                return View("~/Views/week_number.cshtml");
            else
                return View("~/Views/translateNLP.cshtml");
        }

        [HttpPost]
        public ActionResult sub_dates(int date1, int month1, int year1, int hr1, int min1, int sec1, int date2, int month2, int year2, int hr2, int min2, int sec2)
        {
            DateTime dt1 = new DateTime(year1, month1, date1, hr1, min1, sec1);
            DateTime dt2 = new DateTime(year2, month2, date2, hr2, min2, sec2);
            ViewBag.ans = dtmodel.SubDates(dt1, dt2);

            return View("~/Views/sub_dates.cshtml");

        }
        [HttpPost]
        public ActionResult add_days(int date, int month, int year, int hr, int min, int sec, int days, int option, int operation)
        {
            DateTime dt = new DateTime(year, month, date, hr, min, sec);

            if (operation == 2)
            {
                days = -1 * days;

            }

            ViewBag.ans = dtmodel.AddDays(dt, days, option);


            return View("~/Views/add_days.cshtml");



        }

        [HttpPost]
        public ActionResult day_of_week(int date, int month, int year, int hr, int min, int sec)
        {
            DateTime dt = new DateTime(year, month, date, hr, min, sec);
            ViewBag.ans = dtmodel.DayOfWeek(dt);

            return View("~/Views/day_of_week.cshtml");



        }

        [HttpPost]
        public ActionResult week_number(int date, int month, int year, int hr, int min, int sec)
        {
            DateTime dt = new DateTime(year, month, date, hr, min, sec);
            ViewBag.ans = dtmodel.WeekNumber(dt);

            return View("~/Views/week_number.cshtml");



        }

        [HttpPost]
        public ActionResult translateNLP(int option)
        {

            ViewBag.ans = dtmodel.translateNLP(option);

            return View("~/Views/translateNLP.cshtml");



        }
    }
}
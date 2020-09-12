using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using DateTimeCalcService.Models;
using DateTimeCalcService.DataContext;
namespace DateTimeCalcService.Models
{
    public class DateTimeModel:IDateTimeModel
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        public string SubDates(DateTime dt1, DateTime dt2)
        {
            TimeSpan value = (dt1.Subtract(dt2));
            string res = value.TotalDays.ToString() + " days";
            datetimerecords rec = new datetimerecords(dt1.ToString(), dt2.ToString(), "subtract", res);
            _context.datetimedetails.Add(rec);
            _context.SaveChanges();

            string ans = "Timespan between " + dt1.ToString() + " and " + dt2.ToString() + " is \nDays : " + value.TotalDays.ToString() + "\nWeeks: " + (value.TotalDays / 7).ToString() + "\nMonths: " + (value.TotalDays / 30).ToString();
            return ans;
        }
        public string AddDays(DateTime dt, int days, int option)
        {
            DateTime temp; string choice = "";
            if (option == 1)
            { temp = dt.AddDays(days); choice = "days"; }
            else if (option == 2)
            { temp = dt.AddDays(7 * days); choice = "weeks"; }
            else
            { temp = dt.AddMonths(days); choice = "months"; }

            string fun = "Add " + days.ToString() + " " + choice;
            datetimerecords rec = new datetimerecords(dt.ToString(), fun, temp.ToString());
            _context.datetimedetails.Add(rec);
            _context.SaveChanges();
            return ("Adding " + days.ToString() + choice + " to " + dt.ToString() + " gives : " + temp.ToString());
        }
        public string DayOfWeek(DateTime dt)
        {
            datetimerecords rec = new datetimerecords(dt.ToString(), "DayOfWeek", dt.DayOfWeek.ToString());
            _context.datetimedetails.Add(rec);
            _context.SaveChanges();

            return "The day of week for " + dt.ToString() + " : " + dt.DayOfWeek.ToString();
        }
        public string WeekNumber(DateTime dt)
        {
            //return "The week number for " + dt.ToString() + " : " + dt.ToString();
            // Gets the Calendar instance associated with a CultureInfo.
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;

            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            datetimerecords rec = new datetimerecords(dt.ToString(), "WeekNumber", myCal.GetWeekOfYear(dt, myCWR, myFirstDOW).ToString());
            _context.datetimedetails.Add(rec);
            _context.SaveChanges();
            return "The week number for " + dt + " is : " + myCal.GetWeekOfYear(dt, myCWR, myFirstDOW).ToString();
        }
        public string translateNLP(int option)
        {
            DateTime dt = DateTime.Now;
            DateTime ans = new DateTime();
            string choice = "";
            switch (option)
            {
                case 1:
                    choice = "Today";
                    ans = dt; break;
                case 2:
                    choice = "Tomorrow";
                    ans = dt.AddDays(1); break;
                case 3:
                    choice = "Day After Tomorrow";
                    ans = dt.AddDays(2); break;
                case 4:
                    choice = "Yesterday";
                    ans = dt.AddDays(-1); break;
                case 5:
                    choice = "Day Before Yesterday";
                    ans = dt.AddDays(-2); break;
                case 6:
                    choice = "Last Week";
                    ans = dt.AddDays(-7); break;
                case 7:
                    choice = "Next Week";
                    ans = dt.AddDays(7); break;
                case 8:
                    choice = "NextMonth";
                    ans = dt.AddMonths(1); break;
                case 9:
                    choice = "NextYear";
                    ans = dt.AddYears(1); break;
                case 10:
                    choice = "Last Month";
                    ans = dt.AddMonths(-1); break;
                case 11:
                    choice = "Last Year";
                    ans = dt.AddYears(-1); break;

            }
            datetimerecords rec = new datetimerecords(dt.ToString(), choice, ans.ToString());
            _context.datetimedetails.Add(rec);
            _context.SaveChanges();
            return "Output : " + ans.ToString();
        }
    }
}
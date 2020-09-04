using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
namespace Date_Time_Application.Models
{
    public class DateTimeModel
    {
       /* public string AddDates(DateTime dt1,DateTime dt2)
        {
           TimeSpan ts=new TimeSpan(dt2.Year,dt2.Month,dt2.Date,)
        }*/
        public string SubDates(DateTime dt1, DateTime dt2)
        {
            TimeSpan value = (dt1.Subtract(dt2));
            
            string ans = "Timespan between " + dt1.ToString()+ " and "+ dt2.ToString() +" is \nDays : " +value.TotalDays.ToString()+"\nWeeks: "+(value.TotalDays/7).ToString()  +"\nMonths: "+(value.TotalDays/30).ToString() ;
            return ans;
        }
        public string AddDays(DateTime dt, int days, int option)
        {
            DateTime temp; string choice;
            if (option == 1)
            { temp = dt.AddDays(days); choice = "days"; }
            else if (option == 2)
            { temp = dt.AddDays(7 * days); choice = "weeks"; }
            else
            { temp = dt.AddMonths(days); choice = "months"; }

            return ("Adding "+ days.ToString()+ choice+  " to " + dt.ToString() + " gives : " + temp.ToString());
        }
        public string DayOfWeek(DateTime dt)
        {
            return "The day of week for "+dt.ToString()+ " : "+dt.DayOfWeek.ToString();
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
           return "The week number for "+dt+" is : "+ myCal.GetWeekOfYear(dt, myCWR, myFirstDOW).ToString();
        }
        public string translateNLP(int option)
        {
            DateTime dt =  DateTime.Now;
            DateTime ans=new DateTime();
            
            switch(option)
            {
                case 1:
                    ans = dt;break;
                case 2:
                    ans = dt.AddDays(1); break;
                case 3:
                    ans = dt.AddDays(2);break;
                case 4:
                    ans = dt.AddDays(-1);break;
                case 5:
                    ans = dt.AddDays(-2);break;
                case 6:
                    ans = dt.AddDays(-7);break;
                case 7:
                    ans = dt.AddDays(7); break;
                case 8:
                    ans = dt.AddMonths(1);break;
                case 9:
                    ans = dt.AddYears(1);break;
                case 10:
                    ans = dt.AddMonths(-1);break;
                case 11:
                    ans = dt.AddYears(-1);break;

            }
            return "Output : " + ans.ToString();
        }



    }
}
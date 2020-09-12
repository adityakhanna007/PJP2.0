using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeCalcService.Models
{
     public  interface IDateTimeModel
    {
         string SubDates(DateTime dt1, DateTime dt2);


         string AddDays(DateTime dt, int days, int option);


         string DayOfWeek(DateTime dt);


        string WeekNumber(DateTime dt);


         string translateNLP(int option);


    }
}

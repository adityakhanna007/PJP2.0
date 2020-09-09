using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Npgsql;
namespace Date_Time_Application.Models
{
    [Table("datetimetable", Schema = "public")]
    public class datetimerecords
    {
        public datetimerecords(DateTime d1, string func, string res)
        {
            Date1 = d1;
            
            function = func;
            result = res;

        }
        public datetimerecords(DateTime d1,DateTime d2,string func,string res)
        {
            Date1 = d1;
            Date2 = d2;
            function = func;
            result = res;

        }
        [Key]
        public int id { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }
        public string function { get; set; }

        public string result { get; set; }
    }
}
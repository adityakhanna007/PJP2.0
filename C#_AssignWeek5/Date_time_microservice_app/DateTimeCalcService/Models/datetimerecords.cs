
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Npgsql;
namespace DateTimeCalcService.Models
{
    [Table("datetimetable", Schema = "public")]
    public class datetimerecords
    {
        public datetimerecords()
        {
            

        }

        public datetimerecords(string d1, string func, string res)
        {
            Date1 = d1;
            
            function = func;
            result = res;

        }
        public datetimerecords(string d1,string d2,string func,string res)
        {
            Date1 = d1;
            Date2 = d2;
            function = func;
            result = res;

        }
        [Key]
        public int id { get; set; }
        public string Date1 { get; set; }
        public string Date2 { get; set; }
        public string function { get; set; }

        public string result { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Npgsql;
using Date_Time_Application.Models;
namespace Date_Time_Application.DataContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base(nameOrConnectionString:"MyConnection")
        {

        }
        public virtual DbSet<datetimerecords> datetimedetails { get; set; }
    }
}
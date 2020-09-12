using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Npgsql;
using DatabaseService.Models;
using System.Configuration;
namespace DatabaseService.DataContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base(nameOrConnectionString:"MyConnection")
        {

        }
        public virtual DbSet<datetimerecords> datetimedetails { get; set; }
    }
}
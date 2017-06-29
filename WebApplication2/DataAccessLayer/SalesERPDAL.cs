using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication2.Models;
using WebApplication2.DataAccessLayer;

namespace WebApplication2.DataAccessLayer
{
    public class SalesERPDAL : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Employee>().ToTable("tblEmployee");
            base.OnModelCreating(modelbuilder);
        }
    }
}
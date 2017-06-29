using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.DataAccessLayer;

namespace WebApplication2.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL s = new SalesERPDAL();
            return s.Employees.ToList();
    
        }
        public Employee SaveEmployee(Employee e)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }
    }
}
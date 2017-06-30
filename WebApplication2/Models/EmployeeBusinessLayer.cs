using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.DataAccessLayer;

namespace WebApplication2.Models
{
    public class EmployeeBusinessLayer
    {
        public UserStatus GetUserValidity(UserDetails u)
        {
            if (u.UserName == "admin" && u.Password == "admin")
            {
                return UserStatus.AuthenticatedAdmin;
            }
            else if (u.UserName == "daniel" && u.Password == "daniel")
            {
                return UserStatus.AuthentucatedUser;
            }
            else
            {
                return UserStatus.NonAuthenticatedUser;
            }
        }
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

        public void UploadEmployees(List<Employee> employees)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.AddRange(employees);
            salesDal.SaveChanges();
        }
    }
}
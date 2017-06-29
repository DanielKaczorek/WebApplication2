using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class TestController : Controller
    {
        public ActionResult GetView()
        {
            var employeeListViewModel = new EmployeeListViewModel();
            var employeeBusinessLayer = new EmployeeBusinessLayer();

            List<Employee> employees = employeeBusinessLayer.GetEmployees();

            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (Employee emp in employees)
            {
                EmployeeViewModel evm = new EmployeeViewModel();
                evm.EmployeeName = emp.FirstName + " " + emp.LastName;
                evm.Salary = emp.Salary.ToString();

                if (emp.Salary > 15000)
                {
                    evm.SalaryColor = "yellow";
                }
                else
                {
                    evm.SalaryColor = "green";
                }
                empViewModels.Add(evm);
            }

            employeeListViewModel.Employees = empViewModels;
            employeeListViewModel.UserName = "Admin";


            return View("MyView", employeeListViewModel);
        }


        public string GetString()
        {
            return "This is some random string";
        }

        [NonAction]
        public string SimpleMethod()
        {
            return "Hi, I am not action method";
        }
        public class Customer
        {
            public string CustomerName { get; set; }
            public string Address { get; set; }

            public override string ToString()
            {
                return this.CustomerName + " | " + this.Address;
            }
        }
        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "DANIEL";
            c.Address = "Ashington";
            return c;
        }


    }
}
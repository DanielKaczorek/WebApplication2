using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult AddNew()
        {
            return View("CreateEmployee", new CreateEmployeeViewModel());
        }

        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {

            switch (BtnSubmit)
            {
                case "Save Employee":
                    if (ModelState.IsValid)
                    {
                        EmployeeBusinessLayer ebl = new EmployeeBusinessLayer();
                        ebl.SaveEmployee(e);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        CreateEmployeeViewModel cevm = new CreateEmployeeViewModel();
                        cevm.FirstName = e.FirstName;
                        cevm.LastName = e.LastName;

                        if (e.Salary != 0)
                        {
                            cevm.Salary = e.Salary.ToString();
                        }
                        else
                        {
                            cevm.Salary = ModelState["Salary"].Value.AttemptedValue;
                        }
                        
                        return View("CreateEmployee", cevm);
                    }
                    break;
                case "Cancel":
                    return RedirectToAction("Index");
                    break;
            }
            return new EmptyResult();

        }
        [Authorize]
        public ActionResult Index()
        {
            var employeeListViewModel = new EmployeeListViewModel();
            employeeListViewModel.UserName = User.Identity.Name;

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

            return View("Index", employeeListViewModel);
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
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> Employees = new List<Employee>();

            Employee e = new Employee();
            e.FirstName = "Daniel";
            e.LastName = "Kaczorek";
            e.Salary = 213123;
            Employees.Add(e);

            e = new Employee();
            e.FirstName = "John";
            e.LastName = "Smith";
            e.Salary = 1231;
            Employees.Add(e);

            e = new Employee();
            e.FirstName = "Anna";
            e.LastName = "Murphy";
            e.Salary = 222121;
            Employees.Add(e);

            return Employees;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WebApplication2.Validation;

namespace WebApplication2.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [FirstNameValidation]
        public string FirstName { get; set; }
        [StringLength(10, ErrorMessage = "Last Name length should not be greater than 10")]
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
}
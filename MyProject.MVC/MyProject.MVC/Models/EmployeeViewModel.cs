using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.MVC.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DOJ { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProject.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DOJ { get; set; }
    }
}

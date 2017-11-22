using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using MyProject.Model;

namespace MyProject.Data
{
    public class SimpleDbContext : DbContext
    {
        public SimpleDbContext() :
            base("DefaultConnection")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}

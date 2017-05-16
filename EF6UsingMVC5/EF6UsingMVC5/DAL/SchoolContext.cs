using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Web;
using EF6UsingMVC5.Models;

//https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application

namespace EF6UsingMVC5.DAL
{
    public class SchoolContext : DbContext
    {
        //Entity Framework assumes that the connection string name is the same as the class name. 
        public SchoolContext() : base("SchoolContext")
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //configures the many-to-many join table
            //for the many-to-many relationship between the Instructor and Course entities, the code specifies the table and column names for the join table. Code First can configure the many-to-many relationship for you without this code, but if you don't call it, you will get default names such as InstructorInstructorID for the InstructorID column.
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Instructors).WithMany(i => i.Courses)
                .Map(t => t.MapLeftKey("CourseID")
                           .MapRightKey("InstructorID")
                           .ToTable("CourseInstructor"));
            modelBuilder.Entity<Instructor>()
                .HasOptional(p => p.OfficeAssignment).WithRequired(p => p.Instructor);

        }

    }
}
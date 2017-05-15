using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EF6UsingMVC5.Models;

namespace EF6UsingMVC5.DAL
{
    public class StudentRepository : IStudentRepository
    {
        private SchoolContext context;

        public StudentRepository(SchoolContext context)
        {
            this.context = context;
        }

        public IEnumerable<Student> GetStudents()
        {
            return context.Students.ToList();
        }

        public Student GetStudentByID(int studentId)
        {
            return context.Students.Find(studentId);
        }

        public void InsertStudent(Student student)
        {
            context.Students.Add(student);
        }

        public void DeleteStudent(int studentID)
        {
            //Student student = context.Students.Find(studentID);
            //context.Students.Remove(student);
            //If improving performance in a high-volume application is a priority, you could avoid an unnecessary SQL query to retrieve the row by replacing the lines of code that call the Find and Remove methods with the following code:
            Student studentToDelete = new Student() { ID = studentID };
            context.Entry(studentToDelete).State = EntityState.Deleted;
        }

        public void UpdateStudent(Student student)
        {
            context.Entry(student).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

    }
}
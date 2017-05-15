using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using EF6UsingMVC5.Models;

namespace EF6UsingMVC5.DAL
{
    public class GenericUnitOfWork : IDisposable
    {
        private SchoolContext context = new SchoolContext();

        public Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public GenericRepository<T> Repository<T>() where T : class
        {
            if (repositories.Keys.Contains(typeof (T)))
            {
                return repositories[typeof (T)] as GenericRepository<T>;
            }
            GenericRepository<T> repo = new GenericRepository<T>(context);
            repositories.Add(typeof (T), repo);
            return repo;
        }

        //private GenericRepository<Department> departmentRepository;
        //private GenericRepository<Course> courseRepository;
        //private GenericRepository<Student> studentRepository;

        //public GenericRepository<Department> DepartmentRepository
        //{
        //    get
        //    {
        //        if (this.departmentRepository == null)
        //        {
        //            this.departmentRepository = new GenericRepository<Department>(context);
        //        }
        //        return this.departmentRepository;
        //    }
        //}

        //public GenericRepository<Course> CourseRepository
        //{
        //    get
        //    {
        //        if (this.courseRepository == null)
        //        {
        //            this.courseRepository = new GenericRepository<Course>(context);
        //        }
        //        return this.courseRepository;
        //    }
        //}

        //public GenericRepository<Student> StudentRepository
        //{
        //    get
        //    {
        //        if (this.studentRepository == null)
        //        {
        //            this.studentRepository = new GenericRepository<Student>(context);
        //        }
        //        return this.studentRepository;
        //    }
        //}

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed;

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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
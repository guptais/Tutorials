using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EF6UsingMVC5.Models;

namespace EF6UsingMVC5.DAL
{
    public interface IStudentRepository : IDisposable
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentByID(int studentId);
        void InsertStudent(Student student);
        void DeleteStudent(int studentID);
        void UpdateStudent(Student student);
        void Save();
    }
}

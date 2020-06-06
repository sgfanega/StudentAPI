using System;
using System.Collections.Generic;
using System.Linq;
using StudentAPI.Models;

namespace StudentAPI.Data
{
    public class SqlStudentRepo : IStudentRepo
    {
        private readonly StudentContext _studentContext;

        public SqlStudentRepo(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        public void CreateStudent(Student student)
        {
            if(student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }

            _studentContext.Students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            if(student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }

            _studentContext.Students.Remove(student);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentContext.Students.ToList();
        }

        public Student GetStudentById(int studentId)
        {
            return _studentContext.Students.FirstOrDefault(p => p.StudentId == studentId);
        }

        public bool SaveChanges()
        {
            return (_studentContext.SaveChanges() >= 0);
        }

        public void UpdateStudent(Student student)
        {
            // Nothing because DBContext takes care of everything
            // This will still be "used" just for good practice in the Controller
        }
    }
}
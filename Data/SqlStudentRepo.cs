using System.Collections.Generic;
using StudentAPI.Models;

namespace StudentAPI.Data
{
    public class SqlStudentRepo : IStudentRepo
    {
        public IEnumerable<Student> GetAllStudents()
        {
            throw new System.NotImplementedException();
        }

        public Student GetStudentById(int studentId)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}
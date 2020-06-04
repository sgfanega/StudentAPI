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
        
        public IEnumerable<Student> GetAllStudents()
        {
            return _studentContext.Students.ToList();
        }

        public Student GetStudentById(int studentId)
        {
            return _studentContext.Students.FirstOrDefault(p => p.StudentId == studentId);
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}
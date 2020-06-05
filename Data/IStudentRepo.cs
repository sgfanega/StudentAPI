using System.Collections.Generic;
using StudentAPI.Models;

namespace StudentAPI.Data
{
    public interface IStudentRepo
    {
        bool SaveChanges();

        // GET
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int studentId);
        
        // POST
        void CreateStudent(Student student);
        
        // PUT
        void UpdateStudent(Student student);
        
        // DELETE
        void DeleteStudent(Student student);
    }
}
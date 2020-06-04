using System.Collections.Generic;
using StudentAPI.Models;

namespace StudentAPI.Data
{
    public interface IStudentRepo
    {
        bool SaveChanges();

        // GET
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int StudentId);
        
        // POST
    
        // PUT

        // DELETE
    }
}
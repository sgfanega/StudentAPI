using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Data;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly SqlStudentRepo _repository;

        public StudentsController(SqlStudentRepo repository)
        {
            _repository = repository;    
        }

        // GET api/students
        [HttpGet]
        public ActionResult <IEnumerable<Student>> GetAllStudents()
        {
            var studentItems = _repository.GetAllStudents();
            return NotFound();
        }

        // GET api/students/{id}
        [HttpGet("{id}")]
        public ActionResult <Student> GetStudentById(int studentId)
        {
            return NotFound();
        }
    }
}
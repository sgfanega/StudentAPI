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
        private readonly IStudentRepo _repository;

        public StudentsController(IStudentRepo repository)
        {
            _repository = repository;    
        }

        // GET api/students
        [HttpGet]
        public ActionResult <IEnumerable<Student>> GetAllStudents()
        {
            var studentItems = _repository.GetAllStudents();

            return Ok(studentItems);
        }

        // GET api/students/{id}
        [HttpGet("{studentId}")]
        public ActionResult <Student> GetStudentById(int studentId)
        {
            var studentItem = _repository.GetStudentById(studentId);
            
            if(studentItem != null)
            {
                return Ok(studentItem);
            }
            return NotFound();
            
        }
    }
}
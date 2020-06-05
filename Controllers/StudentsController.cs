using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Data;
using StudentAPI.Dtos;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepo _repository;
        private readonly IMapper _mapper;

        public StudentsController(IStudentRepo repository, IMapper mapper)
        {
            _repository = repository;    
            _mapper = mapper;
        }

        // GET api/students
        [HttpGet]
        public ActionResult <IEnumerable<StudentReadDto>> GetAllStudents()
        {
            var studentItems = _repository.GetAllStudents();

            return Ok(_mapper.Map<IEnumerable<StudentReadDto>>(studentItems));
        }

        // GET api/students/{id}
        [HttpGet("{studentId}")]
        public ActionResult <StudentReadDto> GetStudentById(int studentId)
        {
            var studentItem = _repository.GetStudentById(studentId);
            
            if(studentItem != null)
            {
                return Ok(_mapper.Map<StudentReadDto>(studentItem));
            }

            return NotFound();
        }

        // POST api/students
        [HttpPost]
        public ActionResult <StudentReadDto> CreateStudent(StudentCreateDto studentCreateDto)
        {
            var studentModel = _mapper.Map<Student>(studentCreateDto);

            _repository.CreateStudent(studentModel);
            _repository.SaveChanges();

            return Ok(studentModel);
        }
    }
}
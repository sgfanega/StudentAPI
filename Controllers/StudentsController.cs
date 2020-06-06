using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
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
        [HttpGet("{studentId}", Name="GetStudentById")]
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
            
            var studentReadDto = _mapper.Map<StudentReadDto>(studentModel);

            return CreatedAtRoute(nameof(GetStudentById), new {StudentId = studentReadDto.StudentId}, studentReadDto);
        }

        // PUT api/students/{id}
        [HttpPut("{studentId}")]
        public ActionResult UpdateCommand(int studentId, StudentUpdateDto studentUpdateDto)
        {
            var studentModelFromRepo = _repository.GetStudentById(studentId);

            if(studentModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(studentUpdateDto, studentModelFromRepo);

            _repository.UpdateStudent(studentModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        // PATCH api/students/{id}
        [HttpPatch("{studentId}")]
        public ActionResult PartialStudentUpdate(int studentId, JsonPatchDocument<StudentUpdateDto> patchDocument)
        {
            var studentModelFromRepo = _repository.GetStudentById(studentId);

            if(studentModelFromRepo == null)
            {
                return NotFound();
            }

            var studentToPatch = _mapper.Map<StudentUpdateDto>(studentModelFromRepo);
            patchDocument.ApplyTo(studentToPatch, ModelState);
            if(!TryValidateModel(studentToPatch))
            {
                return ValidationProblem(ModelState);
            }
            
            _mapper.Map(studentToPatch, studentModelFromRepo);
            _repository.UpdateStudent(studentModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        // DELETE api/students/{studentId}
        [HttpDelete("{studentId}")]
        public ActionResult DeleteStudent(int studentId)
        {
            var studentModelFromRepo = _repository.GetStudentById(studentId);
            if(studentModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteStudent(studentModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
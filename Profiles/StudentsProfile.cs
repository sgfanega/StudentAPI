using AutoMapper;
using StudentAPI.Dtos;
using StudentAPI.Models;

namespace StudentAPI.Profiles
{
    public class StudentsProfile : Profile
    {
        public StudentsProfile()
        {
            // Source
            CreateMap<Student, StudentReadDto>();
        }
    }
}
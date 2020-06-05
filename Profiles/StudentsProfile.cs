using AutoMapper;
using StudentAPI.Dtos;
using StudentAPI.Models;

namespace StudentAPI.Profiles
{
    public class StudentsProfile : Profile
    {
        public StudentsProfile()
        {
            // Source -> Target
            CreateMap<Student, StudentReadDto>();

            // Target -> Source
            CreateMap<StudentCreateDto, Student>();

        }
    }
}
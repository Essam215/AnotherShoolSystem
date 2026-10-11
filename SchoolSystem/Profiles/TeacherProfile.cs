using AutoMapper;
using SchoolSystem.DTO_s;
using SchoolSystem.Models;

namespace SchoolSystem.Profiles
{
    public class TeacherProfile : Profile
    {
        public TeacherProfile() { 
            CreateMap<Teacher, TeacherDto>().ReverseMap();
            CreateMap<Teacher, GetTeacherDto>().ReverseMap();
            CreateMap<Teacher, UpdateTeacherDto>().ReverseMap();
        }
    }
}

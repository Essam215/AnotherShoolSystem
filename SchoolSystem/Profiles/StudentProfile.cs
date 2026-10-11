using AutoMapper;
using SchoolSystem.DTO_s;
using SchoolSystem.Models;

namespace SchoolSystem.Profiles
{
    public class StudentProfile:Profile
    {
       public StudentProfile() {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Student, GetStudentDto>().ReverseMap();
            CreateMap<Student, UpdateStudentDto>().ReverseMap();
        }
    }
}

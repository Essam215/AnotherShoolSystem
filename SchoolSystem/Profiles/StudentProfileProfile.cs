using AutoMapper;
using SchoolSystem.DTO_s;

namespace SchoolSystem.Profiles
{
    public class StudentProfileProfile : Profile
    {
        public StudentProfileProfile() { 
            CreateMap<StudentProfile, StudentProfileDto>().ReverseMap();
            CreateMap<StudentProfile, GetStudentProfileDto>().ReverseMap();
            CreateMap<StudentProfile, UpdateStudentProfileDto>().ReverseMap();
        }
    }
}

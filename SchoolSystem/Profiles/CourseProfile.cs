using AutoMapper;
using SchoolSystem.DTO_s;
using SchoolSystem.Models;

namespace SchoolSystem.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile() {
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Course, UpdateCourseDto>().ReverseMap();
            CreateMap<Course, GetCourseDto>().ReverseMap();
        }
    }
}

using AutoMapper;
using SchoolSystem.DTO_s;
using SchoolSystem.Models;

namespace SchoolSystem.Profiles
{
    public class EnrollmentProfile: Profile
    {
        public EnrollmentProfile() { 
            CreateMap<Enrollment, EnrollmentDto>().ReverseMap();
            CreateMap<Enrollment, GetEnrollmentDto>().ReverseMap();
            CreateMap<Enrollment, UpdateEnrollmentDto>().ReverseMap();
        }
    }
}

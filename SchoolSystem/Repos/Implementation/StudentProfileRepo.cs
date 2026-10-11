using SchoolSystem.Data;
using SchoolSystem.Models;
using SchoolSystem.Repos.Interface;

namespace SchoolSystem.Repos.Implementation
{
    public class StudentProfileRepo : GenericRepo<StudentProfile>, IStudentProfile
    {
        public StudentProfileRepo(SchoolContext context) : base(context)
        {
        }
    }
}

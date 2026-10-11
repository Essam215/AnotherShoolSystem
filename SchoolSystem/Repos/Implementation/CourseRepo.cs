using SchoolSystem.Data;
using SchoolSystem.Models;
using SchoolSystem.Repos.Interface;

namespace SchoolSystem.Repos.Implementation
{
    public class CourseRepo : GenericRepo<Course>, ICourseRepo
    {
        public CourseRepo(SchoolContext context) : base(context)
        {
        }
    }
}

using SchoolSystem.Data;
using SchoolSystem.Models;
using SchoolSystem.Repos.Interface;

namespace SchoolSystem.Repos.Implementation
{
    public class TeacherRepo : GenericRepo<Teacher>, ITeacherRepo
    {
        public TeacherRepo(SchoolContext context) : base(context)
        {
        }
    }
}

using SchoolSystem.Data;
using SchoolSystem.Repos.Interface;

namespace SchoolSystem.Repos.Implementation
{
    public class EnrollmentRepo : GenericRepo<EnrollmentRepo>, IEnrollmentRepo
    {
        public EnrollmentRepo(SchoolContext context) : base(context)
        {
        }
    }
}

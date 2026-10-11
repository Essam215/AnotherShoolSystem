using SchoolSystem.Models;
using SchoolSystem.Repos.Implementation;

namespace SchoolSystem.Repos.Interface
{
    public interface IUnitOfWork
    {
        public ICourseRepo courseRepo { get; }
        public IEnrollmentRepo enrollmentRepo { get; }
        public IStudentRepo studentRepo { get; }
        public IStudentProfile studentProfileRepo { get; }
        public ITeacherRepo teacherRepo { get; } 
        public Task<int> SaveChanges();
       
        
    }
}

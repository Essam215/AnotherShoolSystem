using SchoolSystem.Models;
using SchoolSystem.Repos.Implementation;

namespace SchoolSystem.Repos.Interface
{
    public interface IUnitOfWork
    {
        public IGenericRepo<Course> courseRepo { get; }
        public IGenericRepo<Enrollment> enrollmentRepo { get; }
        public IGenericRepo<Student> studentRepo { get; }
        public IGenericRepo<StudentProfile> studentProfileRepo { get; }
        public IGenericRepo<Teacher> teacherRepo { get; } 
        public Task<int> SaveChanges();
        
    }
}

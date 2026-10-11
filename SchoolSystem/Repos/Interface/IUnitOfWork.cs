using SchoolSystem.Models;
using SchoolSystem.Repos.Implementation;

namespace SchoolSystem.Repos.Interface
{
    public interface IUnitOfWork
    {
<<<<<<< HEAD
        public ICourseRepo courseRepo { get; }
        public IEnrollmentRepo enrollmentRepo { get; }
        public IStudentRepo studentRepo { get; }
        public IStudentProfile studentProfileRepo { get; }
        public ITeacherRepo teacherRepo { get; } 
        public Task<int> SaveChanges();
       
=======
        public IGenericRepo<Course> courseRepo { get; }
        public IGenericRepo<Enrollment> enrollmentRepo { get; }
        public IGenericRepo<Student> studentRepo { get; }
        public IGenericRepo<StudentProfile> studentProfileRepo { get; }
        public IGenericRepo<Teacher> teacherRepo { get; } 
        public Task<int> SaveChanges();
>>>>>>> c333d71e442dd746bc7d66a2c5ac64f88c9c2b3d
        
    }
}

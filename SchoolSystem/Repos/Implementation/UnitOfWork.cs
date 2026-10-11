using Microsoft.Identity.Client;
using SchoolSystem.Data;
using SchoolSystem.Models;
using SchoolSystem.Repos.Interface;

namespace SchoolSystem.Repos.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolContext _context;
<<<<<<< HEAD
        public ICourseRepo courseRepo { get; }
        public IEnrollmentRepo enrollmentRepo { get; }
        public IStudentRepo studentRepo { get; }
        public IStudentProfile studentProfileRepo { get; }
        public ITeacherRepo teacherRepo { get; }

        public UnitOfWork(SchoolContext context, ICourseRepo courseRepo, IEnrollmentRepo enrollmentRepo, IStudentRepo studentRepo, IStudentProfile studentProfileRepo, ITeacherRepo teacherRepo)
=======

        public IGenericRepo<Course> courseRepo { get; }
        public IGenericRepo<Enrollment> enrollmentRepo { get; }
        public IGenericRepo<Student> studentRepo { get; }
        public IGenericRepo<StudentProfile> studentProfileRepo { get; }
        public IGenericRepo<Teacher> teacherRepo { get; }

        public UnitOfWork(
            SchoolContext context,
            IGenericRepo<Course> courseRepo,
            IGenericRepo<Enrollment> enrollmentRepo,
            IGenericRepo<Student> studentRepo,
            IGenericRepo<StudentProfile> studentProfileRepo,
            IGenericRepo<Teacher> teacherRepo)
>>>>>>> c333d71e442dd746bc7d66a2c5ac64f88c9c2b3d
        {
            _context = context;
            this.courseRepo = courseRepo;
            this.enrollmentRepo = enrollmentRepo;
            this.studentRepo = studentRepo;
            this.studentProfileRepo = studentProfileRepo;
            this.teacherRepo = teacherRepo;
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

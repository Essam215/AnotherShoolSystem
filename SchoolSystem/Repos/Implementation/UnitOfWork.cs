using Microsoft.Identity.Client;
using SchoolSystem.Data;
using SchoolSystem.Models;
using SchoolSystem.Repos.Interface;

namespace SchoolSystem.Repos.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolContext _context;

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

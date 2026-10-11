using Microsoft.Identity.Client;
using SchoolSystem.Data;
using SchoolSystem.Models;
using SchoolSystem.Repos.Interface;

namespace SchoolSystem.Repos.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolContext _context;
        public ICourseRepo courseRepo { get; }
        public IEnrollmentRepo enrollmentRepo { get; }
        public IStudentRepo studentRepo { get; }
        public IStudentProfile studentProfileRepo { get; }
        public ITeacherRepo teacherRepo { get; }

        public UnitOfWork(SchoolContext context, ICourseRepo courseRepo, IEnrollmentRepo enrollmentRepo, IStudentRepo studentRepo, IStudentProfile studentProfileRepo, ITeacherRepo teacherRepo)
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

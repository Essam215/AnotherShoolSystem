using Microsoft.EntityFrameworkCore;
using SchoolSystem.Models;

namespace SchoolSystem.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasOne(s => s.StudentProfile).WithOne(s => s.Student).HasForeignKey<StudentProfile>(s => s.StudentId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Teacher>().HasMany(s => s.Courses).WithOne(s => s.Teacher).HasForeignKey(s => s.TeacherId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Student>().HasMany(s => s.Enrollments).WithOne(s => s.Student).HasForeignKey(s => s.StudentId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Course>().HasMany(s => s.Enrollments).WithOne(s => s.Course).HasForeignKey(s => s.CourseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}

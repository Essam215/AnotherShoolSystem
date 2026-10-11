using Microsoft.EntityFrameworkCore;
using SchoolSystem.Models;

namespace SchoolSystem.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

<<<<<<< HEAD
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<StudentProfile> StudentProfiles { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

=======
>>>>>>> c333d71e442dd746bc7d66a2c5ac64f88c9c2b3d
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasOne(s => s.StudentProfile).WithOne(s => s.Student).HasForeignKey<StudentProfile>(s => s.StudentId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Teacher>().HasMany(s => s.Courses).WithOne(s => s.Teacher).HasForeignKey(s => s.TeacherId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Student>().HasMany(s => s.Enrollments).WithOne(s => s.Student).HasForeignKey(s => s.StudentId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Course>().HasMany(s => s.Enrollments).WithOne(s => s.Course).HasForeignKey(s => s.CourseId).OnDelete(DeleteBehavior.Restrict);
<<<<<<< HEAD

            modelBuilder.Entity<Student>().HasData(

                new Student
                {
                    Id = 1,
                    BirthDate = new DateTime(2011, 5, 05),
                    Email = "adel@email.com",
                    FullName = "Dola",
                    Gender = "male",
                    Phone = "01143266119",


                },
                new Student
                {
                    Id = 2,
                    BirthDate = new DateTime(2011, 5, 05),
                    Email = "Essam@email.com",
                    FullName = "Essam ",
                    Gender = "Male",
                    Phone = "01068001912",


                }

                );

=======
>>>>>>> c333d71e442dd746bc7d66a2c5ac64f88c9c2b3d
        }
    }
}

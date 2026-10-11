using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SchoolSystem.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100), MinLength(3)]
        public string FullName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Gender { get; set; }
        public StudentProfile StudentProfile { get; set; }
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}

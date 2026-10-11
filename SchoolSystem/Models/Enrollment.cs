using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Identity.Client;

namespace SchoolSystem.Models
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }
        [Required, ForeignKey("StudentId")]
        public int StudentId { get; set; }
        [Required, ForeignKey("CourseId")]
        public int CourseId { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }
        [Range(0, 100)]
        public decimal ? Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}

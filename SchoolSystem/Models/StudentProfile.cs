using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Models
{
    public class StudentProfile
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(200)]
        public string Address { get; set; }
        [Phone, Required]
        public string ParentPhone { get; set; }
        [Phone, Required]
        public string EmergencyContact { get; set; }
        [ForeignKey("StudentId")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        
    }
}

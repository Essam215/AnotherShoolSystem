using SchoolSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.DTO_s;
    public class EnrollmentDto
    {
   
    [Required, ForeignKey("StudentId")]
    public int StudentId { get; set; }
    [Required, ForeignKey("CourseId")]
    public int CourseId { get; set; }
    [Required]
    public DateTime EnrollmentDate { get; set; }
    [Range(0, 100)]
    public decimal? Grade { get; set; }
  
}

public class GetEnrollmentDto
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
    public decimal? Grade { get; set; }

}

public class UpdateEnrollmentDto
{
<<<<<<< HEAD
  
=======
    [Key]
    public int Id { get; set; }
>>>>>>> c333d71e442dd746bc7d66a2c5ac64f88c9c2b3d
    [Required, ForeignKey("StudentId")]
    public int StudentId { get; set; }
    [Required, ForeignKey("CourseId")]
    public int CourseId { get; set; }
    [Required]
    public DateTime EnrollmentDate { get; set; }
    [Range(0, 100)]
    public decimal? Grade { get; set; }

}
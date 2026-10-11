using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.DTO_s;
    public class CourseDto
    {
  
    [Required, MinLength(3), MaxLength(100)]
    public string Title { get; set; }
    [Required, Range(1, 6)]
    public int CreditHours { get; set; }
    [ForeignKey("TeacherId")]
    public int TeacherId { get; set; }
}

public class GetCourseDto
{
    [Key]
    public int Id { get; set; }
    [Required, MinLength(3), MaxLength(100)]
    public string Title { get; set; }
    [Required, Range(1, 6)]
    public int CreditHours { get; set; }
    [ForeignKey("TeacherId")]
    public int TeacherId { get; set; }
}
public class UpdateCourseDto
{
<<<<<<< HEAD
=======
    [Key]
    public int Id { get; set; }
>>>>>>> c333d71e442dd746bc7d66a2c5ac64f88c9c2b3d
    [Required, MinLength(3), MaxLength(100)]
    public string Title { get; set; }
    [Required, Range(1, 6)]
    public int CreditHours { get; set; }
    [ForeignKey("TeacherId")]
    public int TeacherId { get; set; }
}
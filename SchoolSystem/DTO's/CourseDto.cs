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
    [Key]
    public int Id { get; set; }
    [Required, MinLength(3), MaxLength(100)]
    public string Title { get; set; }
    [Required, Range(1, 6)]
    public int CreditHours { get; set; }
    [ForeignKey("TeacherId")]
    public int TeacherId { get; set; }
}
using SchoolSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.DTO_s;
    public class StudentProfileDto
    {
   
    [Required, MaxLength(200)]
    public string Address { get; set; }
    [Phone, Required]
    public string ParentPhone { get; set; }
    [Phone, Required]
    public string EmergencyContact { get; set; }
    [ForeignKey("StudentId")]
    public int StudentId { get; set; }
}
    public class GetStudentProfileDto
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
}

public class UpdateStudentProfileDto
{
  
    [Required, MaxLength(200)]
    public string Address { get; set; }
    [Phone, Required]
    public string ParentPhone { get; set; }
    [Phone, Required]
    public string EmergencyContact { get; set; }
    [ForeignKey("StudentId")]
    public int StudentId { get; set; }
}
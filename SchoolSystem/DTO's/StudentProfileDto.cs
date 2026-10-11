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
<<<<<<< HEAD
  
=======
    [Key]
    public int Id { get; set; }
>>>>>>> c333d71e442dd746bc7d66a2c5ac64f88c9c2b3d
    [Required, MaxLength(200)]
    public string Address { get; set; }
    [Phone, Required]
    public string ParentPhone { get; set; }
    [Phone, Required]
    public string EmergencyContact { get; set; }
    [ForeignKey("StudentId")]
    public int StudentId { get; set; }
}
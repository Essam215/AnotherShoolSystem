using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.DTO_s;

    public class TeacherDto
    {
    [Required, MinLength(3), MaxLength(100)]
    public string FullName { get; set; }
    [Required, EmailAddress]
    public string Email { get; set; }
    [Required, Phone]
    public string Phone { get; set; }
    [Required]
    public DateTime HireDate { get; set; }
}
    public class GetTeacherDto
{
    [Key]
    public int Id { get; set; }
    [Required, MinLength(3), MaxLength(100)]
    public string FullName { get; set; }
    [Required, EmailAddress]
    public string Email { get; set; }
    [Required, Phone]
    public string Phone { get; set; }
    [Required]
    public DateTime HireDate { get; set; }
}
public class UpdateTeacherDto
{
<<<<<<< HEAD
  
=======
    [Key]
    public int Id { get; set; }
>>>>>>> c333d71e442dd746bc7d66a2c5ac64f88c9c2b3d
    [Required, MinLength(3), MaxLength(100)]
    public string FullName { get; set; }
    [Required, EmailAddress]
    public string Email { get; set; }
    [Required, Phone]
    public string Phone { get; set; }
    [Required]
    public DateTime HireDate { get; set; }
}


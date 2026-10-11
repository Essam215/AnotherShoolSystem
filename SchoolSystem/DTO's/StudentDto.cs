using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.DTO_s;

    public class StudentDto
    {
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
}
public class GetStudentDto
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
}
public class UpdateStudentDto
{
<<<<<<< HEAD
=======
    [Key]
    public int Id { get; set; }
>>>>>>> c333d71e442dd746bc7d66a2c5ac64f88c9c2b3d
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
}
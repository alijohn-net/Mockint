using System.ComponentModel.DataAnnotations;

namespace AbuInt.Service.DTOs.Users;

public class UserForResertPasswordDto
{
    [Required(ErrorMessage = "Email is required")]
    [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
        ErrorMessage = "Please enter valid email")]
    public string Email { get; set; }

    [Required]
    public string Code { get; set; }

    [Required(ErrorMessage = "Password is required"),DataType(DataType.Password)]
    public string Password { get; set; }
}
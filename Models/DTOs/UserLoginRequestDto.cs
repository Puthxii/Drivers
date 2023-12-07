using System.ComponentModel.DataAnnotations;

namespace Drivers.Api.Models.DTOs;

public class UserLoginRequestDto
{
    [Required]
    public string Email { set; get; } = string.Empty;
    [Required]
    public string Password { set; get; } = string.Empty;
}

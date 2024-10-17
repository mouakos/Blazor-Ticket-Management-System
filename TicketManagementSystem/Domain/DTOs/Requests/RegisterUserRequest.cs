using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Requests;

public class RegisterUserRequest
{
    #region Public properties declaration

    [Required] public string? Email { get; set; }
    [Required] public string? Role { get; set; }

    #endregion
}
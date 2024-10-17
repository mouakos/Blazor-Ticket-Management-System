using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Requests;

public class RegisterUserRequest
{
    #region Public properties declaration

    [Required] [EmailAddress] public string? Email { get; set; }
    [Required] public string? Role { get; set; }

    #endregion
}
using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Requests;

public class ChangePasswordRequest
{
    #region Public properties declaration

    [Required] public string? ConfirmNewPassword { get; set; }
    [Required] public string? CurrentPassword { get; set; }
    [Required] public string? NewPassword { get; set; }

    #endregion
}
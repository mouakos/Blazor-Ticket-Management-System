using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Requests;

public class ChangePasswordRequest
{
    #region Public properties declaration

    [Required]
    [DataType(DataType.Password)]
    [Compare(nameof(NewPassword))]
    public string? ConfirmNewPassword { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string? CurrentPassword { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string? NewPassword { get; set; }

    #endregion
}
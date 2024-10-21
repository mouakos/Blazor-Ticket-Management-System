using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.Requests;

public class ChangePasswordRequest
{
    #region Public properties declaration

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm new password")]
    [Compare(nameof(NewPassword), ErrorMessage = "Confirm new password does not match")]
    public string? ConfirmNewPassword { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Current password")]
    public string? CurrentPassword { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "New password")]
    public string? NewPassword { get; set; }

    #endregion
}
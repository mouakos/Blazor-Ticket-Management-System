using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class User : IdentityUser
{
	#region Public properties declaration

	public bool AccountConfirmed { get; set; }
	public string? Avatar { get; set; }
	public bool IsDeleted { get; set; }

	#endregion
}
using System.Security.Claims;
using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using Infrastructure.Common;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Services;

public class AccountService(
    SignInManager<User> signInManager,
    IUnitOfWork unitOfWork,
    IHttpContextAccessor httpContextAccessor,
    IWebHostEnvironment webHostEnvironment) : IAccountService
{
    #region Public methods declaration

    /// <inheritdoc />
    public async Task<BaseResponse> ChangePasswordAsync(ChangePasswordRequest request)
    {
        var response = new BaseResponse
        {
            IsSuccess = false
        };

        var user = await GetCurrentUserAsync();
        if (!user.IsSuccess)
        {
            response.ErrorMessage = user.ErrorMessage;
            return response;
        }

        var changePasswordResult =
            await signInManager.UserManager.ChangePasswordAsync(user.Value, request.CurrentPassword,
                request.NewPassword);
        if (changePasswordResult.Succeeded)
        {
            response.IsSuccess = true;

            //confirm account
            await ConfirmAccountAsync(user.Value);
        }
        else
        {
            response.ErrorMessage = changePasswordResult.Errors.FirstOrDefault()?.Description;
        }

        return response;
    }

    /// <inheritdoc />
    public async Task<BaseResponse<User>> GetCurrentUserAsync()
    {
        var response = new BaseResponse<User>
        {
            IsSuccess = false
        };

        var currentUser = httpContextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?
            .Value;
        if (currentUser == null)
        {
            response.ErrorMessage = "Invalid User Account!";
            return response;
        }

        var user = await signInManager.UserManager.FindByEmailAsync(currentUser);
        if (user == null)
        {
            response.ErrorMessage = "Invalid User Account!";
            return response;
        }

        response.IsSuccess = true;
        response.Value = user;
        return response;
    }

    /// <inheritdoc />
    public async Task<List<UserResponse>> GetUsersAsync()
    {
        var roles = (await unitOfWork.Repository<IdentityUserRole<string>>().GetAllAsync())
            .Select(x => new
            {
                x.UserId,
                x.RoleId,
                Role = Constants.UserRoles[x.RoleId]
            });

        return (await unitOfWork.Repository<User>().GetAllAsync())
            .Where(x => x.IsDeleted == false)
            .Select(x => new UserResponse
            {
                Id = x.Id,
                Email = x.Email,
                Avatar = x.Avatar,
                Role = roles.FirstOrDefault(r => r.UserId == x.Id)?.Role,
                AccountConfirmed = x.AccountConfirmed
            }).ToList();
    }

    /// <inheritdoc />
    public async Task<BaseResponse> RegisterUserAsync(RegisterUserRequest request)
    {
        var user = new User { UserName = request.Email, Email = request.Email };
        var result = await signInManager.UserManager.CreateAsync(user, Constants.c_DefaultPassword);
        if (!result.Succeeded)
            return new BaseResponse
            {
                IsSuccess = false,
                ErrorMessage = result.Errors.FirstOrDefault()?.Description
            };
        await signInManager.UserManager.AddToRoleAsync(user, request.Role);

        return new BaseResponse
        {
            IsSuccess = true
        };
    }

    /// <inheritdoc />
    public async Task<BaseResponse> RemoveUserAsync(string email)
    {
        var response = new BaseResponse
        {
            IsSuccess = false
        };

        var user = await signInManager.UserManager.FindByEmailAsync(email);
        if (user == null)
        {
            response.ErrorMessage = "User not found! - " + email;
            return response;
        }

        user.IsDeleted = true;
        var result = await signInManager.UserManager.UpdateAsync(user);
        if (!result.Succeeded)
        {
            response.ErrorMessage = result.Errors.FirstOrDefault()?.Description;
            return response;
        }

        response.IsSuccess = true;
        return response;
    }

    /// <inheritdoc />
    public async Task<BaseResponse> ResetAvatarAsync()
    {
        var response = new BaseResponse
        {
            IsSuccess = false
        };
        var uploadPath = Path.Combine(webHostEnvironment.WebRootPath, "uploads", "avatars");

        var currentUser = await GetCurrentUserAsync();
        if (!currentUser.IsSuccess)
        {
            response.ErrorMessage = currentUser.ErrorMessage;
            return response;
        }

        if (currentUser.Value?.Avatar == Constants.c_DefaultAvatar) return response;
        var previousAvatar = currentUser.Value?.Avatar;

        if (!string.IsNullOrEmpty(previousAvatar))
        {
            previousAvatar = Path.Combine(uploadPath, previousAvatar);
            if (File.Exists(previousAvatar)) File.Delete(previousAvatar);
        }

        currentUser.Value.Avatar = Constants.c_DefaultAvatar;
        var updateResult = await signInManager.UserManager.UpdateAsync(currentUser.Value);
        if (updateResult.Succeeded)
            response.IsSuccess = true;
        else
            response.ErrorMessage = updateResult.Errors.FirstOrDefault()?.Description;

        return response;
    }

    /// <inheritdoc />
    public async Task<BaseResponse<string>> UploadAvatarAsync(IBrowserFile image)
    {
        var response = new BaseResponse<string>
        {
            IsSuccess = false
        };
        var uploadPath = Path.Combine(webHostEnvironment.WebRootPath, "uploads", "avatars");


        var currentUser = await GetCurrentUserAsync();
        if (!currentUser.IsSuccess)
        {
            response.ErrorMessage = currentUser.ErrorMessage;
            return response;
        }

        if (image == null) return response;
        if (!Directory.Exists(uploadPath)) Directory.CreateDirectory(uploadPath);

        if (currentUser.Value?.Avatar != null && currentUser.Value.Avatar != Constants.c_DefaultAvatar)
        {
            var previousAvatar = currentUser.Value.Avatar;
            previousAvatar = Path.Combine(uploadPath, previousAvatar);
            if (File.Exists(previousAvatar)) File.Delete(previousAvatar);
        }

        var fileExtension = Path.GetExtension(image.Name);

        var fileName = $"{currentUser.Value?.Email}{fileExtension}";
        var filePath = Path.Combine(uploadPath, fileName);

        await using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            await image.OpenReadStream().CopyToAsync(fileStream);
        }

        currentUser.Value.Avatar = fileName;

        var updateResult = await signInManager.UserManager.UpdateAsync(currentUser.Value);
        if (updateResult.Succeeded)
        {
            response.IsSuccess = true;
            response.Value = fileName;
        }
        else
        {
            response.ErrorMessage = updateResult.Errors.FirstOrDefault()?.Description;
        }

        return response;
    }

    /// <inheritdoc />
    public async Task<BaseResponse<string>> VerifyUserAsync(string email, string password)
    {
        var user = await signInManager.UserManager.FindByEmailAsync(email);
        if (user is null || user.IsDeleted)
            return new BaseResponse<string> { IsSuccess = false, ErrorMessage = "Invalid Email / password" };

        var result = await signInManager.UserManager.CheckPasswordAsync(user, password);
        return !result
            ? new BaseResponse<string> { IsSuccess = false, ErrorMessage = "Invalid Email / password" }
            : new BaseResponse<string> { IsSuccess = true, Value = user.UserName };
    }

    #endregion

    #region Private methods declaration

    private async Task ConfirmAccountAsync(User user)
    {
        if (user.AccountConfirmed == false)
        {
            user.AccountConfirmed = true;

            unitOfWork.Repository<User>().Update(user);
            await unitOfWork.SaveChangesAsync();
        }
    }

    #endregion
}
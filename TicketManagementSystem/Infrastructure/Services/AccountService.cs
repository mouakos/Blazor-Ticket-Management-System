using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using Infrastructure.Common;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Services;

public class AccountService(SignInManager<User> signInManager, IUnitOfWork unitOfWork) : IAccountService
{
    #region Public methods declaration

    /// <inheritdoc />
    public List<UserResponse> GetUsers()
    {
        return unitOfWork.Repository<User>().GetAll().Select(x => new UserResponse
        {
            Id = x.Id,
            Email = x.Email,
            Avatar = x.Avatar
        }).ToList();
    }

    /// <inheritdoc />
    public async Task<BaseResponse> RegisterUserAsync(RegisterUserRequest request)
    {
        var user = new User { UserName = request.Email, Email = request.Email };
        var result = await signInManager.UserManager.CreateAsync(user, Constants.c_DefaultPassword);
        return result.Succeeded
            ? new BaseResponse { IsSuccess = true }
            : new BaseResponse { IsSuccess = false, ErrorMessage = result.Errors.FirstOrDefault()?.Description };
    }

    /// <inheritdoc />
    public async Task<BaseResponse<string>> VerifyUserAsync(string email, string password)
    {
        var user = await signInManager.UserManager.FindByEmailAsync(email);
        if (user is null) return new BaseResponse<string> { IsSuccess = false, ErrorMessage = "User not found" };

        var result = await signInManager.UserManager.CheckPasswordAsync(user, password);
        return !result
            ? new BaseResponse<string> { IsSuccess = false, ErrorMessage = "Invalid Email / password" }
            : new BaseResponse<string> { IsSuccess = true, Value = user.UserName };
    }

    #endregion
}
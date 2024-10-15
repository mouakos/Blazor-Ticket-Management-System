using Domain.DTOs.Requests;
using Domain.DTOs.Responses;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Common;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Services;

public class AccountService(SignInManager<User> signInManager) : IAccountService
{
    /// <inheritdoc />
    public async Task<BaseResponse<string>> VerifyUser(string email, string password)
    {
        var user = await signInManager.UserManager.FindByEmailAsync(email);
        if (user is null) return new BaseResponse<string> { IsSuccess = false, ErrorMessage = "User not found" };

        var result = await signInManager.UserManager.CheckPasswordAsync(user, password);
        return !result
            ? new BaseResponse<string> { IsSuccess = false, ErrorMessage = "Invalid Email / password" }
            : new BaseResponse<string> { IsSuccess = true, Value = user.UserName };
    }

    /// <inheritdoc />
    public async Task<BaseResponse> RegisterUser(RegisterUserRequest request)
    {
        var user = new User { UserName = request.Email, Email = request.Email };
        var result = await signInManager.UserManager.CreateAsync(user, Constants.c_DefaultPassword);
        return result.Succeeded
            ? new BaseResponse { IsSuccess = true }
            : new BaseResponse { IsSuccess = false, ErrorMessage = result.Errors.FirstOrDefault()?.Description };
    }
}
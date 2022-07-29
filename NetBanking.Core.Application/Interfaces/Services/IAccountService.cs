﻿using NetBanking.Core.Application.Dtos.Account;
using NetBanking.Core.Application.ViewModels.Roles;
using NetBanking.Core.Application.ViewModels.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.Interfaces.Services
{
    public interface IAccountService
    {
        Task<List<UsersViewModel>> GetUsersAsync();
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<string> ConfirmAccountAsync(string userId, string token);
        Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest request, string origin);
        Task<RegisterResponse> RegisterBasicUserAsync(RegisterRequest request, string origin);
        Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest request);
        Task SignOutAsync();
        Task<List<RolesViewModel>> GetAllRoles();
        Task<UsersViewModel> GetUserByIdAsync(string Id);
        Task Delete(string id);
    }
}
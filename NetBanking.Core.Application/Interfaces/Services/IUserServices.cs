using NetBanking.Core.Application.Dtos.Account;
using NetBanking.Core.Application.ViewModels.Users;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.Interfaces.Services
{
    public interface IUserServices
    {
        Task<string> ConfirmEmailAsync(string userId, string token);
        //Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordViewModel vm, string origin);
        Task<AuthenticationResponse> LoginAsync(LoginUsersViewModel vm);
        Task<RegisterResponse> RegisterAsync(SaveUsersViewModel vm, string origin);
        //Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordViewModel vm);
        Task SignOutAsync();
    }
}
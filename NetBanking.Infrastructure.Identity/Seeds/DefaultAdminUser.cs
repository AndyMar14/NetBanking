using Microsoft.AspNetCore.Identity;
using NetBanking.Core.Application.Enums;
using NetBanking.Infrastructure.Identity.Entities;
using System.Threading.Tasks;

namespace NetBanking.Infrastructure.Identity.Seeds
{
    public static class DefaultAdminUser
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Client.ToString()));
        }
    }
}

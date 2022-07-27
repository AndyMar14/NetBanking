using NetBanking.Core.Application.ViewModels.Products;
using NetBanking.Core.Application.ViewModels.Recipients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Users
{
    public class UsersViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string Identification { get; set; }
        public List<RoleViewModel> Type { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }

        public ICollection<ProductsViewModel> Products { get; set; }
        public ICollection<RecipientsViewModel> Recipients { get; set; }



    }
}

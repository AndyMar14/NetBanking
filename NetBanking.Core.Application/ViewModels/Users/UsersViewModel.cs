using NetBanking.Core.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Users
{
    public class UsersViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string Identification { get; set; }
        public string Type { get; set; }
        public string InitialAmount { get; set; }
        public string Phone { get; set; }


        //Products

        public int ProductId { get; set; }
        public string ProductType { get; set; }
        public int ProductIdentifier { get; set; }
        public double CreditLimit { get; set; }
        public double LoanAmount { get; set; }

        public ProductsViewModel Products { get; set; }



    }
}

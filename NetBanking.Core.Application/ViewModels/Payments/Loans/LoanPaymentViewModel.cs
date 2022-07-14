using NetBanking.Core.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Payments.Loans
{
    public class LoanPaymentViewModel
    {
        public int LoanProductId { get; set; }
        public int LoanProductTypeIdentifier { get; set; }
        public int AccountProductId { get; set; }
        public int AccountProductIdentifier { get; set; }
        public double Amount { get; set; }

        public ProductsViewModel Products { get; set; }
    }
}

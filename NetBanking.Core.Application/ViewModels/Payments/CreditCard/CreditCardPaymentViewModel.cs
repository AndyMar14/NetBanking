using NetBanking.Core.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Payments.CreditCard
{
    public class CreditCardPaymentViewModel
    {
        public int CreditCardProductId { get; set; }
        public int CreditCardProductTypeIdentifier { get; set; }
        public int AccountProductId { get; set; }
        public int AccountProductIdentifier { get; set; }    
        public double Amount { get; set; }

        public ProductsViewModel Products { get; set; }
    }
}

using NetBanking.Core.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Payments.ExpressPayment
{
    public class ExpressPaymentViewModel
    {
        public int SourceProductId { get; set; }
        public string SourceProductIdentifier { get; set; }
        public int TargetProductId { get; set; }
        public string TargetProductIdentifier { get; set; }
        public double Amount { get; set; }

        public ProductsViewModel Products { get; set; }
    }
}

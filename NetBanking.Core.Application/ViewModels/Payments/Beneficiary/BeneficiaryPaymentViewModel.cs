using NetBanking.Core.Application.ViewModels.Beneficiaries;
using NetBanking.Core.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Payments.Beneficiary
{
    public class BeneficiaryPaymentViewModel
    {
        public int BeneficiaryId { get; set; }
        public string BeneficiaryName { get; set; }
        public int ProductId { get; set; }
        public int ProductIdentifier { get; set; }
        public double Amount { get; set; }

        public BeneficiariesViewModel Beneficiaries { get; set; }
        public ProductsViewModel Products { get; set; }
    }
}

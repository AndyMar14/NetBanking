using NetBanking.Core.Application.ViewModels.CashAdvances;
using NetBanking.Core.Application.ViewModels.Payments.Beneficiary;
using NetBanking.Core.Application.ViewModels.Payments.CreditCard;
using NetBanking.Core.Application.ViewModels.Payments.ExpressPayment;
using NetBanking.Core.Application.ViewModels.Payments.Loans;
using NetBanking.Core.Application.ViewModels.Transactions;
using NetBanking.Core.Application.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Products
{
    public class ProductsViewModel
    {
        public string ProductType { get; set; }
        public int ProductIdentifier { get; set; }
        public double CreditLimit { get; set; }
        public double LoanAmount { get; set; }

        public ICollection<BeneficiaryPaymentViewModel> Beneficiary { get; set; }
        public ICollection<CreditCardPaymentViewModel> CreditCard { get; set; }
        public ICollection<LoanPaymentViewModel> Loan { get; set; }
        public ICollection<ExpressPaymentViewModel> Express { get; set; }
        public ICollection<TransactionsViewModel> Transactions { get; set; }
        public ICollection<CashAdvancesViewModel> CrashAdvances { get; set; }
        public ICollection<UsersViewModel> User { get; set; }


    }
}

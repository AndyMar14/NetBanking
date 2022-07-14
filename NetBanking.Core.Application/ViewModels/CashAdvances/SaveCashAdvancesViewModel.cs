using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.CashAdvances
{
    public class SaveCashAdvancesViewModel
    {
        public int CreditCardId { get; set; }
        public int CreditCardIdentifier { get; set; }
        public int AccountId { get; set; }
        public int AccountIdentifier { get; set; }
        public double Amount { get; set; }
    }
}

using NetBanking.Core.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Transactions
{
    public class TransactionsViewModel
    {
        public int SourceAccountId { get; set; }
        public int SourceAccountIdentifier { get; set; }
        public int TargetAccountId { get; set; }
        public int TargetAccountIdentifier { get; set; }
        public double Amount { get; set; }

        public ProductsViewModel Products { get; set; }

    }
}

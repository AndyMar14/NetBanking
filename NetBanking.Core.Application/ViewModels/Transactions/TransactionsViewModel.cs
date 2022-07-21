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
        public int UserProductId { get; set; }
        public int RecipientProductId { get; set; }
        public int Type { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public ProductsViewModel ProductFrom { get; set; }
        public ProductsViewModel ProductTo { get; set; }

    }
}

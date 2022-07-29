using NetBanking.Core.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.BankProducts
{
    public class BankProductsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductsViewModel> Products { get; set; }
    }
}

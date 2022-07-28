using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetBanking.Core.Application.ViewModels.BankProducts;
using NetBanking.Core.Application.ViewModels.Products;
using NetBanking.Core.Domain.Entities;

namespace NetBanking.Core.Application.Interfaces.Services
{
    public interface IBankProductsServices : IGenericService<SaveBankProductsViewModel, BankProductsViewModel, BankProducts>
    {
    }
}

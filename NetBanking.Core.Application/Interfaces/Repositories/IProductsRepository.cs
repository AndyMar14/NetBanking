using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetBanking.Core.Application.ViewModels.Products;
using NetBanking.Core.Domain.Entities;

namespace NetBanking.Core.Application.Interfaces.Repositories
{
    public interface IProductsRepository : IGenericRepository<Products>
    {
        Task<ProductsViewModel> GetProductByIdentifier(string Identifire);
        Task<SaveProductsViewModel> GetMainByUser(string Id);
    }
}

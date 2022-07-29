using Application.Repository;
using Microsoft.EntityFrameworkCore;
using NetBanking.Core.Application.Interfaces.Repositories;
using NetBanking.Core.Application.ViewModels.Products;
using NetBanking.Core.Domain.Entities;
using NetBanking.Infrastructure.Persistence.Contexts;
using System.Threading.Tasks;

namespace NetBanking.Infrastructure.Persistence.Repositories
{
    public class ProductsRepository : GenericRepository<Products>,IProductsRepository
    {
        private readonly ApplicationContext _dbContext;
        public ProductsRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProductsViewModel> GetProductByIdentifier(string Identifire)
        {
            Products product = await _dbContext.Set<Products>()
             .FirstOrDefaultAsync(p => p.Identifier == Identifire);
            ProductsViewModel productVm = new();
            if (product != null)
            {
                
                productVm.Identifier = product.Identifier;
                productVm.IdUser = product.IdUser;
            }
            return productVm;
        }

        public async Task<SaveProductsViewModel> GetMainByUser(string Id)
        {
            Products product = await _dbContext.Set<Products>()
             .FirstOrDefaultAsync(p => p.IdUser == Id && p.MainProduct == 1);
            SaveProductsViewModel productVm = new();
            if (product != null)
            {

                productVm.Identifier = product.Identifier;
                productVm.IdUser = product.IdUser;
                productVm.Balance = product.Balance;
                productVm.MainProduct = product.MainProduct;
                productVm.IdProducType = product.IdProducType;
                productVm.Identifier = product.Identifier;
                productVm.Balance = product.Balance;
                productVm.Limit = product.Limit;
                productVm.Amount = product.Monto;
            }
            return productVm;
        }
    }
}

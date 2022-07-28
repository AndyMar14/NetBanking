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

        public async Task<ProductsViewModel> GetProductByIdentifier(int Identifire)
        {
            Products product = await _dbContext.Set<Products>()
             .FirstOrDefaultAsync(p => p.Identifier == Identifire);
            ProductsViewModel productVm = new();
            if (product != null)
            {
                
                productVm.ProductIdentifier = product.Identifier;
                productVm.UserId = product.IdUser;
            }
            return productVm;
        }
    }
}

using Application.Repository;
using Microsoft.EntityFrameworkCore;
using NetBanking.Core.Application.Interfaces.Repositories;
using NetBanking.Core.Application.ViewModels.BankProducts;
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
                productVm.Amount = product.Amount;
            }
            else
            {
                productVm.HasError = true;
                productVm.ErrorMessage = "La cuenta no existe";
            }
            return productVm;
        }
        public async Task<string> GetProductType (int Type)
        {
            BankProducts product = await _dbContext.Set<BankProducts>()
             .FirstOrDefaultAsync(p => p.Id == Type);

            BankProductsViewModel productVm = new();
            if (product != null)
            {
                productVm.Name = product.Name;
            }
           
            return productVm.Name;
        }
    }
}

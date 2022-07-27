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
        Task<Users> GetByNameAsync(SaveProductsViewModel amigoVm);
        Task<Products> GetRelationship(int UserId, int ProductId);
        Task<Products> GetRelationshipId(int UserId, int ProductId);
    }
}

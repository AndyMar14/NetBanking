using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetBanking.Core.Application.ViewModels.Products;
using NetBanking.Core.Domain.Entities;

namespace NetBanking.Core.Application.Interfaces.Services
{
    public interface IProductsService : IGenericService<SaveProductsViewModel, ProductsViewModel, Products>
    {
        Task<Users> GetUser(SaveProductsViewModel vm);
        Task<List<ProductsViewModel>> GetAllProductsWithIncludes();
        Task<bool> GetRelationship(int UserId, int ProductId);
        Task<Products> GetRelationshipId(int UserId, int ProductId);
    }
}

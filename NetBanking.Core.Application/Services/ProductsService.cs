using AutoMapper;
using Microsoft.AspNetCore.Http;
using NetBanking.Core.Application.Helpers;
using NetBanking.Core.Application.Interfaces.Repositories;
using NetBanking.Core.Application.Interfaces.Services;
using NetBanking.Core.Application.ViewModels.Products;
using NetBanking.Core.Application.ViewModels.Users;
using NetBanking.Core.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.Services
{
    public class ProductsService : GenericService<SaveProductsViewModel, ProductsViewModel, Products>, IProductsService
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UsersViewModel usersViewModel;
        public ProductsService(IProductsRepository productsRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(productsRepository, mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            usersViewModel = _httpContextAccessor.HttpContext.Session.Get<UsersViewModel>("user");
        }
        public override async Task<SaveProductsViewModel> Add(SaveProductsViewModel vm)
        {
            SaveProductsViewModel productsVm = await base.Add(vm);

            return productsVm;
        }
        public async Task<List<ProductsViewModel>> GetAllProductsWithIncludes()
        {
            var productsList = await _productsRepository.GetAllWithIncludeAsync(new List<string> { "Products", "Users" });

            return productsList.Where(products => products.IdUser == usersViewModel.Id).Select(products => new ProductsViewModel
            {
                MainProduct = products.MainProduct,
                ProductIdentifier = products.Identifier,
                CreditLimit = products.Limit,
                LoanAmount = products.Monto,
                Balance = products.Balance
            }).ToList();
        }
    }
}

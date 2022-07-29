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
            if (vm.IdProducType == 3)
            {
                SaveProductsViewModel main = new();

                main = await GetMainByUser(vm.IdUser);
                main.Amount += vm.Amount;
                await base.Update(main, main.Id);
            }

            SaveProductsViewModel productsVm = await base.Add(vm);
            return productsVm;
        }

        public async Task<SaveProductsViewModel> GetMainByUser(string Id)
        {
            var product = await _productsRepository.GetMainByUser(Id);
            return product;
        }


        public async Task<List<ProductsViewModel>> GetAllProductsWithIncludes()
        {
            var productsList = await _productsRepository.GetAllWithIncludeAsync(new List<string> { "Products", "Users" });

            return productsList.Where(products => products.IdUser == usersViewModel.Id).Select(products => new ProductsViewModel
            {
                MainProduct = products.MainProduct,
                Identifier = products.Identifier,
                Limit = products.Limit,
                Amount = products.Amount,
                Balance = products.Balance
            }).ToList();
        }

        public async Task<List<ProductsViewModel>> GetAllProductsWithIncludesAdmin(string ClientId)
        {
            var productsList = await _productsRepository.GetAllWithIncludeAsync(new List<string> { "Produc" });

            return productsList.Where(products => products.IdUser == ClientId.ToString()).Select(products => new ProductsViewModel
            {
                MainProduct = products.MainProduct,
                Identifier = products.Identifier,
                Limit = products.Limit,
                Amount = products.Amount,
                ProductName = products.Produc.Name,
                Balance = products.Balance
            }).ToList();
        }

        public async Task<ProductsViewModel> GetProductByIdentifier(string Identifire)
        {
            var product = await _productsRepository.GetProductByIdentifier(Identifire);
            return product;

        }

        public async Task<List<ProductsViewModel>> GetAllProductsByIdUser(string Id, FilterProductViewModel filters)
        {
            var productsList = await _productsRepository.GetAllAsync();
            var products = productsList.Where(products => products.IdUser == Id).Select(products => new ProductsViewModel
            {
                IdUser = products.IdUser,
                MainProduct = products.MainProduct,
                Identifier = products.Identifier,
                Limit = products.Limit,
                Amount = products.Amount,
                Balance = products.Balance,
                IdProductType = products.IdProducType
            }).ToList();

            if (filters.Type != null)
            {
                products = products.Where(product => product.IdProductType == filters.Type.Value).ToList();
            }

            foreach (var p in products)
            {
                var type = await _productsRepository.GetProductType(p.IdProductType);
                p.ProductType = type;
            }
            return products;

        }

        public async Task<string> GenerateSequence()
        {
            var productsList = await _productsRepository.GetAllAsync();
            if (productsList.Count > 0)
            {
                int LastProductId = productsList.OrderByDescending(x => x.Id).ThenByDescending(x => x.Id).FirstOrDefault().Id + 1;
                var sequence = LastProductId.ToString().PadLeft(9,'0');
                return sequence;
            }
            else
            {
                int LastProductId = 1;
                var sequence = LastProductId.ToString().PadLeft(9, '0');
                return sequence;
            }

        }
    }
}

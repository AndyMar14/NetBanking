using Microsoft.AspNetCore.Mvc;
using NetBanking.Core.Application.Interfaces.Services;
using NetBanking.Core.Application.ViewModels.BankProducts;
using NetBanking.Core.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.NetBanking.Controllers
{
    public class ProductsController : Controller
    {
        readonly IProductsService _productService;
        readonly IBankProductsServices _bankProductService;
        public ProductsController(IProductsService productService, IBankProductsServices bankProductService)
        {
            _productService = productService;
            _bankProductService = bankProductService;
        }

        public async Task<IActionResult> AddProduct(string Id)
        {
            SaveProductsViewModel vm = new();
            vm.IdUser = Id;
            vm.Products = await _bankProductService.GetAllViewModel();
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(SaveProductsViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            vm.Identifier = await _productService.GenerateSequence();
            await _productService.Add(vm);
            return View(vm);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetBanking.Core.Application.Interfaces.Services;
using NetBanking.Core.Application.ViewModels.Products;
using NetBanking.Core.Application.ViewModels.Transactions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAdd.NetBanking.Models;

namespace WebAdd.NetBanking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransactionsService _transactionsServices;
        private readonly IProductsService _productsServices;
        public HomeController(ITransactionsService transactionsServices, IProductsService productsServices)
        {
            _transactionsServices = transactionsServices;
            _productsServices = productsServices;
        }

        public async Task<IActionResult> Index()
        {
            List<TransactionsViewModel> trans = await _transactionsServices.GetAllViewModel(); 
            List<TransactionsViewModel> Pago = await _transactionsServices.GetAllViewModel();
            List<ProductsViewModel> Products = await _productsServices.GetAllViewModel();
            ViewBag.Transferencias = trans.Count;
            ViewBag.Pagos = Pago.Count;
            ViewBag.Productos= Products.Count;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetBanking.Core.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.NetBanking.Controllers
{
    [Authorize(Roles = "Client")]
    public class ClienteController : Controller
    {
        private readonly IProductsService _productServices;

        public ClienteController(IProductsService productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _productServices.GetAllProductsWithIncludes());
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetBanking.Core.Application.Helpers;
using NetBanking.Core.Application.Interfaces.Services;
using NetBanking.Core.Application.ViewModels.Products;
using NetBanking.Core.Application.ViewModels.Transactions;
using NetBanking.Core.Application.ViewModels.Users;
using NetBanking.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.NetBanking.Controllers
{
    public class PagosController : Controller
    {
        private readonly IProductsService _productsServices; 
        private readonly IRecipientsService _recipientsServices;
        private readonly ITransactionsService _transactionsServices;
        private readonly IdentityContext _identityContext;
        private readonly UsersViewModel userViewModel;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public PagosController(IHttpContextAccessor httpContextAccessor, ITransactionsService transactionsServices, IProductsService productsServices, IRecipientsService recipientsServices, IdentityContext context)
        {
            _productsServices = productsServices;
            _recipientsServices = recipientsServices;
            _transactionsServices = transactionsServices;
            _identityContext = context;
            _httpContextAccessor = httpContextAccessor;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<UsersViewModel>("user");
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> PagoExpreso()
        {
            FilterProductViewModel filters = new();
            filters.Type = 1;
            ViewBag.MyProducts = await _productsServices.GetAllProductsByIdUser(userViewModel.Id, filters);
            return View(new SaveTransactionsViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> PagoExpreso(SaveTransactionsViewModel vm)
        {
            FilterProductViewModel filters = new();
            filters.Type = 1;
            ViewBag.MyProducts = await _productsServices.GetAllProductsByIdUser(userViewModel.Id, filters);

            if (vm.Amount <= 0)
            {
                ModelState.AddModelError("pagoValidation", "Este Monto no es valido");
                return View(vm);
            }

            var productFrom = await _productsServices.GetProductByIdentifier(vm.UserProductId);

            if (productFrom == null)
            {
                ModelState.AddModelError("pagoValidation", "Esta cuenta no existe");
            }
            if (productFrom.Amount > vm.Amount)
            {
                if (!ModelState.IsValid)
                {
                    return View(vm);
                }
                vm.Type = 2;
                await _transactionsServices.Pay(vm);
            }
            else
            {
                ModelState.AddModelError("pagoValidation", "No tienes suficientes fondos");
                return View(vm);
            }
            return Redirect("~/Home/Index");
        }
     
        [HttpGet]
        public async Task<IActionResult> PagoTarjetaCredito()
        {
            FilterProductViewModel filters = new();
            filters.Type = 1;
            ViewBag.MyProducts = await _productsServices.GetAllProductsByIdUser(userViewModel.Id, filters);

            return View(new SaveTransactionsViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> PagoTarjetaCredito(SaveTransactionsViewModel vm)
        {
            FilterProductViewModel filters = new();
            filters.Type = 1;
            ViewBag.MyProducts = await _productsServices.GetAllProductsByIdUser(userViewModel.Id, filters);

            if (vm.Amount <= 0)
            {
                ModelState.AddModelError("pagoValidation", "Este monto no es invalido");
                return View(vm);
            }
            var productFrom = await _productsServices.GetProductByIdentifier(vm.UserProductId);
            if (productFrom == null)
            {
                ModelState.AddModelError("pagoValidation", "Esta tarjeta no existe");
            }
            if (productFrom.Amount > vm.Amount)
            {
                if (!ModelState.IsValid)
                {
                    return View(vm);
                }
                vm.Type = 4;
                await _transactionsServices.Pay(vm);
            }
            else
            {
                ModelState.AddModelError("pagoValidation", "No tienes suficientes fondos");
                return View(vm);
            }
            return Redirect("~/Home/Index");
        }

        [HttpGet]
        public async Task<IActionResult> PagoBeneficiario()
        {
            FilterProductViewModel filters = new();
            filters.Type = 1;
            ViewBag.MyProducts = await _productsServices.GetAllProductsByIdUser(userViewModel.Id,filters);
            ViewBag.MyRecipients = await _recipientsServices.GetRecipients(userViewModel.Id);

            return View(new SaveTransactionsViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> PagoBeneficiario(SaveTransactionsViewModel vm)
        {
            FilterProductViewModel filters = new();
            filters.Type = 1;
            ViewBag.MyProducts = await _productsServices.GetAllProductsByIdUser(userViewModel.Id,filters);
            ViewBag.MyRecipients = await _recipientsServices.GetRecipients(userViewModel.Id);

            if (vm.Amount <= 0)
            {
                ModelState.AddModelError("pagoValidation", "Este monto no es invalido");
                return View(vm);
            }
            var productFrom = await _productsServices.GetProductByIdentifier(vm.UserProductId);
         
            if (productFrom.Amount > vm.Amount)
            {
                if (!ModelState.IsValid)
                {
                    return View( vm);
                }
                vm.Type = 1;
                await _transactionsServices.Pay(vm);
            }
            else {
                ModelState.AddModelError("pagoValidation", "No tienes suficientes fondos");
                return View(vm);
            }
            return Redirect("~/Home/Index");
        }
        
        [HttpGet]
        public async Task<IActionResult> PagoPrestamo()
        {
            FilterProductViewModel filters = new();
            filters.Type = 1;
            ViewBag.MyProducts = await _productsServices.GetAllProductsByIdUser(userViewModel.Id,filters);
            filters.Type = 3;
            ViewBag.MyPrestamos = await _productsServices.GetAllProductsByIdUser(userViewModel.Id,filters);

            return View(new SaveTransactionsViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> PagoPrestamo(SaveTransactionsViewModel vm)
        {
            FilterProductViewModel filters = new();
            filters.Type = 1;
            ViewBag.MyProducts = await _productsServices.GetAllProductsByIdUser(userViewModel.Id,filters);

            if (vm.Amount <= 0)
            {
                ModelState.AddModelError("pagoValidation", "Este monto no es invalido");
                return View(vm);
            }
            var productFrom = await _productsServices.GetProductByIdentifier(vm.UserProductId);
            if (productFrom == null)
            {
                ModelState.AddModelError("pagoValidation", "Este prestamo no existe");
            }
            if (productFrom.Amount > vm.Amount)
            {
                if (!ModelState.IsValid)
                {
                    return View(vm);
                }
                vm.Type = 3;
                await _transactionsServices.Pay(vm);
            }
            else
            {
                ModelState.AddModelError("pagoValidation", "No tienes suficientes fondos");
                return View(vm);
            }
            return Redirect("~/Home/Index");
        }
    }
}

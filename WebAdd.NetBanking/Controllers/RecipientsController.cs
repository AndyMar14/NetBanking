using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetBanking.Core.Application.Helpers;
using NetBanking.Core.Application.Interfaces.Services;
using NetBanking.Core.Application.ViewModels.Recipients;
using NetBanking.Core.Application.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.NetBanking.Controllers
{
    public class RecipientsController : Controller
    {
        private readonly IProductsService _productsService;
        private readonly IRecipientsService _recipientsService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UsersViewModel userViewModel;
        public RecipientsController(IProductsService productService, IRecipientsService recipientsService, IHttpContextAccessor httpContextAccessor)
        {
            _productsService = productService;
            _recipientsService = recipientsService;
            _httpContextAccessor = httpContextAccessor;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<UsersViewModel>("user");
        }
        // GET: RecipientsController
        public async Task<IActionResult> Index()
        {
            ViewBag.Recipients = await _recipientsService.GetRecipients(userViewModel.Id);
            return View();
        }

        // GET: RecipientsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: RecipientsController/Create
        [HttpPost]
        public async Task<IActionResult> Create(SaveRecipientsViewModel vm)
        {
            var product = await _productsService.GetProductByIdentifier(vm.IdRecipient);
            TempData["ErrorMessge"] = "";
            if (!ModelState.IsValid || product.HasError == true)
            {
                TempData["ErrorMessge"] = product.ErrorMessage;
                return RedirectToAction("Index");
            }
            vm.IdUser = userViewModel.Id;
            vm.IdRecipient = product.Identifier;
            await _recipientsService.Add(vm);
            return RedirectToAction("Index");
        }

        // GET: RecipientsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecipientsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecipientsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecipientsController/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(string Identifier)
        {

            await _recipientsService.DeleteRecipient(Identifier);

            return RedirectToAction("Index");
        
        }
    }
}

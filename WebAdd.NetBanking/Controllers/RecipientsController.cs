using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetBanking.Core.Application.Interfaces.Services;
using NetBanking.Core.Application.ViewModels.Recipients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.NetBanking.Controllers
{
    public class RecipientsController : Controller
    {
        private readonly IProductsService _productsService;
        public RecipientsController(IProductsService productService)
        {
            _productsService = productService;
        }
        // GET: RecipientsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RecipientsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: RecipientsController/Create
        [HttpPost]
        public async IActionResult Create(SaveRecipientsViewModel vm)
        {
            var user = await _productsService.Ge;


            if (!ModelState.IsValid || user == null)
            {
                TempData["UserExist"] = false;
                return RedirectToAction("Index");
            }
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.NetBanking.Controllers
{
    public class PagosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PagoExpreso()
        {
            return View();
        }
        public IActionResult PagoTarjetaCredito()
        {
            return View();
        }
        public IActionResult PagoPrestamo()
        {
            return View();
        }
        public IActionResult PagoBeneficiario()
        {
            return View();
        }
    }
}

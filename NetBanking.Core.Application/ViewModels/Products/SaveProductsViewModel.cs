using NetBanking.Core.Application.ViewModels.BankProducts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Products
{
    public class SaveProductsViewModel
    {
        public int Id { get; set; }
        public string IdUser { get; set; }

        [Required(ErrorMessage = "Debe colocar el producto")]
        public int MainProduct { get; set; }
        public int IdProducType { get; set; }

        //[Required(ErrorMessage = "Debe colocar el número de identificación del producto")]
        public string Identifier { get; set; }
        public double Balance { get; set; }

        [Required(ErrorMessage = "Debe colocar el límite de la tarjeta")]
        [DataType(DataType.Currency)]
        public double Limit { get; set; }

        [Required(ErrorMessage = "Debe colocar el límite del préstamo")]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
        //vm.Categories = await _categoryService.GetAllViewModel();
        public List<BankProductsViewModel> Products { get; set; }
    }
}

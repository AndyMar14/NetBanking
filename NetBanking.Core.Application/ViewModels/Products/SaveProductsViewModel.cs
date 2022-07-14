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

        [Required(ErrorMessage = "Debe colocar el producto")]
        [DataType(DataType.Text)]
        public string ProductType { get; set; }

        [DataType(DataType.CreditCard)]
        public int ProductIdentifier { get; set; }

        [Required(ErrorMessage = "Debe colocar el límite de la tarjeta")]
        [DataType(DataType.Currency)]
        public double CreditLimit { get; set; }

        [Required(ErrorMessage = "Debe colocar la cantidad del préstamo")]
        [DataType(DataType.Currency)]
        public double LoanAmount { get; set; }
    }
}

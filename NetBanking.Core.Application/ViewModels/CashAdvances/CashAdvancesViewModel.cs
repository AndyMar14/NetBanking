using NetBanking.Core.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.CashAdvances
{
    public class CashAdvancesViewModel
    {
        public int Id { get; set; }
        public int CreditCardId { get; set; }

        [Required(ErrorMessage = "Debe colocar la tarjeta de crédito")]
        public int CreditCardIdentifier { get; set; }
        public int AccountId { get; set; }

        [Required(ErrorMessage = "Debe colocar la cuenta de ahorros")]
        public int AccountIdentifier { get; set; }

        [Required(ErrorMessage = "Debe colocar el monto")]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }


        public ProductsViewModel Products { get; set; }
    }
}

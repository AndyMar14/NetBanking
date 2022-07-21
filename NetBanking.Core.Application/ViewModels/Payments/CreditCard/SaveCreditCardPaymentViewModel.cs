using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Payments.CreditCard
{
    public class SaveCreditCardPaymentViewModel
    {
        public int Id { get; set; }
        public int CreditCardProductId { get; set; }

        [Required(ErrorMessage = "Debe colocar la tarjeta que va a pagar")]
        public int CreditCardProductIdentifier { get; set; }
        public int AccountProductId { get; set; }

        [Required(ErrorMessage = "Debe colocar la cuenta de la cual va a pagar")]
        public int AccountProductIdentifier { get; set; }

        [Required(ErrorMessage = "Debe colocar el monto")]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
    }
}

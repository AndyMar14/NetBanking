using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Payments.ExpressPayment
{
    public class SaveExpressPaymentViewModel
    {
        public int SourceProductId { get; set; }

        [Required(ErrorMessage = "Debe colocar la cuenta de la cual va a pagar")]
        public int SourceProductIdentifier { get; set; }
        public int TargetProductId { get; set; }

        [Required(ErrorMessage = "Debe colocar la cuenta a la cual le desea pagar")]
        public int TargetProductIdentifier { get; set; }

        [Required(ErrorMessage = "Debe colocar el monto")]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
    }
}

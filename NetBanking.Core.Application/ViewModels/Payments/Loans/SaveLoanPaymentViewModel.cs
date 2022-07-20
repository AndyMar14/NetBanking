using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Payments.Loans
{
    public class SaveLoanPaymentViewModel
    {
        public int Id { get; set; }
        public int LoanProductId { get; set; }

        [Required(ErrorMessage = "Debe colocar el préstamo que va a pagar")]
        public int LoanProductIdentifier { get; set; }
        public int AccountProductId { get; set; }

        [Required(ErrorMessage = "Debe colocar la cuenta de la cual va a pagar")]
        public int AccountProductIdentifier { get; set; }

        [Required(ErrorMessage = "Debe colocar el monto")]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
    }
}

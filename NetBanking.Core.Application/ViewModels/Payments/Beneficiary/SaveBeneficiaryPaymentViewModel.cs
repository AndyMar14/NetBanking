using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Payments.Beneficiary
{
    public class SaveBeneficiaryPaymentViewModel
    {
        public int Id { get; set; }

        public int BeneficiaryId { get; set; }

        [Required(ErrorMessage = "Debe colocar el beneficiario")]
        [DataType(DataType.Text)]
        public string BeneficiaryName { get; set; }

        public int ProductId { get; set; }

        [Required(ErrorMessage = "Debe colocar la cuenta con la cual va a pagar")]
        public int ProductIdentifier { get; set; }

        [Required(ErrorMessage = "Debe colocar el monto")]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }


    }
}

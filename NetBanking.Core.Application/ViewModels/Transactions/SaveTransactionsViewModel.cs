using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Transactions
{
    public class SaveTransactionsViewModel
    {
        public int Id { get; set; }
        public int SourceAccountId { get; set; }

        [Required(ErrorMessage = "Debe colocar la cuenta de origen")]
        public int SourceAccountIdentifier { get; set; }

        public int TargetAccountId { get; set; }

        [Required(ErrorMessage = "Debe colocar la cuenta de destino")]
        public int TargetAccountIdentifier { get; set; }

        [Required(ErrorMessage = "Debe colocar el monto")]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
    }
}

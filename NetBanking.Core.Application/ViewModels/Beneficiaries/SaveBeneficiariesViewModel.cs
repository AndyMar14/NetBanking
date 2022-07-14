using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Beneficiaries
{
    public class SaveBeneficiariesViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UserBeneficiaryId { get; set; }
        public string BeneficiaryName { get; set; }
        public string BeneficiaryLastName { get; set; }

        [Required(ErrorMessage = "Debe colocar la cuenta del beneficiario")]
        public int AcountIdentifier { get; set; }
    }
}

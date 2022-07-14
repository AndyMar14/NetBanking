using NetBanking.Core.Application.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Beneficiaries
{
    public class BeneficiariesViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UserBeneficiaryId { get; set; }
        public string BeneficiaryName { get; set; }
        public string BeneficiaryLastName { get; set; }
        public int AccountIdentifier { get; set; }

        public UsersViewModel UserBeneficiary { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Recipients
{
    public class SaveRecipientsViewModel
    {
        public int Id { get; set; }
        public string IdUser { get; set; }

        [Required(ErrorMessage = "Debe colocar la cuenta del beneficiario")]
        public string IdRecipient { get; set; }

    }
}

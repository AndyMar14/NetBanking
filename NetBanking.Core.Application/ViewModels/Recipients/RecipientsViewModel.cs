using NetBanking.Core.Application.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Application.ViewModels.Recipients
{
    public class RecipientsViewModel
    {
        public int Id { get; set; }
        public string IdUser { get; set; }
        public string IdRecipient { get; set; }

        public UsersViewModel Recipient { get; set; }
    }
}

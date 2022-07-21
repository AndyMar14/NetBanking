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
        public int UserId { get; set; }
        public int RecipientId { get; set; }

        public UsersViewModel Recipient { get; set; }
    }
}

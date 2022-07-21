using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Domain.Entities
{
    public class Recipients
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdRecipient { get; set; }

        //NAVIGATION PROPERTIES
        public Users Recipient { get; set; }
    }
}

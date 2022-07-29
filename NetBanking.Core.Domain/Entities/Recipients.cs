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
        public string IdUser { get; set; }
        public string IdRecipient { get; set; }

        //NAVIGATION PROPERTIES
    }
}

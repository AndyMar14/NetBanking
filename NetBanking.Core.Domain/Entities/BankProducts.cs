using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Domain.Entities
{
    public class BankProducts
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //NAVIGATION PROPERTIES
        public ICollection<Products> Products { get; set; }
    }
}

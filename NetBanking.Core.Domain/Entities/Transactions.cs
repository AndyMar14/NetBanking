using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Domain.Entities
{
    public class Transactions
    {
        public int Id { get; set; }
        public int IdUserProduct { get; set; }
        public int IdRecipientProduct { get; set; }
        public int Type { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }

        //NAVIGATION PROPERTIES
        public Products ProductFrom { get; set; }
        public Products ProducTo { get; set; }
    }
}

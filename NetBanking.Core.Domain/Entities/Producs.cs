using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Domain.Entities
{
    public class Producs
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int MainProduc { get; set; }
        public int IdProducType { get; set; }
        public string Password { get; set; }
        public double Limit { get; set; }
        public double Monto { get; set; }
        public double Balance { get; set; }

        //NAVIGATION PROPERTIES

        public Users User { get; set; }
        public BankProducs Produc { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
    }
}

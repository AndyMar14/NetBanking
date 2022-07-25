using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Domain.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int MainProduct { get; set; }
        public int IdProducType { get; set; }
        public int Identifier { get; set; }
        public double Limit { get; set; }
        public double Monto { get; set; }
        public double Balance { get; set; }

        //NAVIGATION PROPERTIES

        public Users User { get; set; }
        public BankProducts Produc { get; set; }
        public ICollection<Transactions> TransactionsOut { get; set; }
        public ICollection<Transactions> TransactionsIn { get; set; }
    }
}

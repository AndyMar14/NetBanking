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
        public string IdUser { get; set; }
        public int MainProduct { get; set; }
        public int IdProducType { get; set; }
        public string Identifier { get; set; }
        public float Limit { get; set; }
        public float Amount { get; set; }
        public float Balance { get; set; }

        //NAVIGATION PROPERTIES

        public BankProducts Produc { get; set; }
        //public ICollection<Transactions> TransactionsOut { get; set; }
        //public ICollection<Transactions> TransactionsIn { get; set; }
    }
}

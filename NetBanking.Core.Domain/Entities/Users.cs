using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBanking.Core.Domain.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public int UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identification { get; set; }
        public string Email { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        //NAVIGATION PROPERTIES
        public ICollection<Products> Products { get; set; }
        public ICollection<Recipients> Recipients { get; set; }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITSecuritySymposium.Models
{
    public class Balance : DomainObject
    {
        public Balance()
        {
            Transactions = new List<Transaction>();
        }

        public string UserName { get; set; }
        public double Amount { get; set; }

        public string AcctNumber { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }

    public class Transaction: DomainObject
    {
        public Balance Balance { get; set; }
        public double Amount { get; set; }
        public string Comment { get; set; }
    }
}
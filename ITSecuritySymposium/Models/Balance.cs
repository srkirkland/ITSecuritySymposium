using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITSecuritySymposium.Models
{
    public class Balance : DomainObject
    {
        public string UserName { get; set; }
        public double Amount { get; set; }
    }
}
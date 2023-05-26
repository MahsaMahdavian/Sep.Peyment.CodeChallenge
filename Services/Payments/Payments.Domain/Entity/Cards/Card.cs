using Payments.Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Domain.Entity.Cards
{
    public class Card : BaseEntity
    {
        public int CardNo { get;  set; }
        public string Cvv2 { get;  set; }
        public DateTime ExpireDate { get;  set; }
        public decimal Credit { get; set; }
   
    }
}

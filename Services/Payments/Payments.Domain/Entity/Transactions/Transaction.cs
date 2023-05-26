using Payments.Domain.Entity.Base;
using Payments.Domain.Entity.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Domain.Entity.Transactions
{
    public class Transaction:BaseEntity
    {
        public int CardId { get; set; }
        public Card Card { get; set; }
        public decimal Amount { get; set; }
        public string RecipientCardNo { get; set; }
        public string Pin2 { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string TrackingCode { get; set; }
        public string PaymentIdentity { get; set; }
       
    }
}

using Payments.Domain.Entity.Accounts.ValueObject;
using Payments.Domain.Entity.Base;
using Payments.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Domain.Entity.Cards
{
    public class Card : BaseEntity
    {
        public Card(string cardNo,string cvv2, DateTime expireDate, decimal credit)
        {
            CardNo = cardNo;
            Cvv2 = cvv2;
            ExpireDate = expireDate;
            Credit = credit;
            bankType = Accounts.ValueObject.BankType.Create(cardNo);
        }

        public string CardNo { get;  set; }
        public string Cvv2 { get;  set; }
        public DateTime ExpireDate { get;  set; }
        public decimal Credit { get; set; }
        public Enum.BankType bankType { get; }


    }
}

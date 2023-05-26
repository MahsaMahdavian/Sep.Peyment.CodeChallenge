using Payments.Domain.Entity.Accounts.ValueObject;
using Payments.Domain.Entity.Base;
using Payments.Domain.Entity.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Domain.Entity.Accounts
{
    public class Account:BaseEntity
    {
        public int CardId { get; set; }
        public Card Card { get; set; }
        public string FirstName { get;  set; }
        public string Lastname { get;  set; }
        public Gender Gender { get; private set; }
        public CellPhoneNumber CellPhoneNumber { get; set; }
        public string NationalCode { get;  set; }
    }
}

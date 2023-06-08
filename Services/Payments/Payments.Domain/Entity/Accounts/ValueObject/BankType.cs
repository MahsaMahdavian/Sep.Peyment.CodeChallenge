using Payments.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Domain.Entity.Accounts.ValueObject
{
    public record BankType

    {
        public BankType(string cardNo)
        {
            CardNo = cardNo;
        }
        public static Enum.BankType Create(string cardNo)
        {
            switch (cardNo.Substring(0, 6))
            {
                case "610433": return Enum.BankType.Mellat;
                case "621986": return Enum.BankType.Saman;
                case "636214": return Enum.BankType.Ayande;
                default: throw new BankTypeNotFoundException(cardNo);
            }
        }
        public string CardNo { get; set; }
        public Enum.BankType bankTypeEnum { get; set; }
    }
}

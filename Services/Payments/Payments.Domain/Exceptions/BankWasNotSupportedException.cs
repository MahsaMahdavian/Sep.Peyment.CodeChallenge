
using Payments.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Domain.Exceptions
{
    public class BankWasNotSupportedException:Exception
    {
        public BankType Value { get; set; }
        public BankWasNotSupportedException(BankType value):base($"{value} bank was not supported Yet please try with another bank ")=>Value = value;
        {
            
        }

    }
}

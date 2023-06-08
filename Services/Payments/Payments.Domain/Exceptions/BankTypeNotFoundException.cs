using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Domain.Exceptions
{
    public class BankTypeNotFoundException: Exception
    {
        public string Value { get; }
        public BankTypeNotFoundException(string value):base($"the bank type for card {value} was not found ")=>Value = value;
        {
            
        }
    }
}

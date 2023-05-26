using Payments.Application.Banks;
using Payments.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Application.Services
{
    public class MellatPayStrategy:IPayStrategy
    {
       

        public BankingOutputViewModel Run(BankingInputViewModel input)
        {
            Mellat mellat = new Mellat();
            return mellat.Transaction(input);
        }
    }
}

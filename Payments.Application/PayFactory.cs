using Payments.Application.Services;
using Payments.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Application
{
    public class PayFactory
    {
        public static IPayStrategy Create(BankType bankType)
        {
           
            switch (bankType)
            {
                case BankType.saman:return new SamanPayStrategy();
                case BankType.mellat:return new MellatPayStrategy();

            }
        }
    }
}

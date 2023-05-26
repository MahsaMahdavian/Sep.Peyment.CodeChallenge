using Payments.Application.Services.BankServiceHandler;
using Payments.Domain.Enum;

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
                case BankType.ayande: return new AyandePayStrategy();
                default: return new NonePayStrategy();
            }
        }
    }
}

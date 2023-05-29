using Payments.Application.Services.BankServiceHandler;
using Payments.Domain.Enum;
using Payments.Domain.InfrustructureService;
using Payments.Infrastructure.banksProvider;

namespace Payments.Application
{
    public class PayFactory
    {
        public static IPayStrategy Create(BankType bankType)
        {          
            switch (bankType)
            {
                case BankType.saman:return new PayStrategy(new Saman());
                case BankType.mellat:return new PayStrategy(new Mellat());
                case BankType.ayande: return new PayStrategy(new Ayande());
                default: return new PayStrategy();
            }
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using Payments.Domain.Enum;
using Payments.Domain.Exceptions;
using Payments.Domain.InfrustructureService;
using Payments.Infrastructure.banksProvider;

namespace Payments.Application
{
    public class PayFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public PayFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IPayStrategy Create(BankType bankType)
        {
            switch (bankType)
            {
                case BankType.Saman: return ResolveSterategy<Saman>();
                case BankType.Mellat: return ResolveSterategy<Ayande>();
                case BankType.Ayande: return ResolveSterategy<Mellat>();
                default: throw new BankWasNotSupportedException(bankType);
            }
        }

        private T ResolveSterategy<T>() where T : class, IPayStrategy
        {
            return _serviceProvider.GetRequiredService<T>();
        }
    }
}

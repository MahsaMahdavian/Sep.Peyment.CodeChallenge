using Payments.Application.Banks;
using Payments.Infrastructure.ViewModel;

namespace Payments.Application.Services
{
    public class SamanPayStrategy : IPayStrategy
    {
        public BankingOutputViewModel Run(BankingInputViewModel input)
        {
            Saman saman = new Saman();
           return saman.Transaction(input);
        }
    }
}

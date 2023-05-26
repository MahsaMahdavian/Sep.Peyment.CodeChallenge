using Payments.Application.Banks;
using Payments.Domain.ViewModel;

namespace Payments.Application.Services.BankServiceHandler
{
    public class SamanPayStrategy : IPayStrategy
    {
        public async Task<BankingOutputViewModel> Run(BankingInputViewModel input)
        {
            Saman saman = new Saman();
            return await saman.Transaction(input);
        }
    }
}

using Payments.Application.Banks;
using Payments.Domain.ViewModel;

namespace Payments.Application.Services.BankServiceHandler
{
    public class MellatPayStrategy : IPayStrategy
    {
        public async Task<BankingOutputViewModel> Run(BankingInputViewModel input)
        {
            Mellat mellat = new Mellat();
            return await mellat.Transaction(input);
        }
    }
}

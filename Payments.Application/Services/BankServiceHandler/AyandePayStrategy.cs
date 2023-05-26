using Payments.Application.Banks;
using Payments.Domain.ViewModel;

namespace Payments.Application.Services.BankServiceHandler
{
    public class AyandePayStrategy : IPayStrategy
    {

        public async Task<BankingOutputViewModel> Run(BankingInputViewModel input)
        {
            Ayande ayande = new Ayande();
            return await ayande.Transaction(input);
        }
    }
}

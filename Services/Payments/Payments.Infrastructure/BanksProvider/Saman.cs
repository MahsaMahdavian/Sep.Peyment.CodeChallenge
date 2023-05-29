using Payments.Domain.InfrustructureService;
using Payments.Domain.Dtos;

namespace Payments.Infrastructure.banksProvider
{
    public class Saman: IBankProvider
    {
        public async Task<BankingOutputViewModel> Transaction(BankingInputViewModel bankingInputViewModel)
        {
            return new BankingOutputViewModel { };
        }
    }
}

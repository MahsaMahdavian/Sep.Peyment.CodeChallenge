using Payments.Domain.Dtos;
using Payments.Domain.InfrustructureService;

namespace Payments.Application
{
    internal class PayStrategy : IPayStrategy
    {
        public Task<BankingOutputDto> RunAsync(BankingInputDto input, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
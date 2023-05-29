using Payments.Domain.Dtos;
using Payments.Domain.InfrustructureService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Application.Services.BankServiceHandler
{
    public class PayStrategy : IPayStrategy
    {
        private readonly IBankProvider _bankProvider;
        public PayStrategy(IBankProvider bankProvider)
        {
            _bankProvider = bankProvider;
        }
        public PayStrategy()
        {
            
        }
        public async Task<BankingOutputViewModel> RunAsync(BankingInputViewModel input, CancellationToken cancellationToken)
        {
            return await _bankProvider.Transaction(input);

        }
    }
}

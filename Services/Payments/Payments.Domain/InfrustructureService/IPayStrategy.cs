using Payments.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Domain.InfrustructureService
{
    public interface IPayStrategy
    {
        Task<BankingOutputDto> RunAsync(BankingInputDto input, CancellationToken cancellationToken = default);
    }
}

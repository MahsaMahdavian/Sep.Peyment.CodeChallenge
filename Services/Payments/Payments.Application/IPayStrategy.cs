using Payments.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Application
{
    public interface IPayStrategy
    {
        Task<BankingOutputViewModel> RunAsync(BankingInputViewModel input,CancellationToken cancellationToken=default);
    }
}

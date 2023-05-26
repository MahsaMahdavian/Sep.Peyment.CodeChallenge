using Payments.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Application
{
    public interface IPayStrategy
    {
        Task<BankingOutputViewModel> Run(BankingInputViewModel input);
    }
}

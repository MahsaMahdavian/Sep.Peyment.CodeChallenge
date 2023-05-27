using Payments.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Application.Services.BankServiceHandler
{
    public class NonePayStrategy : IPayStrategy
    {
        public async Task<BankingOutputViewModel> Run(BankingInputViewModel input)
        {
            return new BankingOutputViewModel();
        }
    }
}

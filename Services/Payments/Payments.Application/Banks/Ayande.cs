using Payments.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Application.Banks
{
    public class Ayande
    {
        public async Task<BankingOutputViewModel> Transaction(BankingInputViewModel bankingInputViewModel)
        {
            return new BankingOutputViewModel { };
        }
    }
}

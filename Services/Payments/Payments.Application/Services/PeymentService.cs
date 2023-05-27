using Payments.Domain.ApplicationService;
using Payments.Domain.Enum;
using Payments.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Application.Services
{
    public class PeymentService : IPeymentService
    {
        public Task<BankingOutputViewModel> TransactionByCard(BankType bankType, BankingInputViewModel input)
        {
            return PayFactory.Create(bankType).Run(input);
        }
    }
}

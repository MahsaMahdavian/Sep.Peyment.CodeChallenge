using Payments.Domain.ApplicationService;
using Payments.Domain.Enum;
using Payments.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Application.Services
{
    public class PeymentService : IPeymentService
    {
        public PayFactory  _payFactory;
        public PeymentService(PayFactory payFactory)
        {

            _payFactory = payFactory;

        }
        public Task<BankingOutputDto> TransactionByCard(BankType bankType, BankingInputDto input)
        {
            return _payFactory.Create(bankType).RunAsync(input);
        }
    }
}

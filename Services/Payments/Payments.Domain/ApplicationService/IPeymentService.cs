using Payments.Domain.Enum;
using Payments.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Domain.ApplicationService
{
    public interface IPeymentService
    {
        public Task<BankingOutputDto> TransactionByCard(BankType bankType, BankingInputDto input);
      
    }
}

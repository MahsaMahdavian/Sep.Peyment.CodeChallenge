using Payments.Application.Banks;
using Payments.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Application.Services
{
    public class AyandePayStrategy : IPayStrategy
    {

        public BankingOutputViewModel Run(BankingInputViewModel input)
        {
            Ayande ayande = new Ayande();
            return ayande.Transaction(input);
        }
    }
}

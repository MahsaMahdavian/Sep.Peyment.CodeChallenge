﻿using Payments.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Application
{
    public interface IPayStrategy
    {
        BankingOutputViewModel Run(BankingInputViewModel input);
    }
}
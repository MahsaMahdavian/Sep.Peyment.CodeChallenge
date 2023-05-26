using Microsoft.EntityFrameworkCore;
using Payments.Domain.Entity.Accounts;
using Payments.Domain.Entity.Cards;
using Payments.Domain.Entity.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Infrastructure
{
    public class DataBaseContext :DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using Payments.Domain.Entity.Accounts;
using Payments.Domain.Entity.Cards;
using Payments.Domain.Entity.Transactions;
using Payments.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Infrastructure
{
    public class DataBaseContext :DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AccountConfig).Assembly);
        }
    }
}

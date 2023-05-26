using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Payments.Domain.Entity.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Infrastructure.Configuration
{
    internal class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.Property(p => p.StatusCode).IsRequired();
            builder.Property(p => p.Message).IsRequired();
            builder.Property(p => p.RecipientCardNo).IsRequired();
            builder.Property(p => p.Amount).IsRequired();
        
        }
    }
}

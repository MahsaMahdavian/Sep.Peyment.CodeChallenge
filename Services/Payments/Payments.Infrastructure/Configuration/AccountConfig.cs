using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Payments.Domain.Entity.Accounts;
using Payments.Domain.Entity.Accounts.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Infrastructure.Configuration
{
    public class AccountConfig : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(160);
            builder.Property(p => p.Lastname).IsRequired().HasMaxLength(160);
            builder.Property(p => p.NationalCode).IsRequired().HasMaxLength(10);
            builder.Property(p => p.CellPhoneNumber).IsRequired().HasMaxLength(maxLength: CellPhoneNumber.FixLength).
                HasConversion(c => c.Value, c => new CellPhoneNumber());
        }
    }
}

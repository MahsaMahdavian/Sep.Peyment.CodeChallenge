using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Domain.Entity.Accounts.ValueObject
{
    public record CellPhoneNumber
    {
        #region Constant(s)
        public const int FixLength = 11;

        public const int VerificationKeyFixLength = 6;

        public const string RegularExpression = @"09\d{9}";
        #endregion /Constant(s)

        public string Value { get; }

        public bool IsVerified { get; }

        public string VerificationKey { get; }
    }
}

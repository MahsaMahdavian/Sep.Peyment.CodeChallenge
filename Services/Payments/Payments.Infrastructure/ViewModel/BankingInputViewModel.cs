using Payments.Domain.Entity.Accounts.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Infrastructure.ViewModel
{
    public class BankingInputViewModel
    {
        public int CardNo { get; set; }
        public string RecipientCardNo { get; set; }
        /// <summary>
		/// رمز دوم (اينترنتی) کارت
		/// </summary>
        public string Pin2 { get; set; }
        public string Cvv2 { get; set; }
        public DateTime ExpireDate { get; set; }
        public string CellPhoneNumber { get; set; }
    }
}

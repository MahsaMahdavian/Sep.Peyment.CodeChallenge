using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Application.ViewModels
{
    public class TransactionInfoViewModel
    {     
        public string RecipientCardNo { get; set; }
        /// <summary>
		/// رمز دوم (اينترنتی) کارت
		/// </summary>
        public string Pin2 { get; set; }
        public string Cvv2 { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Amount { get; set; }
    }
}

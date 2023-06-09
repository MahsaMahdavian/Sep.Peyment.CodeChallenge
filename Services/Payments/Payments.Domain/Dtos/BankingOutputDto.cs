﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Domain.Dtos
{
    public class BankingOutputDto
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        /// <summary>
        /// کد پیگیری
        /// </summary>
        public string TrackingCode { get; set; }
        /// <summary>
        ///  شناسه دیجیتال تراکنش
        /// </summary>
        public string PaymentIdentity { get; set; }
    }
}

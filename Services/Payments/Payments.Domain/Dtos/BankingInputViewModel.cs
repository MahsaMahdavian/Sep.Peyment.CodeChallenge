namespace Payments.Domain.Dtos
{
    public class BankingInputViewModel
    {
        public string CardNo { get; set; }
        public string RecipientCardNo { get; set; }
        /// <summary>
		/// رمز دوم (اينترنتی) کارت
		/// </summary>
        public string Pin2 { get; set; }
        public string Cvv2 { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Amount { get; set; }
        public string CellPhoneNumber { get; set; }
    }
}

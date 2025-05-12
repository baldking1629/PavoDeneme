namespace PavoDeneme.Models
{
    public class PaymentInformation
    {
        public int Mediator { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public string ExternalReferenceText { get; set; }
    }
} 
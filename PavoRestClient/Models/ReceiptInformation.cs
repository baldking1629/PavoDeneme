namespace PavoDeneme.Models
{
    public class ReceiptInformation
    {
        public bool ReceiptImageEnabled { get; set; }
        public bool ReceiptJsonEnabled { get; set; }
        public bool ReceiptTextEnabled { get; set; }
        public string ReceiptWidth { get; set; }
        public bool PrintCustomerReceipt { get; set; }
        public bool PrintCustomerReceiptCopy { get; set; }
        public bool PrintMerchantReceipt { get; set; }
        public bool EnableExchangeRateField { get; set; }
    }
} 
using System;
using System.Collections.Generic;

namespace PavoDeneme.Models
{
    public class Sale
    {
        public string RefererApp { get; set; }
        public string RefererAppVersion { get; set; }
        public string OrderNo { get; set; }
        public int MainDocumentType { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public PriceEffect PriceEffect { get; set; }
        public bool SendPhoneNotification { get; set; }
        public bool SendEMailNotification { get; set; }
        public string NotificationPhone { get; set; }
        public string DocumentNote { get; set; }
        public string Reserved03 { get; set; }
        public string NotificationEMail { get; set; }
        public bool ShowCreditCardMenu { get; set; }
        public List<string> SelectedSlots { get; set; }
        public bool EnableAllTerminalsOnRetry { get; set; }
        public bool AllowDismissCardRead { get; set; }
        public int CardReadTimeout { get; set; }
        public bool SkipAmountCash { get; set; }
        public bool CancelPaymentLater { get; set; }
        public bool AskCustomer { get; set; }
        public bool SendResponseBeforePrint { get; set; }
        public bool TryAgainOnPaymentFailure { get; set; }
        public bool ReferOtherMediatorsToRetryPayment { get; set; }
        public AbandonOptions AbandonOptions { get; set; }
        public bool ContinuePaymentWithCardInserted { get; set; }
        public int HeadUnmaskedCardNumber { get; set; }
        public int TailUnmaskedCardNumber { get; set; }
        public List<AddedSaleItem> AddedSaleItems { get; set; }
        public List<PaymentInformation> PaymentInformations { get; set; }
        public List<AllowedPaymentMediator> AllowedPaymentMediators { get; set; }
        public ReceiptInformation ReceiptInformation { get; set; }
        public CustomerParty CustomerParty { get; set; }
        public List<AdditionalInfo> AdditionalInfo { get; set; }
        public List<PrintableItem> TopPrintableItems { get; set; }
        public List<PrintableItem> BottomPrintableItems { get; set; }
    }
} 
using System;
using System.Collections.Generic;

namespace PavoDeneme.Models
{
    public class TransactionData
    {
        public TransactionHandle TransactionHandle { get; set; }
        public Sale Sale { get; set; }
    }

    public class TransactionHandle
    {
        public string SerialNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public int TransactionSequence { get; set; }
        public string Fingerprint { get; set; }
    }

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

    public class PriceEffect
    {
        public int Type { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
    }

    public class AbandonOptions
    {
        public bool IsVoid { get; set; }
        public bool EnableRefundMediatorsOnVoidFailure { get; set; }
    }

    public class AddedSaleItem
    {
        public string Name { get; set; }
        public bool IsGeneric { get; set; }
        public string UnitCode { get; set; }
        public string TaxGroupCode { get; set; }
        public decimal ItemQuantity { get; set; }
        public decimal UnitPriceAmount { get; set; }
        public decimal GrossPriceAmount { get; set; }
        public decimal TotalPriceAmount { get; set; }
        public string ReservedText { get; set; }
        public PriceEffect PriceEffect { get; set; }
    }

    public class PaymentInformation
    {
        public int Mediator { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public string ExternalReferenceText { get; set; }
    }

    public class AllowedPaymentMediator
    {
        public int Mediator { get; set; }
    }

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

    public class CustomerParty
    {
        public int CustomerType { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string FamilyName { get; set; }
        public string CompanyName { get; set; }
        public string TaxOfficeCode { get; set; }
        public string TaxNumber { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Neighborhood { get; set; }
        public string Address { get; set; }
    }

    public class AdditionalInfo
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public bool Print { get; set; }
    }

    public class PrintableItem
    {
        public string type { get; set; }
    }

    public class PrintableSpace : PrintableItem
    {
        public PrintableSpace() { type = "dSpace"; }
        public int height { get; set; }
    }

    public class PrintableText : PrintableItem
    {
        public PrintableText() { type = "dText"; }
        public string alignment { get; set; }
        public int fontSize { get; set; }
        public string text { get; set; }
        public string fontWeight { get; set; }
        public int offset { get; set; }
        public int? rightMargin { get; set; }
        public int? leftMargin { get; set; }
    }

    public class PrintableLine : PrintableItem
    {
        public PrintableLine() { type = "dLine"; }
        public int? dashWidth { get; set; }
    }

    public class PrintableList : PrintableItem
    {
        public PrintableList() { type = "dList"; }
        public List<PrintableItemChildren> children { get; set; }
    }

    public class PrintableItemChildren
    {
        public string type { get; set; }
        public string alignment { get; set; }
        public string text { get; set; }
        public int offset { get; set; }
        public int? rightMargin { get; set; }
        public int? leftMargin { get; set; }
    }
} 
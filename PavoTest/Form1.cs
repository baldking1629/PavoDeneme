using PavoDeneme.Models;
using PavoRestClient.Services;
using PavoRestClient.Services1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PavoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int ReadAndUpdateSequence(string filePath)
        {
            int sequence = 30; 
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath).Trim();
                int.TryParse(content, out sequence);
            }
            sequence++;
            File.WriteAllText(filePath, sequence.ToString());

            return sequence;
        }
        string fingerPrint = "text";
        string serialNumber = "PAV860034877";
        string baseUrl = "192.168.1.203";
        private void button1_Click(object sender, EventArgs e)
        {
            int sequence = ReadAndUpdateSequence("sonuc.txt");
          PavoServices.CallPairing(baseUrl, serialNumber, sequence, fingerPrint);

        }

        private  void button2_Click(object sender, EventArgs e)
        {

            int sequence = ReadAndUpdateSequence("sonuc.txt");
            Sale sale = new Sale
            {
                RefererApp = "Harici Uygulama",
                RefererAppVersion = "1.0.0",
                OrderNo = "0000000000ABC0005",
                MainDocumentType = 1,
                GrossPrice = 20,
                TotalPrice = 20,
                CurrencyCode = "TRY",
                ExchangeRate = 1,
                PriceEffect = new PriceEffect { Type = 2, Rate = 10, Amount = null },
                SendPhoneNotification = false,
                SendEMailNotification = true,
                NotificationEMail = "me@info.com",
                ShowCreditCardMenu = false,
                SelectedSlots = new List<string> { "rf", "icc", "manual" },
                EnableAllTerminalsOnRetry = false,
                AllowDismissCardRead = false,
                CardReadTimeout = 30,
                SkipAmountCash = false,
                CancelPaymentLater = true,
                AskCustomer = false,
                SendResponseBeforePrint = false,
                TryAgainOnPaymentFailure = true,
                ReferOtherMediatorsToRetryPayment = true,
                AbandonOptions = new AbandonOptions
                {
                    IsVoid = true,
                    EnableRefundMediatorsOnVoidFailure = true
                },
                ContinuePaymentWithCardInserted = true,
                HeadUnmaskedCardNumber = 4,
                TailUnmaskedCardNumber = 4,
                AddedSaleItems = new List<AddedSaleItem>
            {
                new AddedSaleItem
                {
                    Name = "Çikolata",
                    IsGeneric = false,
                    UnitCode = "KGM",
                    TaxGroupCode = "KDV10",
                    ItemQuantity = 1,
                    UnitPriceAmount = 20,
                    GrossPriceAmount = 20,
                    TotalPriceAmount = 20,
                    ReservedText = "TEST0001",
                    PriceEffect = new PriceEffect { Type = 1, Rate = 10, Amount = null }
                }
            },
                PaymentInformations = new List<PaymentInformation>
            {
                new PaymentInformation
                {
                    Mediator = 2,
                    Amount = 16.2m,
                    CurrencyCode = "TRY",
                    ExchangeRate = 1,
                    ExternalReferenceText = "xrkgrtkvr1234"
                }
            },
                AllowedPaymentMediators = new List<AllowedPaymentMediator>
            {
                new AllowedPaymentMediator { Mediator = 2 },
                new AllowedPaymentMediator { Mediator = 1 }
            },
                ReceiptInformation = new ReceiptInformation()
                {
                    ReceiptImageEnabled = true,
                    ReceiptJsonEnabled = false,
                    ReceiptTextEnabled = false,
                    ReceiptWidth = "58mm",
                    PrintCustomerReceipt = true,
                    PrintCustomerReceiptCopy = true,
                    PrintMerchantReceipt = true,
                    EnableExchangeRateField = true
                },
                CustomerParty = new CustomerParty
                {
                    CustomerType = 1,
                    FirstName = "John",
                    MiddleName = "",
                    FamilyName = "Doe",
                    CompanyName = "",
                    TaxOfficeCode = "",
                    TaxNumber = "11111111111",
                    Phone = "",
                    EMail = "",
                    Country = "Türkiye",
                    City = "Ankara",
                    District = "Çankaya",
                    Neighborhood = "",
                    Address = ""
                },
                AdditionalInfo = new List<AdditionalInfo>
            {
                new AdditionalInfo { Key = "Test", Value = "Test", Print = true }
            }
                //TopPrintableItems = new List<object>(), // Dilerseniz detayları eklersiniz
                //BottomPrintableItems = new List<object>() // Dilerseniz detayları eklersiniz

            };
            PavoServices.CallCompleteSale(baseUrl, serialNumber, sequence,fingerPrint,sale);
        }
    }
}

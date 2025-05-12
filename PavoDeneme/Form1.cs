using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Text.Json.Serialization;
using PavoDeneme.Models;

namespace PavoDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = "https://192.168.1.203:4567/Pairing";

            // Models.cs'deki sınıfları kullanarak nesne oluştur
            var payload = new TransactionData
            {
                TransactionHandle = new TransactionHandle
                {
                    SerialNumber = "PAV860034877",
                    TransactionDate = DateTime.Now,
                    TransactionSequence = 176,
                    Fingerprint = "test2"
                },
                Sale = new Sale
                {
                    RefererApp = "Harici Uygulama",
                    RefererAppVersion = "1.0.0",
                    MainDocumentType = 1,
                    GrossPrice = 20,
                    TotalPrice = 20,
                    SendPhoneNotification = false,
                    SendEMailNotification = false,
                    AddedSaleItems = new List<AddedSaleItem>
                    {
                        new AddedSaleItem
                        {
                            Name = "Gofret",
                            IsGeneric = false,
                            UnitCode = "KGM",
                            TaxGroupCode = "KDV18",
                            ItemQuantity = 1,
                            UnitPriceAmount = 20,
                            GrossPriceAmount = 20,
                            TotalPriceAmount = 20
                        }
                    },
                    PaymentInformations = new List<PaymentInformation>
                    {
                        new PaymentInformation
                        {
                            Mediator = 1,
                            Amount = 20
                        }
                    }
                }
            };

            //CallPairingAsync();
            //CallCompleteSaleAsync();
            PostAsync(url, payload);
        }

        private static async Task CallPairingAsync()
        {
            var url = "https://192.168.1.203:4567/Pairing";
            var payload = new
            {
                TransactionHandle = new
                {
                    SerialNumber = "PAV860034877",
                    TransactionDate = DateTime.Now,
                    TransactionSequence = 154,
                    Fingerprint = "test2"
                }
            };

            await PostAsync(url, payload);
        }


        private static async Task CallCompleteSaleAsync()
        {
            var url = "https://192.168.1.203:4567/CompleteSale";
            var payload = new
            {
                TransactionHandle = new
                {
                    SerialNumber = "PAV860034877",
                    TransactionDate = DateTime.Now,
                    TransactionSequence = 155,
                    Fingerprint = "test2"
                },
                Sale = new
                {
                    RefererApp = "Harici Uygulama",
                    RefererAppVersion = "1.0.0",
                    MainDocumentType = 1,
                    GrossPrice = 20,
                    TotalPrice = 20,
                    SendPhoneNotification = false,
                    SendEMailNotification = false,
                    AddedSaleItems = new[]
                    {
                        new
                        {
                            Name = "Gofret",
                            IsGeneric = false,
                            UnitCode = "KGM",
                            TaxGroupCode = "KDV18",
                            ItemQuantity = 1,
                            UnitPriceAmount = 20,
                            GrossPriceAmount = 20,
                            TotalPriceAmount = 20
                        }
                    },
                    PaymentInformations = new[]
                    {
                        new
                        {
                            Mediator = 1,
                            Amount = 20
                        }
                    }
                }
            };


            await PostAsync(url, payload);
        }

        private static async Task PostAsync(string url, object payload)
        {
            var handler = new HttpClientHandler();
            // Bypass SSL certificate validation - for development use only!
            handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;

            using (var client = new HttpClient(handler))
            {
                var json = System.Text.Json.JsonSerializer.Serialize(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    var response = await client.PostAsync(url, content);

                    // Read the response content
                    var responseContent = await response.Content.ReadAsStringAsync();

                    Console.WriteLine($"Response for {url}:");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(responseContent);
                        Console.WriteLine("Success! Response received:");
                        Console.WriteLine(responseContent); // Print success response
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                        Console.WriteLine("Error details:");
                        Console.WriteLine(responseContent); // Print error response
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request exception: {e.Message}");
                }
            }
        }


    }



   

   

}

using Newtonsoft.Json;
using PavoDeneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PavoRestClient.Services
{
    public class PavoServices
    {
        public static string CallPairing(string baseUrl,string serialNumber, int sequence, string fingerPrint)
        {
            var url = $"https://{baseUrl}:4567/Pairing";
            var payload = new
            {
                TransactionHandle = new
                {
                    SerialNumber = serialNumber,
                    TransactionDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff"),
                    TransactionSequence = sequence,
                    Fingerprint = fingerPrint
                }
            };

             return Post(url, payload);
        }

        public static string CallCompleteSale(string baseUrl, string serialNumber, int sequence, string fingerPrint,Sale sale)
        {
            var url = $"https://{baseUrl}:4567/CompleteSale";
            var payload = new
            {
                TransactionHandle = new
                {
                    SerialNumber = serialNumber,
                    TransactionDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff"),
                    TransactionSequence = sequence,
                    Fingerprint = fingerPrint
                },
                Sale = sale
            };


          return Post(url, payload);
        }

        public static string CallPaymentMediatorsAsync(string baseUrl, string serialNumber, int sequence, string fingerPrint)
        {
            var url = $"https://{baseUrl}:4567/PaymentMediators";
            var payload = new
            {
                TransactionHandle = new
                {
                    SerialNumber = serialNumber,
                    TransactionDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff"),
                    TransactionSequence = sequence,
                    Fingerprint = fingerPrint,
                }
            };

            return Post(url, payload);
        }

        private static string Post(string url, object payload)
        {
            var handler = new HttpClientHandler();
            // Bypass SSL certificate validation - for development use only!
            handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            using (var client = new HttpClient(handler))
            {
                var json = JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    var response = client.PostAsync(url, content).Result;

                    // Read the response content
                    var responseContent =  response.Content.ReadAsStringAsync().Result;

                    Console.WriteLine($"Response for {url}:");
                    if (response.IsSuccessStatusCode)
                    { 
                        return "Başarılı : "+responseContent;
                    }
                    else
                    {
                        return $"Hata : {response.StatusCode} " + responseContent;
                    }
                }
                catch (HttpRequestException e)
                {
                    return $"Request exception: {e.Message}";
                }
            }
        }
    }
}

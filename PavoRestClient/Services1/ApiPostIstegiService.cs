using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PavoRestClient.Services1
{
    public class ApiPostIstegiService
    {
        private static readonly HttpClient client;

        static ApiPostIstegiService()
        {
            // .NET 4.5.2 için sertifika doğrulamasını global olarak devre dışı bırak
            System.Net.ServicePointManager.ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => true;

            client = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30)
            };
        }

        public static async Task PostAsync(string url, object payload)
        {
            var json = JsonConvert.SerializeObject(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);
                var responseContent = await response.Content.ReadAsStringAsync();
                System.IO.File.WriteAllText("sonuc.txt", responseContent);
                string a =($"Response for {url}:");
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Success! Response received:");
                    Console.WriteLine(responseContent);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    Console.WriteLine("Error details:");
                    Console.WriteLine(responseContent);
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request exception: {e.Message}");
            }
          
        }
    }
}

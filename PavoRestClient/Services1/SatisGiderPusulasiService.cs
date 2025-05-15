using PavoDeneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavoRestClient.Services1
{
    public class SatisGiderPusulasiService
    {
        public static async Task SatisGiderPusulasi(TransactionData transactionData)
        {
            var url = "https://192.168.1.203:4567/CompleteSale";


            //TransactionHandle ve Sale nesnesi gönderilmeli
            //Sale nesnesindeki Orderno alanı satış iptal edilmek istendiği zaman kullanılmalı ve unique olmalı
            TransactionData payload = transactionData;
        

            //Apiye istek attığımız yer
            await ApiPostIstegiService.PostAsync(url, payload);
        }
    }
}

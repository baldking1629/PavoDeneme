using PavoDeneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavoRestClient.Services1
{
    public class SatisIptalService
    {
        private static async Task SatisIptal(TransactionData transactionData)
        {
            var url = "https://192.168.1.203:4567/CancelSale";

            //TransactionHandle ve Sale nesnesi gönderilmeli
            //Sale nesnesine Orderno kesin olarak gönderilmeli
            TransactionData payload = transactionData;


            //Apiye istek attığımız yer
            await ApiPostIstegiService.PostAsync(url, payload);
        }
    }
}

using PavoDeneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavoRestClient.Services1
{
    public class EslestirService
    {

        public static async Task Eslestir(TransactionHandle transactionData)
        {
            var url = "https://192.168.1.203:4567/Pairing";

            //TransactionHandle nesnesi gönderilmeli
            //Uygulama ve cihazın eşlenmesi gereken durumda çalışmalı
            TransactionHandle payload = transactionData;

            //Apiye istek attığımız yer
            await ApiPostIstegiService.PostAsync(url, payload);
        }



    }
}

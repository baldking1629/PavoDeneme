using PavoDeneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavoRestClient.Models.ParcaliOdemeModel
{
    public class StartSaleWithItemsSale
    {
        public string RefererApp { get; set; }
        public string RefererAppVersion { get; set; }
        public int MainDocumentType { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public PriceEffect PriceEffect { get; set; }
        public bool SendPhoneNotification { get; set; }
        public bool SendEMailNotification { get; set; }
        public string NotificationPhone { get; set; }
        public string NotificationEMail { get; set; }
        public List<AddedSaleItem> AddedSaleItems { get; set; }
        public CustomerParty CustomerParty { get; set; }
        public List<AdditionalInfo> AdditionalInfo { get; set; }
    }
}

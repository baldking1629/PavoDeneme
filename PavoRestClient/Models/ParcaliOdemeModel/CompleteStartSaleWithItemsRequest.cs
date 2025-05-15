using PavoDeneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavoRestClient.Models.ParcaliOdemeModel
{
    public class CompleteStartSaleWithItemsRequest
    {
        TransactionHandle TransactionHandle { get; set; }
        StartSaleWithItemsSale Sale { get; set; }
    }
}

using PavoDeneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavoRestClient.Models.Response
{
    public class TransactionHandleResponse
    {
        public bool HasError { get; set; }
        public string Message { get; set; } = string.Empty;
        public TransactionHandle TransactionHandle { get; set; }
    }
}

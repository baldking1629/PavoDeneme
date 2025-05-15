using System;

namespace PavoDeneme.Models
{
    public class TransactionHandle
    {
        public string SerialNumber { get; set; }
        public string TransactionDate { get; set; }
        public int TransactionSequence { get; set; }
        public string Fingerprint { get; set; }
    }
} 
using System;

namespace PavoDeneme.Models
{
    public class TransactionHandle
    {
        public string SerialNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public int TransactionSequence { get; set; }
        public string Fingerprint { get; set; }
    }
} 
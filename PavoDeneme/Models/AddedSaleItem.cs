namespace PavoDeneme.Models
{
    public class AddedSaleItem
    {
        public string Name { get; set; }
        public bool IsGeneric { get; set; }
        public string UnitCode { get; set; }
        public string TaxGroupCode { get; set; }
        public decimal ItemQuantity { get; set; }
        public decimal UnitPriceAmount { get; set; }
        public decimal GrossPriceAmount { get; set; }
        public decimal TotalPriceAmount { get; set; }
        public string ReservedText { get; set; }
        public PriceEffect PriceEffect { get; set; }
    }
} 
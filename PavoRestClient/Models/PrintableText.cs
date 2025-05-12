namespace PavoDeneme.Models
{
    public class PrintableText : PrintableItem
    {
        public PrintableText() { type = "dText"; }
        public string alignment { get; set; }
        public int fontSize { get; set; }
        public string text { get; set; }
        public string fontWeight { get; set; }
        public int offset { get; set; }
        public int? rightMargin { get; set; }
        public int? leftMargin { get; set; }
    }
} 
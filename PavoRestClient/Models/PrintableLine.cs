namespace PavoDeneme.Models
{
    public class PrintableLine : PrintableItem
    {
        public PrintableLine() { type = "dLine"; }
        public int? dashWidth { get; set; }
    }
} 
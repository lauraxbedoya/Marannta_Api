namespace MaranntaApi.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public required string Category { get; set; }
        public required string Name { get; set; }
        public string? Color { get; set; }
        public required int Amount { get; set; }
        public required string Size { get; set; }
        public string? BreastSize { get; set; }
        public string? PurchasePrice { get; set; }
        public required int SalePrice { get; set; }
    }
}
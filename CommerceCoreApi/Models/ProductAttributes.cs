namespace CommerceCoreApi.Models
{
    public class ProductAttributes
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public List<string>? Color;
        public List<string>? Sizes;
        public List<ProductReview>? Reviews { get; set; }
        public string? Model { get; set; }
        public string? Material { get; set; }
        public DateTime ManufacutredDate { get; set; }        
        public DateTime ExpiryDate { get; set; }

    }
}

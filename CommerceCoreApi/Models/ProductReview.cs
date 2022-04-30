namespace CommerceCoreApi.Models
{
    public class ProductReview
    {
        public long ProductId { get; set; }
        public Double Rating { get; set; }
        public string? ReviewMessage { get; set; }
        public string? Reviewer { get; set; }
    }
}

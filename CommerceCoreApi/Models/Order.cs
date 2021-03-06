namespace CommerceCoreApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? CustomerId { get; set; }
        public List<Product>? Products { get; set; }
        public Double SubTotal { get; set; }
        public Double Total { get; set; }
        public string? Status { get; set; }
        public DateTime OrderDate { get; set; }
    }
}

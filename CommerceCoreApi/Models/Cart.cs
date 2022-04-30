namespace CommerceCoreApi.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public List<Product>? Products { get; set; }
        public Double SubTotal { get; set; }
        public Double Total { get; set; }
        public string? Status { get; set; }


    }
}

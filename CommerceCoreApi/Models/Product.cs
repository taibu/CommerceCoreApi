namespace CommerceCoreApi.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? CategoryId { get; set; }
        public string? SubCategoryId { get; set; }
        public int Price { get; set; }
        public Double Discount { get; set; }
        public int QuantityInStock { get; set; }
        public string? SKU { get; set; }
        public string? Status { get; set; }
        public List<ProductAttributes>? MoreAttributes { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; } = DateTime.Now;
        public string? CreatedBy { get; set; }
   
    }
}

namespace CommerceCoreApi.Models
{
    public class ProductCategory
    {

        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; } = DateTime.Now;
        public string? CreatedBy { get; set; }
    }
}

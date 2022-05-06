namespace CommerceCoreApi.Models
{
    public class Wishlist
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long UserId { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
    }
}

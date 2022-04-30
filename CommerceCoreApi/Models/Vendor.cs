namespace CommerceCoreApi.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string? VendorCode { get; set; }
        public string? VendorName { get; set; }
        public string? Publickey { get; set; }
        public string? Address { get; set; }
        public string? TinNumber { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; } = DateTime.Now;
        public string? CreatedBy { get; set; }
    }
}

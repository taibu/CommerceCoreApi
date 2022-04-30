namespace CommerceCoreApi.Models
{
    public class Transaction
    {
        private string ChequeNumber { get; set; }
        public string Narration { get; set; }
        public string CustRef { get; set; }
        public string CustName { get; set; }
        public string CustomerTel { get; set; }
        public string VendorTransactionRef { get; set; }
        public string TransactionType   { get; set; }
        public string VendorCode { get; set; }
        public string Password  { get; set; }
        public string Teller { get; set; }
        public string Reversal { get; set; }
        public string TeversedTrans { get; set; } 
        public string Offline { get; set; }
        public string UtilityCode { get; set; }
        public string PaymentDate { get; set; }
        public string TransactionAmount { get; set; }
        public string DigitalSignature { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string TransactionID { get; set; }
        public string Tin { get; set; }
    }
}

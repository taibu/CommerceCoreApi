namespace CommerceCoreApi.Models
{
    public class Response
    {
        private string statusCode;
        private string statusDesc;
        private string tranId;

        private string StatusCode { get => statusCode; set => statusCode = value; }
        public string StatusDesc { get => statusDesc; set => statusDesc = value; }
        public string TranId { get => tranId; set => tranId = value; }
    }
}

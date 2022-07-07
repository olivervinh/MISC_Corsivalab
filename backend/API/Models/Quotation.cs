using API.Models.Base;

namespace API.Models
{
    public class Quotation:EntityBase
    {
        public int FkPreviousQuotationRefId { get; set; }
        public  string Name { get; set; }
        public decimal QuotationVersion { get; set; }
        public decimal QuotationJson { get; set; }
        public decimal TotalQuote { get; set; }
        public string Remark { get; set; }
        public string Finalised { get; set; }
    }
}

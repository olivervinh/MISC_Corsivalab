using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_Quotation")]
    public class Quotation:EntityBase
    {
        [Column(name: "fkPreviousQuotationRef", TypeName = "int")]
        public int FkPreviousQuotationRefId { get; set; }
        [Column(name: "name", TypeName = "varchar(MAX)")]
        public  string Name { get; set; }
        [Column(name: "quotationVersion", TypeName = "decimal(18,5)")]
        public decimal QuotationVersion { get; set; }
        [Column(name: "quotationJson", TypeName = "nchar(10)")]
        public decimal QuotationJson { get; set; }
        [Column(name: "totalQuote", TypeName = "decimal(18,2)")]
        public decimal TotalQuote { get; set; }
        [Column(name: "remark", TypeName = "nchar(10)")]
        public string Remark { get; set; }
        [Column(name: "finalised", TypeName = "date")]
        public string Finalised { get; set; }
    }
}

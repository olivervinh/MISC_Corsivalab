using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_EmailSystem")]
    public class EmailSystem:EntityBase
    {
        [Column("EmailSystem",TypeName = "nvarchar(MAX)")]
        public string EmailSystemName { get; set; }
    }
}

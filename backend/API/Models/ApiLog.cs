using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_ApiLog")]
    public class ApiLog: EntityBase
    {
        [Column(name: "Description",TypeName = "varchar(MAX)")]
        public string Description { get; set; }
        [Column(name: "LogDateTime",TypeName = "datetime2")]
        public DateTime LogDateTime { get; set; }
    }
}

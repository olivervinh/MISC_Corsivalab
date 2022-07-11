using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_TechnolodyUsed")]
    public class TechnologyUsed : EntityBase
    {
        [Column(name: "Technology", TypeName = "varchar(MAX)")]
        public string Technology { get; set; }
    }
}

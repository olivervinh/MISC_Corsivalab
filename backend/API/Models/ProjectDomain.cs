using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_ProjectDomain")]
    public class ProjectDomain : EntityBase
    {
        [Column(name: "Domain", TypeName = "varchar(MAX)")]
        public string Domain { get; set; }
        [Column(name: "Expiry", TypeName = "datetime2(7)")]
        public DateTime Expiry { get; set; }
        [Column(name: "Provider", TypeName = "int")]
        public int Provider { get; set; }
        [Column(name: "Owner", TypeName = "int")]
        public int Owner { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        [Column(name: "FkProjectId", TypeName = "int")]
        public int FkProjectId { get; set; }
        [Column(name: "Cost", TypeName = "varchar(MAX)")]
        public string Cost { get; set; }
        //public virtual Project Project { get; set; }
    }
}

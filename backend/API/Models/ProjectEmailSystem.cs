using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_ProjectEmailSystem")]
    public class ProjectEmailSystem : EntityBase
    {
        [Column(name: "Provider", TypeName = "int")]
        public int Provider { get; set; }
        [Column(name: "Owner", TypeName = "int")]
        public int Owner { get; set; }
        [Column(name: "Expiry", TypeName = "datetime2(7)")]
        public DateTime Expiry { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        [Column(name: "FK_ProjectID", TypeName = "int")]
        public int FkProjectId { get; set; }
        [Column(name: "Cost", TypeName = "varchar(MAX)")]
        public string Cost { get; set; }
        [Column(name: "Remark", TypeName = "nvarchar(MAX)")]
        public string Remark { get; set; }
        [Column(name: "FkProjectDomainId", TypeName = "int")]
        public int FkProjectDomainId { get; set; }
        //public virtual Project Project { get; set; }
    }
}

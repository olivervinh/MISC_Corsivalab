using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_ProjectCredential")]
    public class ProjectCredential : EntityBase
    {
        [Column(name: "CredentialInfos", TypeName = "varchar(MAX)")]
        public string CredentialInfo { get; set; }
        [Column(name: "LastUpdate", TypeName = "datetime2(7)")]
        public DateTime LastUpdate { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        [Column(name: "FK_ProjectId", TypeName = "int")]
        public int FkProjectId { get; set; }
        //public virtual Project Project { get; set; }
    }
}

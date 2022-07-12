using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_StaffCredentialRequest")]
    public class StaffCredentialRequest : EntityBase
    {
        [Column(name: "ExpiryTime", TypeName = "datetime2(7)")]
        public DateTime ExpiryTime { get; set; }
        [Column(name: "Approved", TypeName = "bit")]
        public bool Approved { get; set; }
        //[ForeignKey(nameof(FkStaffId))]
        [Column(name: "FK_StaffId", TypeName = "int")]
        public int FkStaffId { get; set; }
        [Column(name: "FK_ProjectId", TypeName = "int")]
        //[ForeignKey(nameof(FkProjectId))]
        public int FkProjectId { get; set; }
        //public virtual Staff Staff { get; set; }
        //public virtual Project Project { get; set; }
    }
}

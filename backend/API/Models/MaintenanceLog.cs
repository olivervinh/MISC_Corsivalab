using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_MaintenanceLog")]
    public class MaintenanceLog : EntityBase
    {
        [Column("Remark", TypeName = "varchar(MAX)")]
        public string Remark { get; set; }
        [Column("LastUpdate", TypeName = "datetime2(7)")]
        public DateTime LastUpdate { get; set; }
        [Column("CreatedAt", TypeName = "datetime2(7)")]
        public DateTime CreatedAt { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        [Column("FkProjectId", TypeName = "int")]
        public int FkProjectId { get; set; }
        //[ForeignKey(nameof(FkStaffId))]
        [Column("FkStaffId", TypeName = "int")]
        public int FkStaffId { get; set; }
        //public virtual Project Project { get; set; }
        //public virtual Staff Staff { get; set; }
    }
}

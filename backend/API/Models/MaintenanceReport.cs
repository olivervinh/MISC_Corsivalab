using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_MaintenanceReport")]
    public class MaintenanceReport : EntityBase
    {
        [Column("FkProjectId", TypeName = "int")]
        public int FkProjectId { get; set; }
        [Column("FkStaffId", TypeName = "int")]
        public int FkStaffId { get; set; }
        [Column("Link", TypeName = "varchar(MAX)")]
        public string Link { get; set; }
        [Column("CreatedAt", TypeName = "datetime2(7)")]
        public DateTime CreatedAt { get; set; }
        [Column("MonthYear", TypeName = "datetime2(7)")]
        public DateTime MonthYear { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        //[ForeignKey(nameof(FkStaffId))]
        //public virtual Staff Staff { get; set; }
        //public virtual Project Project { get; set; }
    }
}

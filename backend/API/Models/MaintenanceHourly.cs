using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_MaintenanceHourly")]
    public class MaintenanceHourly : EntityBase
    {
        [Column("ServiceHourLeft", TypeName = "nvarchar(MAX)")]
        public string ServiceHourLeft { get; set; }
        [Column("ExpiryTime", TypeName = "nvarchar(MAX)")]
        public DateTime ExpiryTime { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        [Column("FK_ProjectId",TypeName ="int")]
        public int FkProjectId { get; set; }
        //public virtual Project Project { get; set; }
    }
}

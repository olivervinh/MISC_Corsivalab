using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_ProjectHourlyMaintenaceRecord")]
    public class ProjectHourlyMaintenanceRecord : EntityBase
    {
        [Column(name: "HoursSpent", TypeName = "float")]
        public double HoursSpent { get; set; }
        [Column(name: "HourResonRequest", TypeName = "varchar(MAX)")]
        public string HourResonRequest { get; set; }
        //[ForeignKey(nameof(FkProjectHourlyMaintenanceId))]
        [Column(name: "FkProjectHourlyMaintenaceId", TypeName = "int")]
        public int FkProjectHourlyMaintenanceId { get; set; }
        //public virtual ProjectHourlyMaintenance ProjectHourlyMaintenance { get; set; }
    }
}

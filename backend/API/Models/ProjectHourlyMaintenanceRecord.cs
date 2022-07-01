using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class ProjectHourlyMaintenanceRecord : EntityBase
    {
        public double HoursSpent { get; set; }
        public string HourResonRequest { get; set; }
        [ForeignKey(nameof(FkProjectHourlyMaintenanceId))]
        public int FkProjectHourlyMaintenanceId { get; set; }
        public virtual ProjectHourlyMaintenance ProjectHourlyMaintenance { get; set; }
    }
}

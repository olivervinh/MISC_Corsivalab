using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class ProjectHourlyMaintenance : EntityBase
    {
        public string HourPackge { get; set; }
        public double Cost { get; set; }
        public DateTime PurchasedDate { get; set; }
        public double HoursSpent { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        public int FkProjectId { get; set; }
        //public virtual Project Project { get; set; }
        //public virtual ICollection<ProjectHourlyMaintenanceRecord> ProjectHourlyMaintenanceRecords { get; set; }
    }
}

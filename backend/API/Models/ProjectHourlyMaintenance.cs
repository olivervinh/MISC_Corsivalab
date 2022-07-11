using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_ProjectHourlyMaintenace")]
    public class ProjectHourlyMaintenance : EntityBase
    {
        [Column(name: "HourPackge", TypeName = "varchar(MAX)")]
        public string HourPackge { get; set; }
        [Column(name: "Cost", TypeName = "decimal(18,0)")]
        public decimal Cost { get; set; }
        [Column(name: "PurchasedDate", TypeName = "datetime2")]
        public DateTime PurchasedDate { get; set; }
        [Column(name: "HoursSpent", TypeName = "float")]
        public double HoursSpent { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        [Column(name: "FkProjectId", TypeName = "int")]
        public int FkProjectId { get; set; }
        //public virtual Project Project { get; set; }
        //public virtual ICollection<ProjectHourlyMaintenanceRecord> ProjectHourlyMaintenanceRecords { get; set; }
    }
}

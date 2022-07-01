using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class MaintenanceReport : EntityBase
    {
        public string Link { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime MonthYear { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        public int FkProjectId { get; set; }
        //[ForeignKey(nameof(FkStaffId))]
        public int FkStaffId { get; set; }
        //public virtual Staff Staff { get; set; }
        //public virtual Project Project { get; set; }
    }
}

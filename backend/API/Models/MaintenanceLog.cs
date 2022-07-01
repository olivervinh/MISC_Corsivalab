using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class MaintenanceLog : EntityBase
    {
        public string Remark { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime CreatedAt { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        public int FkProjectId { get; set; }
        //[ForeignKey(nameof(FkStaffId))]
        public int FkStaffId { get; set; }
        //public virtual Project Project { get; set; }
        //public virtual Staff Staff { get; set; }
    }
}

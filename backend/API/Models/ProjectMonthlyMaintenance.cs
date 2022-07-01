using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class ProjectMonthlyMaintenance : EntityBase
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Amount { get; set; }
        public string Per { get; set; }
        [ForeignKey(nameof(FkProjectId))]
        public int FkProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}

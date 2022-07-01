using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class MaintenanceHourly : EntityBase
    {
        public string ServiceHourLeft { get; set; }
        public DateTime ExpiryTime { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        public int FkProjectId { get; set; }
        //public virtual Project Project { get; set; }
    }
}

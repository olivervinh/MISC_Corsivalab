using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class MaintenanceMontly : EntityBase
    {
        public DateTime ExpiryTime { get; set; }
        [ForeignKey(nameof(FkProjectId))]
        public int FkProjectId { get; set; }
        [ForeignKey(nameof(FkCustomerId))]
        public int FkCustomerId { get; set; }
        public virtual Project Project { get; set; }
        public virtual Customer Customer { get; set; }
    }
}

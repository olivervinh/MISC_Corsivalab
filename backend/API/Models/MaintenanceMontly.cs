using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_MaintenanceMontly")]
    public class MaintenanceMontly : EntityBase
    {
        [Column("ExpiryTime", TypeName = "datetime2")]
        public DateTime ExpiryTime { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        [Column("FkProjectId", TypeName = "int")]
        public int FkProjectId { get; set; }
        //public virtual Project Project { get; set; }
        //[ForeignKey(nameof(FkCustomerId))]
        //public int FkCustomerId { get; set; }
        //public virtual Customer Customer { get; set; }
    }
}

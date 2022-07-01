using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class StaffCredentialRequest : EntityBase
    {
        public DateTime ExpiryTime { get; set; }
        public bool Approved { get; set; }
        //[ForeignKey(nameof(FkStaffId))]
        public int FkStaffId { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        public int FkProjectId { get; set; }
        //public virtual Staff Staff { get; set; }
        //public virtual Project Project { get; set; }
    }
}

using API.Helpers.Enums;
using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Ticket : EntityBase
    {
        public string TicketNumber { get; set; }
        public string Subject { get; set; }
        public string Messages { get; set; }
        public TicketPriority Priority { get; set; }
        public int StaffAssigned { get; set; }
        public int Status { get; set; }
        [ForeignKey(nameof(FkProjectId))]
        public int FkProjectId { get; set; }
        [ForeignKey(nameof(FkCustomerId))]
        public int FkCustomerId { get; set; }
        [ForeignKey(nameof(FkStaffId))]
        public int FkStaffId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Project Project { get; set; }
        public virtual Staff Staff { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<TicketImage> TicketImages { get; set; }
        public virtual ICollection<TicketReply> TicketReplies { get; set; }
    }
}

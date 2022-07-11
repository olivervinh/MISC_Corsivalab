using API.Helpers.Enums;
using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_Tickets")]
    public class Ticket : EntityBase
    {
        [Column(name: "TicketNumber", TypeName = "varchar(MAX)")]
        public string TicketNumber { get; set; }
        [Column(name: "Subject", TypeName = "varchar(MAX)")]
        public string Subject { get; set; }
        [Column(name: "Messages", TypeName = "varchar(MAX)")]
        public string Messages { get; set; }
        [Column(name: "Priority", TypeName = "int")]
        public TicketPriority Priority { get; set; }
        [Column(name: "StaffAssigned", TypeName = "int")]
        public int StaffAssigned { get; set; }
        [Column(name: "Status", TypeName = "int")]
        public int Status { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        [Column(name: "FkProjectId", TypeName = "int")]
        public int FkProjectId { get; set; }
        //[ForeignKey(nameof(FkCustomerId))]
        [Column(name: "FkCustomerId", TypeName = "int")]
        public int FkCustomerId { get; set; }
        //[ForeignKey(nameof(FkStaffId))] 
        //public int FkStaffId { get; set; }
        //public virtual Customer Customer { get; set; }
        //public virtual Project Project { get; set; }
        //public virtual Staff Staff { get; set; }
        [Column(name: "CreatedAt", TypeName = "datetime2(7)")]
        public DateTime CreatedAt { get; set; }
        //public virtual ICollection<TicketImage> TicketImages { get; set; }
        //public virtual ICollection<TicketReply> TicketReplies { get; set; }
    }
}

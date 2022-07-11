using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_TicketReply")]
    public class TicketReply : EntityBase
    {
        [Column(name: "TicketNumber", TypeName = "varchar(MAX)")]
        public string TicketNumber { get; set; }
        [Column(name: "Messages", TypeName = "varchar(MAX)")]
        public string Messages { get; set; }
        [Column(name: "PersonReplyed", TypeName = "varchar(MAX)")]
        public string PersonReplyed { get; set; }
        [Column(name: "IsStaff", TypeName = "int")]
        public int IsStaff { get; set; }
        [Column(name: "Title", TypeName = "varchar(MAX)")]
        public string Title { get; set; }
        [Column(name: "CreatedAt", TypeName = "datetime2(7)")]
        public DateTime CreatedAt { get; set; }
        [Column(name: "Approve", TypeName = "bit")]
        public bool Approve { get; set; }
        //[ForeignKey(nameof(FkTicketId))]
        [Column(name: "FK_TicketiId", TypeName = "int")]
        public int FkTicketId { get; set; }
        //public virtual Ticket Ticket { get; set; }
    }
}

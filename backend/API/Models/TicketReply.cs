using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class TicketReply : EntityBase
    {
        public string TicketNumber { get; set; }
        public string Messages { get; set; }
        public string PersonReplyed { get; set; }
        public int IsStaff { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Approve { get; set; }
        //[ForeignKey(nameof(FkTicketId))]
        public int FkTicketId { get; set; }
        //public virtual Ticket Ticket { get; set; }
    }
}

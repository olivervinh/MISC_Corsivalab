using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class TicketImage : EntityBase
    {
        public string TicketImageName { get; set; }
        //[ForeignKey(nameof(FkTicketId))]
        public int FkTicketId { get; set; }
        //public virtual Ticket Ticket { get; set; }
    }
}

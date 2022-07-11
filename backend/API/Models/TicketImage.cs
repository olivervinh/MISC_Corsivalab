using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_TicketImages")]
    public class TicketImage : EntityBase
    {
        [Column(name: "TicketImage", TypeName = "nvarchar(MAX)")]
        public string TicketImageName { get; set; }
        //[ForeignKey(nameof(FkTicketId))]
        [Column(name: "FK_TicketId", TypeName = "int")]
        public int FkTicketId { get; set; }
        //public virtual Ticket Ticket { get; set; }
    }
}

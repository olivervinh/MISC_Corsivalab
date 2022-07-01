using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface ITicketReplyService : IBaseService<TicketReply> { }
    public class TicketReplyService : BaseService<TicketReply>,ITicketReplyService
    {
        public TicketReplyService(AppDbContext context) : base(context)
        {
        }
    }
}

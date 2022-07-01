using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public class TicketReplyService : BaseService<TicketReply>
    {
        public TicketReplyService(AppDbContext context) : base(context)
        {
        }
    }
}

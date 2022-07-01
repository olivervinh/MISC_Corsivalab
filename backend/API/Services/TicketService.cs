using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public class TicketService : BaseService<Ticket>
    {
        public TicketService(AppDbContext context) : base(context)
        {
        }
    }
}

using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface ITicketService : IBaseService<Ticket> { }
    public class TicketService : BaseService<Ticket>, ITicketService
    {
        public TicketService(AppDbContext context) : base(context)
        {
        }
    }
}

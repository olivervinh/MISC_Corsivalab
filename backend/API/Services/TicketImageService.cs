using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public class TicketImageService : BaseService<TicketImage>
    {
        public TicketImageService(AppDbContext context) : base(context)
        {
        }
    }
}

using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface ITicketImageService : IBaseService<TicketImage>
    {

    }
    public class TicketImageService : BaseService<TicketImage>,ITicketImageService
    {
        public TicketImageService(AppDbContext context) : base(context)
        {
        }
    }
}

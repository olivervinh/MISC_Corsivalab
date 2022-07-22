using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IEmailSystemService:IBaseService<EmailSystem>
    {
    }
    public class EmailSystemService : BaseService<EmailSystem>, IEmailSystemService
    {
        public EmailSystemService(AppDbContext context) : base(context)
        {
        }
    }
}

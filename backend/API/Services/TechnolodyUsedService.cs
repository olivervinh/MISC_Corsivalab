using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public class TechnologyUsedService : BaseService<TechnologyUsed>
    {
        public TechnologyUsedService(AppDbContext context) : base(context)
        {
        }
    }
}

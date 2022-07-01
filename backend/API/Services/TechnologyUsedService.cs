using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface ITechnologyUsedService : IBaseService<TechnologyUsed> { }
    public class TechnologyUsedService : BaseService<TechnologyUsed>,ITechnologyUsedService
    {
        public TechnologyUsedService(AppDbContext context) : base(context)
        {
        }
    }
}

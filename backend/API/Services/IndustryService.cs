using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IIndustryService : IBaseService<Industry>
    {

    }
    public class IndustryService : BaseService<Industry>,IIndustryService
    {
        public IndustryService(AppDbContext context) : base(context)
        {
        }
    }
}

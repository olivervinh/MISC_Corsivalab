using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IMaintenanceMontlyService : IBaseService<MaintenanceMontly>
    {
    }
    public class MaintenanceMontlyService : BaseService<MaintenanceMontly>
    {
        public MaintenanceMontlyService(AppDbContext context) : base(context)
        {
        }
    }
}

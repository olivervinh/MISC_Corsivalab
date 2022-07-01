using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IMaintenanceHourlyService : IBaseService<MaintenanceHourly>
    {

    }
    public class MaintenanceHourlyService : BaseService<MaintenanceHourly>,IMaintenanceHourlyService
    {
        public MaintenanceHourlyService(AppDbContext context) : base(context)
        {
        }
    }
}

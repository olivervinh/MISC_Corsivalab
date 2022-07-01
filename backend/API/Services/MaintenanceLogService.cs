using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IMaintenanceLogService:IBaseService<MaintenanceLog>
    {

    }
    public class MaintenanceLogService : BaseService<MaintenanceLog>, IMaintenanceLogService
    {
        public MaintenanceLogService(AppDbContext context) : base(context)
        {
        }
    }
}

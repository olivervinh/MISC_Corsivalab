using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IProjectMonthlyMaintenanceService : IBaseService<ProjectMonthlyMaintenance>
    {

    }
    public class ProjectMonthlyMaintenanceService : BaseService<ProjectMonthlyMaintenance>, IProjectMonthlyMaintenanceService
    {
        public ProjectMonthlyMaintenanceService(AppDbContext context) : base(context)
        {
        }
    }
}

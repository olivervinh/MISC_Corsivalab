using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IProjectHourlyMaintenanceService : IBaseService<ProjectHourlyMaintenance>
    {
    }
    public class ProjectHourlyMaintenanceService : BaseService<ProjectHourlyMaintenance>, IProjectHourlyMaintenanceService
    {
        public ProjectHourlyMaintenanceService(AppDbContext context) : base(context)
        {
        }
    }
}

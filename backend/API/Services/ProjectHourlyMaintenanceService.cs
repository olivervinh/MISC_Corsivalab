using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public class ProjectHourlyMaintenanceService : BaseService<ProjectHourlyMaintenance>
    {
        public ProjectHourlyMaintenanceService(AppDbContext context) : base(context)
        {
        }
    }
}

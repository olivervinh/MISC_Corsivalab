using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public class ProjectMonthlyMaintenanceService : BaseService<ProjectMonthlyMaintenance>
    {
        public ProjectMonthlyMaintenanceService(AppDbContext context) : base(context)
        {
        }
    }
}

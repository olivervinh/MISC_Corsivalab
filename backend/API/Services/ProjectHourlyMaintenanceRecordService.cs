using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public class ProjectHourlyMaintenanceRecordService : BaseService<ProjectHourlyMaintenanceRecord>
    {
        public ProjectHourlyMaintenanceRecordService(AppDbContext context) : base(context)
        {
        }
    }
}

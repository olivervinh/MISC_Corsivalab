using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IProjectHourlyMaintenanceRecordService : IBaseService<ProjectHourlyMaintenanceRecord>
    {

    }
    public class ProjectHourlyMaintenanceRecordService : BaseService<ProjectHourlyMaintenanceRecord>, IProjectHourlyMaintenanceRecordService
    {
        public ProjectHourlyMaintenanceRecordService(AppDbContext context) : base(context)
        {
        }
    }
}

using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IMaintenanceReportService: IBaseService<MaintenanceReport>
    {

    }
    public class MaintenanceReportService : BaseService<MaintenanceReport>,IMaintenanceReportService
    {
        public MaintenanceReportService(AppDbContext context) : base(context)
        {
        }
    }
}

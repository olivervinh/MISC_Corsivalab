using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public class MaintenanceReportService : BaseService<MaintenanceReport>
    {
        public MaintenanceReportService(AppDbContext context) : base(context)
        {
        }
    }
}

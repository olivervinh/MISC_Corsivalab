using API.Data;
using API.Helpers;
using API.Models;
using API.Services.Base;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public interface IMaintenanceHourlyService : IBaseService<MaintenanceHourly>
    {
        public Task<IEnumerable<MaintenanceHourly>> GetMaintenanceHourlies();
    }
    public class MaintenanceHourlyService : BaseService<MaintenanceHourly>,IMaintenanceHourlyService
    {
        public MaintenanceHourlyService(AppDbContext context,ICustomerService customerService,IProjectService projectService) : base(context)
        {
        }
        public async Task<IEnumerable<MaintenanceHourly>> GetMaintenanceHourlies()
        {
            //join
            var query = from m in _context.MaintenanceHourlies
                        join p in _context.Projects
                        on m.FkProjectId equals p.Id
                        join c in _context.Customers
                        on p.FkCustomerId equals c.Id
                        select new MaintenanceHourly
                        {
                            Id = m.Id,
                            ExpiryTime = m.ExpiryTime,
                            FkProjectId = m.FkProjectId,
                            ServiceHourLeft = m.ServiceHourLeft,
                            Project = p,
                            Customer = c,
                            SoftDelete = m.SoftDelete,
                        };
            //list
            return await query.OrderBy(x=>x.Customer.Company).ToListAsync();
        }
    }
}

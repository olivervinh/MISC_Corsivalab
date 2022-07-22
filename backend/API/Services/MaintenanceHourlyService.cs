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
        private readonly IProjectService _projectService;
        public MaintenanceHourlyService(AppDbContext context, ICustomerService customerService,IProjectService projectService) : base(context)
        {
            _projectService = projectService;
        }
        public async Task<IEnumerable<MaintenanceHourly>> GetMaintenanceHourlies()
        {
            var query = from m in _context.MaintenanceHourlies
                        select new MaintenanceHourly()
                        {
                            Id = m.Id,
                            ServiceHourLeft = m.ServiceHourLeft,
                            FkProjectId = m.FkProjectId,
                            ExpiryTime = m.ExpiryTime,
                            Project =  _projectService.GetByFirstVariable(m.FkProjectId).Result,
                        };
            return await query.ToListAsync();
            ////join
            //var query = from m in _context.Projects
            //            join p in _context.MaintenanceHourlies
            //            on m.Id equals p.FkProjectId
            //            into ps
            //            from p in ps.DefaultIfEmpty()
            //            join c in _context.Customers
            //            on m.FkCustomerId equals c.Id
            //            into c2
            //            from c in c2.DefaultIfEmpty()
            //            select new MaintenanceHourly
            //            {
            //                Id = p.Id,
            //                ExpiryTime = p.ExpiryTime,
            //                FkProjectId = p.FkProjectId,
            //                ServiceHourLeft = p.ServiceHourLeft,
            //                Project = m,
            //                Customer = c,
            //                SoftDelete = m.SoftDelete,
            //            };
            ////list
            //return await query.OrderBy(x=>x.Customer.Company).ToListAsync();
        }
    }
}

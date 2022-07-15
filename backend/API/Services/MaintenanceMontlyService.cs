using API.Data;
using API.Helpers;
using API.Models;
using API.Services.Base;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public interface IMaintenanceMontlyService : IBaseService<MaintenanceMontly>
    {
        public Task<IEnumerable<MaintenanceMontly>> GetMaintenanceMontlies();
    }
    public class MaintenanceMontlyService : BaseService<MaintenanceMontly>, IMaintenanceMontlyService
    {
        public MaintenanceMontlyService(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<MaintenanceMontly>> GetMaintenanceMontlies()
        {
            //join
            var query = from m in _context.MaintenanceMontlies
                        join p in _context.Projects
                        on m.FkProjectId equals p.Id
                        join c in _context.Customers
                        on p.FkCustomerId equals c.Id
                        select new MaintenanceMontly()
                        {
                            Id = m.Id,
                            ExpiryTime = m.ExpiryTime,
                            Customer = c,
                            Project = p,
                            FkProjectId = m.FkProjectId,
                            SoftDelete = m.SoftDelete,
                        };

            //check condition
            if (StaticHelper.StaffTeam != "205" && StaticHelper.StaffTeam != "305")
            {
                return await query.OrderBy(x => x.Customer.Company).ToListAsync();
            }
            else
            {
                return await query.OrderBy(x => x.Customer.Company).ToListAsync();
            }
        }
    }
}

using API.Data;
using API.Dtos;
using API.Helpers;
using API.Models;
using API.Services.Base;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public interface IProjectService : IBaseService<Project>
    {
        public Task<IEnumerable<Project>> ListProject120Domain();
        public Task<IEnumerable<Project>> ListProject120Hosting();
        public Task<IEnumerable<Project>> ListProject120Email();
        public Task<IEnumerable<Project>> ListProject120Maintenance();
        public Task<IEnumerable<CountProjectDto>> ListProjectCountMaintenance();
        public Task<PaginatedListHelper<Project>> PaginatedListProject(int pageNumber, int pageSize);
        //be call
        public Task<Project> GetProjectByFirstVariableDashboardViewModel(int Id, string expiry_date);
        //be call
    }
    public class ProjectService : BaseService<Project>,IProjectService
    {
        public DateTime today = DateTime.UtcNow.AddHours(8);
        public ProjectService(AppDbContext context) : base(context)
        {
        }
        public async Task<int> CountNotTagged()
        {
            return await _context.Projects
                  .Where(x => x.MaintainBy == "-" || x.MaintainBy == "0" && x.Phase == 3)
                  .CountAsync();
        }
        public async Task<IEnumerable<Project>> ListProject120Domain()
        {
            var listProject120Domain = new List<Project>();
            var domainListWithoutCustomer = _context.ProjectDomains.Where(x => x.Owner == 1);
            var domainListNewest = await domainListWithoutCustomer
                .GroupBy(s => s.FkProjectId)
                .Select(s => s.LastOrDefault())
                .ToListAsync();
            if(domainListNewest.Count>0)
            {
                foreach(var item in domainListNewest)
                {
                    if((item.Expiry.Month- today.Month)<ConstantHelper.ProjectMonthNumber && (item.Expiry - today).TotalDays > 0)
                    {
                        listProject120Domain.Add(await GetProjectByFirstVariableDashboardViewModel(item.FkProjectId, item.Expiry.ToString()));
                    }
                }
            }
            return listProject120Domain;
        }
        public async Task<IEnumerable<Project>> ListProject120Hosting()
        {
            var listProject120Hosting = new List<Project>();
            var hostingListWithoutCustomer = _context.ProjectHostings.Where(x => x.Owner == 1);
            var hostingListNewest = await hostingListWithoutCustomer
                .GroupBy(s => s.FkProjectId)
                .Select(s => s.LastOrDefault())
                .ToListAsync();
            if (hostingListNewest.Count > 0)
            {
                foreach (var item in hostingListNewest)
                {
                    if ((item.Expiry.Month - today.Month) < ConstantHelper.ProjectMonthNumber && (item.Expiry - today).TotalDays > 0)
                    {
                        listProject120Hosting.Add(await GetProjectByFirstVariableDashboardViewModel(item.FkProjectId, item.Expiry.ToString()));
                    }
                }
            }
            return listProject120Hosting;
        }
        public async Task<IEnumerable<Project>> ListProject120Email()
        {
            var listProject120Email = new List<Project>();
            var emailListWithoutCustomer = _context.ProjectEmailSystems.Where(x => x.Owner == 1);
            var emailListNewest = await emailListWithoutCustomer
                .GroupBy(s => s.FkProjectId)
                .Select(s => s.LastOrDefault())
                .ToListAsync();
            if (emailListNewest.Count > 0)
            {
                foreach (var item in emailListNewest)
                {
                    if ((item.Expiry.Month - today.Month) < ConstantHelper.ProjectMonthNumber && (item.Expiry - today).TotalDays > 0)
                    {
                        listProject120Email.Add(await GetProjectByFirstVariableDashboardViewModel(item.FkProjectId, item.Expiry.ToString()));
                    }
                }
            }
            return listProject120Email;
        }
        public async Task<IEnumerable<Project>> ListProject120Maintenance()
        {
            var listProject120Maintenance = new List<Project>();
            var maintenanceListWithoutCustomer = _context.ProjectMonthlyMaintenances;
            var maintenanceListNewest = await maintenanceListWithoutCustomer
                .GroupBy(s => s.FkProjectId)
                .Select(s => s.LastOrDefault())
                .ToListAsync();
            if (maintenanceListNewest.Count > 0)
            {
                foreach (var item in maintenanceListNewest)
                {
                    if ((item.EndDate.Month - today.Month) < ConstantHelper.ProjectMonthNumber && (item.EndDate - today).TotalDays > 0)
                    {
                        listProject120Maintenance.Add(await GetProjectByFirstVariableDashboardViewModel(item.FkProjectId, item.EndDate.ToString()));
                    }
                }
            }
            return listProject120Maintenance;
        }
        public async Task<Project> GetProjectByFirstVariableDashboardViewModel(int Id, string expiry_date)
        {
            var project =  await _context.Projects.FirstOrDefaultAsync(x => x.Id == Id);
            var newProject = new Project()
            {
                Id = project.Id,
                Title = project.Title,
                FkCustomerId = project.FkCustomerId,
                MaintainBy = project.MaintainBy,
                SoftDelete = project.SoftDelete,
                AMEmail=project.AMEmail,
                Phase = project.Phase,
                ProjectNature =project.ProjectNature,
                MaintCost = project.MaintCost,
                Remark = project.Remark,
                Code = project.Code,
                ShortLink = project.ShortLink,
                MaintExpire = project.MaintExpire,
                MaintStart = project.MaintStart,
                Forecast = project.Forecast,
                ForecastStart = project.ForecastStart,
                ForecastAmount = project.ForecastAmount,
                ExpiryDashboardView = Convert.ToDateTime(expiry_date),
            };
            return newProject;
        }
        public async Task<IEnumerable<CountProjectDto>> ListProjectCountMaintenance()
        {
            return await _context.Projects
               .Where(x => x.MaintainBy != "0" && x.MaintainBy != "-")
               .GroupBy(x => x.MaintainBy)
               .Select(item => new CountProjectDto()
               {
                   MaintainBy = item.FirstOrDefault().MaintainBy,
                   Countproject = item.Count(),
               }).ToListAsync();
        }

        public async Task<PaginatedListHelper<Project>> PaginatedListProject(int pageNumber,int pageSize)
        {
            return await PaginatedListHelper<Project>.CreateAsync(_context.Projects.AsNoTracking(), pageNumber != null ? pageNumber : 1, pageSize);
        }
    }
}

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
        //IQueryable IEnumrable
        public Task<UpdateProject_ProjectDetail_Dto> UpdateProject_GetProjectDetail(int Id);
        public Task<ICollection<Project>> ListProject120Domain();
        public Task<ICollection<Project>> ListProject120Hosting();
        public Task<ICollection<Project>> ListProject120Email();
        public Task<ICollection<Project>> ListProject120Maintenance();
        public Task<IEnumerable<CountProjectDto>> ListProjectCountMaintenance();
        public Task<int> ListProjectsNoPerson();
        public Task<MaintenanceProjectAssignedDto> GetMaintenanceProjectAssigned(string maintainBy);
        //IQueryable IEnumrable

        //Paginated
        //public Task<PaginatedListHelper<Project>> PaginatedListProject(int pageNumber, int pageSize);
        //public Task<PaginatedListHelper<Project>> PaginatedListProject120Domain(int pageNumber, int pageSize);
        //public Task<PaginatedListHelper<Project>> PaginatedListProject120Hosting(int pageNumber, int pageSize);
        //public Task<PaginatedListHelper<Project>> PaginatedListProject120Email(int pageNumber, int pageSize);
        //public Task<PaginatedListHelper<Project>> PaginatedListProject120Maintenance(int pageNumber, int pageSize);
        //Paginated

        //be call
        public Task<Project> GetProjectByFirstVariableDashboardViewModel(int Id, string expiry_date);
        //be call

        //public Task<Project> GetProjectDetails(int Id);
        public Task<ICollection<ProjectMonthlyMaintenance>> GetProjectMonthlyMaintenanceList(int FkProjectId);
        public Task<ICollection<ProjectHourlyMaintenance>> GetProjectHourlyMaintenanceList(int FkProjectId);
        public Task<ProjectBackUp> GetProjectBackupLink(int Id);
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
                  .Where(x => x.MaintainBy == "-" || x.MaintainBy == "0" && x.Phase == 3 && x.SoftDelete == false)
                  .CountAsync();
        }
        public async Task<ICollection<Project>> ListProject120Domain()
        {
            var listProject120Domain = new List<Project>();
            var domainListWithoutCustomer = _context.ProjectDomains.Where(x => x.Owner == 1 && x.SoftDelete == false);
            var domainListNewest = await domainListWithoutCustomer
                .OrderByDescending(s=>s.Id)
                .GroupBy(s => s.FkProjectId)
                .Select(s => s.FirstOrDefault())
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
            return listProject120Domain.OrderBy(x => x.ExpiryDashboardView).ToList();
        }
        public async Task<ICollection<Project>> ListProject120Hosting()
        {
            var listProject120Hosting = new List<Project>();
            var hostingListWithoutCustomer = _context.ProjectHostings.Where(x => x.Owner == 1 && x.SoftDelete == false);
            var hostingListNewest = await hostingListWithoutCustomer
                .OrderByDescending(s=>s.Id)
                .GroupBy(s => s.FkProjectId)
                .Select(s => s.FirstOrDefault())
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
            return listProject120Hosting.OrderBy(x => x.ExpiryDashboardView).ToList();
        }
        public async Task<ICollection<Project>> ListProject120Email()
        {
            var listProject120Email = new List<Project>();
            var emailListWithoutCustomer = _context.ProjectEmailSystems.Where(x => x.Owner == 1 && x.SoftDelete == false);
            var emailListNewest = await emailListWithoutCustomer
                .OrderByDescending(s => s.Id)
                .GroupBy(s => s.FkProjectId)
                .Select(s => s.FirstOrDefault())
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
            return listProject120Email.OrderBy(x => x.ExpiryDashboardView).ToList();
        }
        public async Task<ICollection<Project>> ListProject120Maintenance()
        {
            var listProject120Maintenance = new List<Project>();
            var maintenanceListWithoutCustomer = _context.ProjectMonthlyMaintenances;
            var maintenanceListNewest = await maintenanceListWithoutCustomer
                .OrderByDescending(s=>s.Id)
                .GroupBy(s => s.FkProjectId)
                .Select(s => s.FirstOrDefault())
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
            return listProject120Maintenance.OrderBy(x => x.ExpiryDashboardView).ToList();
        }
        public async Task<Customer> GetCustomerAsync(int Id)
        {
            return await _context.Customers.FindAsync(Id);
        }
        public async Task<Project> GetProjectByFirstVariableDashboardViewModel(int Id, string expiry_date)
        {
            var project =  await _context.Projects.FirstOrDefaultAsync(x => x.Id == Id&& x.SoftDelete == false);
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
                CustomerName = (await GetCustomerAsync((int)project.FkCustomerId)).Email,
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

        //public async Task<PaginatedListHelper<Project>> PaginatedListProject(int pageNumber,int pageSize)
        //{
        //    return await PaginatedListHelper<Project>.CreateAsync(_context.Projects.AsNoTracking(), pageNumber != null ? pageNumber : 1, pageSize);
        //}

        //public async Task<PaginatedListHelper<Project>> PaginatedListProject120Domain(int pageNumber, int pageSize)
        //{
        //    return await PaginatedListHelper<Project>.CreateAsync(await ListProject120Domain(), pageNumber != null ? pageNumber : 1, pageSize);
        //}

        //public async Task<PaginatedListHelper<Project>> PaginatedListProject120Hosting(int pageNumber, int pageSize)
        //{
        //    return await PaginatedListHelper<Project>.CreateAsync(await ListProject120Hosting(), pageNumber != null ? pageNumber : 1, pageSize);
        //}

        //public async Task<PaginatedListHelper<Project>> PaginatedListProject120Email(int pageNumber, int pageSize)
        //{
        //    return await PaginatedListHelper<Project>.CreateAsync(await ListProject120Email(), pageNumber != null ? pageNumber : 1, pageSize);
        //}

        //public async Task<PaginatedListHelper<Project>> PaginatedListProject120Maintenance(int pageNumber, int pageSize)
        //{
        //    return await PaginatedListHelper<Project>.CreateAsync(await ListProject120Maintenance(), pageNumber != null ? pageNumber : 1, pageSize);
        //}
        public async Task<int> ListProjectsNoPerson()
        {
            return await _context.Projects.Where(x => x.SoftDelete==false&& x.MaintainBy == "-" || x.MaintainBy == "0" && x.Phase == 3).CountAsync();
        }
        public async Task<MaintenanceProjectAssignedDto> GetMaintenanceProjectAssigned(string maintainBy)
        {
            MaintenanceProjectAssignedDto dto = new MaintenanceProjectAssignedDto();

            if (maintainBy != null)
            {
                dto.MaintainBy = "by " + maintainBy;
                dto.MaintenanceProjects = await _context.Projects.Where(x => x.MaintainBy == maintainBy).Select( x => new MaintenanceProject
                { 
                    Id = x.Id,
                    Title = x.Title,
                    CustomerName =  _context.Customers.FirstOrDefault(a=>a.Id==x.FkCustomerId).Email,
                }).ToListAsync();
            }
            else
            {
                dto.MaintainBy = "to no one";
                dto.MaintenanceProjects = await _context.Projects.Where(s => s.MaintainBy == "-" || s.MaintainBy == "0" && s.Phase == 3).Select(x => new MaintenanceProject
                {
                    Id = x.Id,
                    Title = x.Title,
                    CustomerName = _context.Customers.Find(x.FkCustomerId).Email,
                }).ToListAsync();
            }
            return dto;
        }

        public async Task<UpdateProject_ProjectDetail_Dto> UpdateProject_GetProjectDetail(int Id)
        {
            var project = await _context.Projects.FindAsync(Id);
            UpdateProject_ProjectDetail_Dto model = new UpdateProject_ProjectDetail_Dto();
            model.ProjectNature = TupleHelper.GetProjectNature((int)(project).ProjectNature);
            model.Title = project.Title;
            model.IpKeyURL = project.Code;
            model.TheSecondLink = project.Code != "" ? ("https://webmaster.corsivalab.com/redirect.aspx?project=" + Id + "&key=" + project.Code) : "";
            model.TheFirstLink = project.ShortLink;
            model.MaintenanceShortLink = project.MaintenanceShortLink;
            model.CustomerName = (await _context.Customers.FindAsync(project.FkCustomerId)).Username;
            return model;
        }

        public async Task<ProjectBackUp> GetProjectBackupLink(int Id)
        {
            var projectBackupLink = await _context.ProjectBackUps.FirstOrDefaultAsync(x => x.FkProjectId == Id);
            return projectBackupLink;
        }
        public async Task<ICollection<ProjectMonthlyMaintenance>> GetProjectMonthlyMaintenanceList(int FkProjectId)
        {
            var list = await _context.ProjectMonthlyMaintenances.Where(x => x.FkProjectId == FkProjectId).ToListAsync();
            return list;
        }

        public async Task<ICollection<ProjectHourlyMaintenance>> GetProjectHourlyMaintenanceList(int FkProjectId)
        {
            var list = await _context.ProjectHourlyMaintenances.Where(x => x.FkProjectId == FkProjectId).ToListAsync();
            return list;
        }

        //public async Task<Project> GetProjectDetails(int Id)
        //{
        //   var result = await _context.Projects.Select(x=>new Project() { 
        //        Id = x.Id,
        //        AMEmail = x.AMEmail,
        //        BackUp = x.BackUp,
        //        Code = x.Code,
        //        CreatedAtDatetime = x.CreatedAtDatetime,
        //        Credential = x.Credential,
        //        Customer = x.Customer,
        //        CustomerName = x.CustomerName,
        //        Domain = x.Domain,
        //        DomainCost = x.DomainCost,
        //        EmailCost = x.EmailCost,
        //        EmailSystemExpire = x.EmailSystemExpire,
        //        EmailSystemOwner = x.EmailSystemOwner,
        //        Expiry = x.Expiry,
        //        ExpiryDashboardView = x.ExpiryDashboardView,
        //        FkCustomerId = x.FkCustomerId,
        //        FkDomainProviderId = x.FkDomainProviderId,
        //        FkEmailSystemId =x.FkEmailSystemId,
        //        Forecast = x.Forecast,
        //        ForecastAmount = x.ForecastAmount,
        //        ForecastStart = x.ForecastStart,
        //        HostingCost = x.HostingCost,
        //        MaintCost = x.MaintCost,
        //        MaintainBy = x.MaintainBy,
        //        Maintenance = x.Maintenance,
        //        MaintenanceShortLink = x.MaintenanceShortLink,
        //        MaintExpire = x.MaintExpire,
        //        MaintStart = x.MaintStart,
        //        newId = x.newId,
        //        ProjectNature = x.ProjectNature,

        //   })
        //}
    }
}

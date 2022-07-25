using API.Data;
using API.Helpers;
using API.Models;
using API.Services.Base;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public interface IProjectDomainService : IBaseService<ProjectDomain>
    {
        public Task<PaginatedListHelper<ProjectDomain>> PaginatedListProjectDomain(int pageNumber, int pageSize);
        public Task<IEnumerable<ProjectDomain>> GetProjectDomainsListByProjectId(int Id);
    }
    public class ProjectDomainService : BaseService<ProjectDomain>, IProjectDomainService
    {
        public ProjectDomainService(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<ProjectDomain>> GetProjectDomainsListByProjectId(int Id)
        {
            return await _context.ProjectDomains.Where(x => x.FkProjectId == Id).ToListAsync();
        }
        public async Task<PaginatedListHelper<ProjectDomain>> PaginatedListProjectDomain(int pageNumber, int pageSize)
        {
            return await PaginatedListHelper<ProjectDomain>.CreateAsync(_context.ProjectDomains.AsNoTracking(), pageNumber != null ? pageNumber : 1, pageSize);
        }
    }
}
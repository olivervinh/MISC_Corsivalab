using API.Data;
using API.Models;
using API.Services.Base;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public interface IProjectHostingService : IBaseService<ProjectHosting>
    {
        public Task<IEnumerable<ProjectHosting>> GetProjectHostingListByProjectId(int Id);
    }
    public class ProjectHostingService : BaseService<ProjectHosting>, IProjectHostingService
    {
        public ProjectHostingService(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<ProjectHosting>> GetProjectHostingListByProjectId(int Id)
        {
            return await _context.ProjectHostings.Where(x => x.FkProjectId == Id).ToListAsync();
        }
    }
}

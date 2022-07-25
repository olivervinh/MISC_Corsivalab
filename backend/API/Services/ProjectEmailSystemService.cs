using API.Data;
using API.Models;
using API.Services.Base;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public interface IProjectEmailSystemService : IBaseService<ProjectEmailSystem>
    {
        public Task<IEnumerable<ProjectEmailSystem>> GetProjectEmailSystemListByProjectId(int Id);
    }
    public class ProjectEmailSystemService : BaseService<ProjectEmailSystem>, IProjectEmailSystemService
    {
        public ProjectEmailSystemService(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<ProjectEmailSystem>> GetProjectEmailSystemListByProjectId(int Id)
        {
            return await _context.ProjectEmailSystems.Where(x => x.FkProjectId == Id).ToListAsync();
        }
    }
}

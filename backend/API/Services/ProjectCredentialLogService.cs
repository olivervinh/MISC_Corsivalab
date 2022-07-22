using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IProjectCredentialLogService : IBaseService<ProjectCredentialLog>
    {
    }
    public class ProjectCredentialLogService : BaseService<ProjectCredentialLog>,IProjectCredentialLogService
    {
        public ProjectCredentialLogService(AppDbContext context) : base(context)
        {
        }
    }
}

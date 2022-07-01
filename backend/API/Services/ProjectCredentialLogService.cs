using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public class ProjectCredentialLogService : BaseService<ProjectCredentialLog>
    {
        public ProjectCredentialLogService(AppDbContext context) : base(context)
        {
        }
    }
}

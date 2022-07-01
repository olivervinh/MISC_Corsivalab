using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public class ProjectCredentialService : BaseService<ProjectCredential>
    {
        public ProjectCredentialService(AppDbContext context) : base(context)
        {
        }
    }
}

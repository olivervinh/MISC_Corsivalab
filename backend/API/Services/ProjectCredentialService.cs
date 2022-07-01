using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IProjectCredentialService : IBaseService<ProjectCredential>
    {

    }
    public class ProjectCredentialService : BaseService<ProjectCredential>,IProjectCredentialService
    {
        public ProjectCredentialService(AppDbContext context) : base(context)
        {
        }
    }
}

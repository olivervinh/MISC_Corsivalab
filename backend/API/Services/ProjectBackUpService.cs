using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IProjectBackupService : IBaseService<ProjectBackUp>
    {

    }
    public class ProjectBackUpService : BaseService<ProjectBackUp>, IProjectBackupService
    {
        public ProjectBackUpService(AppDbContext context) : base(context)
        {
        }
    }
}

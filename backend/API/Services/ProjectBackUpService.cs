using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public class ProjectBackUpService : BaseService<ProjectBackUp>
    {
        public ProjectBackUpService(AppDbContext context) : base(context)
        {
        }
    }
}

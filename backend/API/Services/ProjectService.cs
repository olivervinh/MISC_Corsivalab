using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public class ProjectService : BaseService<Project>
    {
        public ProjectService(AppDbContext context) : base(context)
        {
        }
    }
}

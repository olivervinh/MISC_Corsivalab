using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IProjectService : IBaseService<Project>
    {

    }
    public class ProjectService : BaseService<Project>,IProjectService
    {
        public ProjectService(AppDbContext context) : base(context)
        {
        }
    }
}

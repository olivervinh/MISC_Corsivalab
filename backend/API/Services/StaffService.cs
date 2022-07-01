using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public class StaffService : BaseService<Staff>
    {
        public StaffService(AppDbContext context) : base(context)
        {
        }
    }
}

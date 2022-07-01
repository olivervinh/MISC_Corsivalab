using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IStaffService : IBaseService<Staff> { }
    public class StaffService : BaseService<Staff>,IStaffService
    {
        public StaffService(AppDbContext context) : base(context)
        {
        }
    }
}

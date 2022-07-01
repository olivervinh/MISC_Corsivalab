using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public interface IStaffCredentialRequestService : IBaseService<StaffCredentialRequest> { }
    public class StaffCredentialRequestService : BaseService<StaffCredentialRequest>,IStaffCredentialRequestService
    {
        public StaffCredentialRequestService(AppDbContext context) : base(context)
        {
        }
    }
}

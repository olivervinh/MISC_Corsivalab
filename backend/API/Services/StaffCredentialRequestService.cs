using API.Data;
using API.Models;
using API.Services.Base;

namespace API.Services
{
    public class StaffCredentialRequestService : BaseService<StaffCredentialRequest>
    {
        public StaffCredentialRequestService(AppDbContext context) : base(context)
        {
        }
    }
}

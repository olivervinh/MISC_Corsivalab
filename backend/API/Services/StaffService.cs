using API.Data;
using API.Models;
using API.Services.Base;
using Newtonsoft.Json;
using RestSharp;

namespace API.Services
{
    public interface IStaffService : IBaseService<Staff> 
    {
        public Task<StaffObject> GetStaffByID(string id, string token);
        public Task<StaffObject> GetAllStaff(string Token);
    }
    public class StaffService : BaseService<Staff>,IStaffService
    {
        public StaffService(AppDbContext context) : base(context)
        {
        }

        public async Task<StaffObject> GetAllStaff(string Token)
        {
            return new StaffObject();
        }

        public async Task<StaffObject> GetStaffByID(string id, string token)
        {
            return new StaffObject();
        }
    }
}

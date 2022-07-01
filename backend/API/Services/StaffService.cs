using API.Data;
using API.Dtos;
using API.Models;
using API.Models.Base;
using API.Services.Base;

namespace API.Services
{
    public interface IStaffService : IBaseService<Staff> 
    {
        public Task<StaffObject> GetStaffByID(string id, string token);
        public Task<StaffObject> GetAllStaff(string Token);
        public Task<AuthResponse> GetAuth(string access_token);
        public Task<TokenResponse> GetToken(string email, string password);
        public Task<ResponseClass> LoginAsync(LoginDto dto);
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
        public Task<AuthResponse> GetAuth(string access_token)
        {
            throw new NotImplementedException();
        }
        public async Task<StaffObject> GetStaffByID(string id, string token)
        {
            return new StaffObject();
        }
        public Task<TokenResponse> GetToken(string email, string password)
        {
            throw new NotImplementedException();
        }
        public async Task<ResponseClass> LoginAsync(LoginDto dto)
        {
            TokenResponse tResponse = await GetToken(dto.Username.Trim(), dto.Password.Trim());
            AuthResponse aResponse = await GetAuth(tResponse.Access_token);
            switch (aResponse.ResponseCode)
            {
                case "200":
                    var token = await GetStaffByID(aResponse.ResponseObject, tResponse.Access_token);
                    return new ResponseClass()
                    {
                        responseCode = 200,
                        responseMessage = "Successfully",
                        responseName = "OK",
                        responseObject = token,
                    };
                case "301":
                    return new ResponseClass()
                    {
                        responseCode = 301,
                        responseMessage = "You access have expired",
                        responseName = "OK",
                        responseObject = null,
                    };
                case "302":
                    return new ResponseClass()
                    {
                        responseCode = 302,
                        responseMessage = "You do not have permission to enter this portal",
                        responseName = "OK",
                        responseObject = null,
                    };
                default:
                    return new ResponseClass();
            }
        }
    }
}

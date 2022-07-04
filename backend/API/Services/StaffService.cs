using API.Data;
using API.Dtos;
using API.Helpers;
using API.Models;
using API.Models.Base;
using API.Services.Base;
using RestSharp;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;

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
        private readonly IHttpClientFactory _httpClientFactory;
        public StaffService(AppDbContext context, IHttpClientFactory httpClientFactory) : base(context)
        {
            _httpClientFactory = httpClientFactory;
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
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get,
            "https://toolkit.corsivalab.com/token");
            httpRequestMessage.Headers.Add("Authorization", "Bearer " + token + "");
            httpRequestMessage.Headers.Add("Content-Type", "application/json");
            httpRequestMessage.Headers.Add("Cookie", "ARRAffinity=d96391891af12dbd0803dfc56bab6a4a4e7a9d33e954ae05fd44bc7807ff50f8; ARRAffinitySameSite=d96391891af12dbd0803dfc56bab6a4a4e7a9d33e954ae05fd44bc7807ff50f8");
            var httpClient = _httpClientFactory.CreateClient();
            httpRequestMessage.Content = new StringContent(
                JsonConvert.SerializeObject(new { id = id }),
                Encoding.UTF8, "application/json");
            httpClient.Timeout = new TimeSpan(0);
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();
                var staffObject = await System.Text.Json.JsonSerializer.DeserializeAsync<StaffObject>(contentStream);
                staffObject.AccessToken = token;
                return staffObject;
            }
            return null;
        }
        public Task<TokenResponse> GetToken(string email, string password)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get,
           "https://toolkit.corsivalab.com/token");
            httpRequestMessage.Headers.Add("Authorization", "Bearer " + token + "");
            httpRequestMessage.Headers.Add("Content-Type", "application/json");
            httpRequestMessage.Headers.Add("Cookie", "ARRAffinity=d96391891af12dbd0803dfc56bab6a4a4e7a9d33e954ae05fd44bc7807ff50f8; ARRAffinitySameSite=d96391891af12dbd0803dfc56bab6a4a4e7a9d33e954ae05fd44bc7807ff50f8");
            var httpClient = _httpClientFactory.CreateClient();
            httpRequestMessage.Content = new StringContent(
                JsonConvert.SerializeObject(new { id = id }),
                Encoding.UTF8, "application/json");
            httpClient.Timeout = new TimeSpan(0);
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();
                var staffObject = await System.Text.Json.JsonSerializer.DeserializeAsync<StaffObject>(contentStream);
                staffObject.AccessToken = token;
                return staffObject;
            }
            return null;
        }
        public async Task<ResponseClass> LoginAsync(LoginDto dto)
        {
            if(ValidateHelper.ValidateWrongStringLength10(dto.Username)
                &&
                ValidateHelper.ValidateWrongStringLength10(dto.Password))
            {
                return new ResponseClass()
                {
                    responseCode = 401,
                    responseMessage = "Fail to validate",
                    responseName = "Fail validate",
                    responseObject = null,
                };
            }
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

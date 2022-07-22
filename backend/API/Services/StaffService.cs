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
using System.Net;

namespace API.Services
{
    public interface IStaffService : IBaseService<Staff> 
    {
        public Task<ResponseClass> LoginAsync(LoginDto dto);
        //be call
        public Task<TokenResponse> GetToken(string email, string password);
        public Task<AuthResponse> GetAuth(string access_token);
        public Task<StaffObject> GetStaffByID(string id, string token);
        public Task<List<StaffObject>> GetAllStaff(string Token);
        //be call
    }
    public class StaffService : BaseService<Staff>,IStaffService
    {
        private readonly HttpClient _httpClient;
        public StaffService(AppDbContext context, HttpClient httpClient) : base(context)
        {
            _httpClient = httpClient;
        }
        public async Task<ResponseClass> LoginAsync(LoginDto dto)
        {
            if(ValidateHelper.ValidateWrongStringLength50(dto.username)
                &&
                ValidateHelper.ValidateWrongStringLength50(dto.password))
            {
                return new ResponseClass()
                {
                    responseCode = 401,
                    responseMessage = "Fail to validate",
                    responseName = "Fail validate",
                    responseObject = null,
                };
            }
            TokenResponse tResponse = await GetToken(dto.username.Trim(), dto.password.Trim());
            AuthResponse aResponse = await GetAuth(tResponse.access_token);
            switch (aResponse.responseCode)
            {
                case "200":
                    var staffObject = await GetStaffByID(aResponse.responseObject, tResponse.access_token);
                    StaticHelper.StaffTeam = staffObject.Team;
                    return new ResponseClass()
                    {
                        responseCode = 200,
                        responseMessage = "Successfully",
                        responseName = "OK",
                        responseObject = staffObject,
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
        //be call
        public async Task<TokenResponse> GetToken(string email, string password)
        {
            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://toolkit.corsivalab.com/token"),
                Headers = {
                    { HttpRequestHeader.Accept.ToString(), ConstantHelper.HttpRequestHeader_Text },
                    { HttpRequestHeader.Cookie.ToString(), ConstantHelper.HttpRequestHeader_Cookie },
                },
                Content = new StringContent(@"email=" + email + "&password=" + password + "&grant_type=password")
            };
            using (var response = await _httpClient.SendAsync(httpRequestMessage))
            {
                response.EnsureSuccessStatusCode();
                var stream = await response.Content.ReadAsStreamAsync();

                using (var streamReader = new StreamReader(stream))
                {
                    using (var jsonTextReader = new JsonTextReader(streamReader))
                    {
                        var jsonSerializer = new Newtonsoft.Json.JsonSerializer();
                        var data = jsonSerializer.Deserialize<TokenResponse>(jsonTextReader);
                        return data;
                    }
                }
            }
            return null;
        }
        public async Task<AuthResponse> GetAuth(string access_token)
        {
            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://toolkit.corsivalab.com/api/staff/MaintenancePortal"),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), "Bearer "+access_token+"" },
                    { HttpRequestHeader.Cookie.ToString(),ConstantHelper.HttpRequestHeader_Cookie  },
                },
            };
            using (var response = await _httpClient.SendAsync(httpRequestMessage))
            {
                response.EnsureSuccessStatusCode();
                var stream = await response.Content.ReadAsStreamAsync();

                using (var streamReader = new StreamReader(stream))
                {
                    using (var jsonTextReader = new JsonTextReader(streamReader))
                    {
                        var jsonSerializer = new Newtonsoft.Json.JsonSerializer();
                        var data = jsonSerializer.Deserialize<AuthResponse>(jsonTextReader);
                        return data;
                    }
                }
            }
            return null;
        }
        public async Task<StaffObject> GetStaffByID(string id, string token)
        {
            var httpRequestMessage = new HttpRequestMessage
            {

                Method = HttpMethod.Post,
                RequestUri = new Uri("https://toolkit.corsivalab.com/api/staff/GetStaffByID"),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), "Bearer " + token + "" },
                    { HttpRequestHeader.Accept.ToString(), ConstantHelper.HttpRequestHeader_JSon },
                    { HttpRequestHeader.Cookie.ToString(), ConstantHelper.HttpRequestHeader_Cookie },
                },
                Content = new StringContent(JsonConvert.SerializeObject(new{id = int.Parse(id)}), Encoding.UTF8, ConstantHelper.HttpRequestHeader_JSon),
            };
            using (var response = await _httpClient.SendAsync(httpRequestMessage))
            {
                response.EnsureSuccessStatusCode();
                var stream = await response.Content.ReadAsStreamAsync();

                using (var streamReader = new StreamReader(stream))
                {
                    using (var jsonTextReader = new JsonTextReader(streamReader))
                    {
                        var jsonSerializer = new Newtonsoft.Json.JsonSerializer();
                        var data = jsonSerializer.Deserialize<Auth2Response>(jsonTextReader);
                        StaffObject staff = data.responseObject;
                        staff.AccessToken = token;
                        return staff;
                    }
                }
            }
            return null;
        }
        public async Task<List<StaffObject>> GetAllStaff(string token)
        {
            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://toolkit.corsivalab.com/api/staff/GetAllStaff"),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), "Bearer "+token+"" },
                    { HttpRequestHeader.Accept.ToString(),ConstantHelper.HttpRequestHeader_JSon},
                    { HttpRequestHeader.Cookie.ToString(), ConstantHelper.HttpRequestHeader_Cookie },
                },
                Content = new StringContent(""),
            };
            using (var response = await _httpClient.SendAsync(httpRequestMessage))
            {
                response.EnsureSuccessStatusCode();
                var stream = await response.Content.ReadAsStreamAsync();

                using (var streamReader = new StreamReader(stream))
                {
                    using (var jsonTextReader = new JsonTextReader(streamReader))
                    {
                        var jsonSerializer = new Newtonsoft.Json.JsonSerializer();
                        var data = jsonSerializer.Deserialize<Auth3Response>(jsonTextReader);
                        return data.responseObjects;
                    }
                }
            }
            return null;
        }
        //be call
    }
}

﻿using API.Data;
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
        public Task<StaffObject> GetStaffByID(string id, string token);
        public Task<Auth3Response> GetAllStaff(string Token);
        public Task<AuthResponse> GetAuth(string access_token);
        public Task<TokenResponse> GetToken(string email, string password);
        public Task<ResponseClass> LoginAsync(LoginDto dto);
    }
    public class StaffService : BaseService<Staff>,IStaffService
    {
        private readonly HttpClient _httpClient;
        public StaffService(AppDbContext context, HttpClient httpClient) : base(context)
        {
            _httpClient = httpClient;
        }
        public async Task<Auth3Response> GetAllStaff(string Token)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get,
          "https://toolkit.corsivalab.com/token");
            httpRequestMessage.Headers.Add("Authorization", "Bearer " + Token + "");
            httpRequestMessage.Headers.Add("Content-Type", "application/json");
            httpRequestMessage.Headers.Add("Cookie","ARRAffinity=d96391891af12dbd0803dfc56bab6a4a4e7a9d33e954ae05fd44bc7807ff50f8; ARRAffinitySameSite=d96391891af12dbd0803dfc56bab6a4a4e7a9d33e954ae05fd44bc7807ff50f8");
            //httpClient.Timeout = new TimeSpan(0);
            var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();
                var auth3Response = await System.Text.Json.JsonSerializer.DeserializeAsync<Auth3Response>(contentStream);
                return auth3Response;
            }
            return null;
        }
        public async Task<AuthResponse> GetAuth(string access_token)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get,
          "https://toolkit.corsivalab.com/token");
            httpRequestMessage.Headers.Add("Accept", "text/plain");
            httpRequestMessage.Headers.Add("Authorization", "Bearer " + access_token + "");
            httpRequestMessage.Headers.Add("Cookie", "ARRAffinity=d96391891af12dbd0803dfc56bab6a4a4e7a9d33e954ae05fd44bc7807ff50f8; ARRAffinitySameSite=d96391891af12dbd0803dfc56bab6a4a4e7a9d33e954ae05fd44bc7807ff50f8");
            var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();
                var authResponse = await System.Text.Json.JsonSerializer.DeserializeAsync<AuthResponse>(contentStream);
                return authResponse;
            }
            return null;
        }
        public async Task<StaffObject> GetStaffByID(string id, string token)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get,
            "https://.0/token");
            httpRequestMessage.Headers.Add("Authorization", "Bearer " + token + "");
            httpRequestMessage.Headers.Add("Content-Type", "application/json");
            httpRequestMessage.Headers.Add("Cookie", "ARRAffinity=d96391891af12dbd0803dfc56bab6a4a4e7a9d33e954ae05fd44bc7807ff50f8; ARRAffinitySameSite=d96391891af12dbd0803dfc56bab6a4a4e7a9d33e954ae05fd44bc7807ff50f8");
            httpRequestMessage.Content = new StringContent(
                JsonConvert.SerializeObject(new { id = id }),
                Encoding.UTF8, "application/json");
            //httpClient.Timeout = new TimeSpan(0);
            var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage);
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
        public async Task<TokenResponse> GetToken(string email, string password)
        {
            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://toolkit.corsivalab.com/token"),
                Headers = {
                    { HttpRequestHeader.Accept.ToString(), "text/plain" },
                    { HttpRequestHeader.Cookie.ToString(), "ARRAffinity=d96391891af12dbd0803dfc56bab6a4a4e7a9d33e954ae05fd44bc7807ff50f8; ARRAffinitySameSite=d96391891af12dbd0803dfc56bab6a4a4e7a9d33e954ae05fd44bc7807ff50f8" },
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
                    var token = await GetStaffByID(aResponse.responseObject, tResponse.access_token);
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

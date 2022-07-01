using API.Dtos;
using API.Models;
using API.Models.Base;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        public StaffsController(IStaffService staffService)
        {
            _staffService = staffService;
        }
        [HttpPost]
        public async Task<ResponseClass> LoginAsync([FromBody]LoginDto dto)
        {
            return await _staffService.LoginAsync(dto);
        }
    }
}

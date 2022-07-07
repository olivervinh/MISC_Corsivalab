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
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(LoginDto dto)
        {
            try
            {
                var res = await _staffService.LoginAsync(dto);
                return Ok(res);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}

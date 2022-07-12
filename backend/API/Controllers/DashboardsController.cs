using API.Data;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly AppDbContext _appDbContext;
        public DashboardsController(IProjectService projectService, AppDbContext appDbContext)
        {
            _projectService = projectService;
            _appDbContext = appDbContext;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(JsonConvert.SerializeObject(await _projectService.GetAll()));
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet("ListProjectCountMaintenance")]
        public async Task<IActionResult> ListProjectCountMaintenance()
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProjectCountMaintenance()));
        }
        [HttpGet("ListProject120Domain")]
        public async Task<IActionResult> ListProject120Domain()
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProject120Domain()));
        }
        [HttpGet("ListProject120Hosting")]
        public async Task<IActionResult> ListProject120Hosting()
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProject120Hosting()));
        }
        [HttpGet("ListProject120Email")]
        public async Task<IActionResult> ListProject120Email()
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProject120Email()));
        }
        [HttpGet("ListProject120Maintenance")]
        public async Task<IActionResult> ListProject120Maintenance()
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProject120Maintenance()));
        }
    }
}
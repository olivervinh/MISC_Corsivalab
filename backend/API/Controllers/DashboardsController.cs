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
        public DashboardsController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(int pageNumber,int pageSize)
        {
            try
            {
                return Ok(JsonConvert.SerializeObject(await _projectService.PaginatedListProject(pageNumber,pageSize)));
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
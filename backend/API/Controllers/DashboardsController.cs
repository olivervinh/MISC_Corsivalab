using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetAll()
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.GetAll()));
        }
        public async Task<IActionResult> ListProjectCountMaintenance()
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProjectCountMaintenance()));
        }
        public async Task<IActionResult> ListProject120Domain()
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProject120Domain()));
        }
        public async Task<IActionResult> ListProject120Hosting()
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProject120Hosting()));
        }
        public async Task<IActionResult> ListProject120Email()
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProject120Email()));
        }
        public async Task<IActionResult> ListProject120Maintenance()
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProject120Maintenance()));
        }
    }
}
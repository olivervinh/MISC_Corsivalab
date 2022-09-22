using API.Dtos;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers.Dashboards
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceProjectAssignedsController : ControllerBase
    {
        public IProjectService _projectService;
        public MaintenanceProjectAssignedsController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        [HttpGet("GetMaintenanceProjectAssigned")]
        public async Task<IActionResult> GetMaintenanceProjectAssigned(string maintainBy)
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.GetMaintenanceProjectAssigned(maintainBy)));
        }
    }
}

using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers.UpdateProjects
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectHourlyMaintenancePackagesController : ControllerBase
    {
        public IProjectService _projectService;
        public ProjectHourlyMaintenancePackagesController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProject_GetProjectMonthlyMaintenanceList(int FkProjectId)
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.GetProjectHourlyMaintenanceList(FkProjectId)));
        }
    }
}

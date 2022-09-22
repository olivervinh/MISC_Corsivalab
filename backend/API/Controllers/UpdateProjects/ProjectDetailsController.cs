using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers.UpdateProjects
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectDetailsController : ControllerBase
    {
        public IProjectService _projectService;
        public ProjectDetailsController(IProjectService projectService)
        {_projectService
             = projectService;
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProject_GetProjectDetail(string id) 
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.UpdateProject_GetProjectDetail(int.Parse(id))));
        }
        [HttpGet("GetProjectBackupLink")]
        public async Task<IActionResult> GetProjectBackupLink(string id)
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.GetProjectBackupLink(int.Parse(id))));
        }
    }
}

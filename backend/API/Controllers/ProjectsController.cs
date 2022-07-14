using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize)
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.PaginatedListProject(pageNumber, pageSize)));
        }
    }
}

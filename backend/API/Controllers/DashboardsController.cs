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
        //Start :Active Maintenance Project Assigned
        [HttpGet("ListProjectCountMaintenance")]
        public async Task<IActionResult> ListProjectCountMaintenance()
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProjectCountMaintenance()));
        }
        //End :Active Maintenance Project Assigned

        //Start :Count projects not tagged to any maintenance person
        [HttpGet("ListProjectsNoPerson")]
        public async Task<IActionResult> ListProjectsNoPerson()
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProjectsNoPerson()));
        }
        //Start: Count projects not tagged to any maintenance person

        //Start: Expiry within 120 Days
        [HttpGet("ListProject120Domain")]
        public async Task<IActionResult> ListProject120Domain(/*int pageNumber, int pageSize*/)
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProject120Domain() /*PaginatedListProject120Domain(pageNumber,pageSize)*/));
        }
        [HttpGet("ListProject120Hosting")]
        public async Task<IActionResult> ListProject120Hosting(/*int pageNumber, int pageSize*/)
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProject120Hosting()/*PaginatedListProject120Hosting(pageNumber,pageSize)*/));
        }
        [HttpGet("ListProject120Email")]
        public async Task<IActionResult> ListProject120Email(/*int pageNumber, int pageSize*/)
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProject120Email()/*PaginatedListProject120Email(pageNumber,pageSize)*/));
        }
        [HttpGet("ListProject120Maintenance")]
        public async Task<IActionResult> ListProject120Maintenance(/*int pageNumber, int pageSize*/)
        {
            return Ok(JsonConvert.SerializeObject(await _projectService.ListProject120Maintenance()
                /*PaginatedListProject120Maintenance(pageNumber,pageSize)*/));
        }
        //End: Expiry within 120 Days
    }
}
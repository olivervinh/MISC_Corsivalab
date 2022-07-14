using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomainsController : ControllerBase
    {
        private readonly IProjectDomainService _projectDomainService;
        public DomainsController(IProjectDomainService projectDomainService)
        {
            _projectDomainService = projectDomainService;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize)
        {
            return Ok(JsonConvert.SerializeObject(await _projectDomainService.PaginatedListProjectDomain(pageNumber, pageSize)));
        }
    }
}

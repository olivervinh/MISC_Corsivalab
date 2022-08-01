using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtaglancesController : ControllerBase
    {
        private readonly IAtaglancesService _ataglancesService;
        public AtaglancesController(IAtaglancesService ataglancesService)
        {
            _ataglancesService = ataglancesService;
        }
        [HttpGet("CountProjectList")]
        public async Task<IActionResult> CountProjectList()
        {
            return Ok(JsonConvert.SerializeObject(await _ataglancesService.CountProjectList()));
        }
        [HttpGet("TotalAndDomainRevenueBreakdownList")]
        public async Task<IActionResult> TotalAndDomainRevenueBreakdownList()
        {
            return Ok(JsonConvert.SerializeObject(await _ataglancesService.TotalAndDomainRevenueBreakdownList()));
        }
        [HttpGet("TotalAndHostingRevenueBreakdownList")]
        public async Task<IActionResult> TotalAndHostingRevenueBreakdownList()
        {
            return Ok(JsonConvert.SerializeObject(await _ataglancesService.TotalAndHostingRevenueBreakdownList()));
        }
        [HttpGet("TotalAndEmailRevenueBreakdownList")]
        public async Task<IActionResult> TotalAndEmailRevenueBreakdownList()
        {
            return Ok(JsonConvert.SerializeObject(await _ataglancesService.TotalAndEmailRevenueBreakdownList()));
        }
    }
}

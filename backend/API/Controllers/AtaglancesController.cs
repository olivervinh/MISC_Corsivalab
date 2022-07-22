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
        [HttpGet("TotalForecast2020")]
        public async Task<IActionResult> TotalForecast2020()
        {
            return Ok(await _ataglancesService.TotalForecast2020());
        }
        [HttpGet("TotalForecast2021")]
        public async Task<IActionResult> TotalForecast2021()
        {
            return Ok(await _ataglancesService.TotalForecast2021());
        }
        [HttpGet("TotalForecast2022")]
        public async Task<IActionResult> TotalForecast2022()
        {
            return Ok(await _ataglancesService.TotalForecast2022());
        }
        [HttpGet("TotalForecast2023")]
        public async Task<IActionResult> TotalForecast2023()
        {
            return Ok(await _ataglancesService.TotalForecast2023());
        }
        [HttpGet("TotalConfirm2020")]
        public async Task<IActionResult> TotalConfirm2020()
        {
            return Ok(await _ataglancesService.TotalConfirm2020());
        }
        [HttpGet("TotalConfirm2021")]
        public async Task<IActionResult> TotalConfirm2021()
        {
            return Ok(await _ataglancesService.TotalConfirm2021());
        }
        [HttpGet("TotalConfirm2022")]
        public async Task<IActionResult> TotalConfirm2022()
        {
            return Ok(await _ataglancesService.TotalConfirm2022());
        }
        [HttpGet("TotalConfirm2023")]
        public async Task<IActionResult> TotalConfirm2023()
        {
            return Ok(await _ataglancesService.TotalConfirm2023());
        }
    }
}

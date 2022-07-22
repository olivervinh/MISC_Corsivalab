using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenancesController : ControllerBase
    {
        private readonly IMaintenanceMontlyService _maintenanceMontlyService;
        private readonly IMaintenanceHourlyService _maintenanceHourlyService;
        public MaintenancesController(IMaintenanceMontlyService maintenanceMontlyService, IMaintenanceHourlyService maintenanceHourlyService)
        {
            _maintenanceMontlyService = maintenanceMontlyService;
            _maintenanceHourlyService = maintenanceHourlyService;   
        }
        [HttpGet("GetMaintenanceMontlies")]
        public async Task<IActionResult> GetMaintenanceMontlies()
        {
            return Ok(JsonConvert.SerializeObject(await _maintenanceMontlyService.GetMaintenanceMontlies()));
        }
        [HttpGet("GetMaintenanceHourly")]
        public async Task<IActionResult> GetMaintenanceHourly() 
        {
            var res = await _maintenanceHourlyService.GetMaintenanceHourlies();
            return Ok(JsonConvert.SerializeObject(res));
        }
    }
}

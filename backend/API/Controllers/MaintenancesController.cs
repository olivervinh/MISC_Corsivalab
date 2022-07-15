using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return Ok(await _maintenanceMontlyService.GetMaintenanceMontlies());
        }
        [HttpGet("GetMaintenanceHourly")]
        public async Task<IActionResult> GetMaintenanceHourly() 
        {
            return Ok(await _maintenanceHourlyService.GetMaintenanceHourlies());
        }
    }
}

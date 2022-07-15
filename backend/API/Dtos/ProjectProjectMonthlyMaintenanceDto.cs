using API.Models;

namespace API.Dtos
{
    public class ProjectProjectMonthlyMaintenanceDto
    {
        public Project project { get; set; } 
        public ProjectMonthlyMaintenance projectMonthlyMaintenance { get; set; }
    }
}

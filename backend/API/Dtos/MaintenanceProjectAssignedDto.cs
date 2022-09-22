using API.Models;

namespace API.Dtos
{
    public class MaintenanceProjectAssignedDto
    {
        public string MaintainBy { get; set; }
        public ICollection<MaintenanceProject> MaintenanceProjects { get; set; } 
    }
    public class MaintenanceProject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CustomerName { get; set; }
    }
}

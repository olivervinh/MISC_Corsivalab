namespace API.Dtos
{
    public class ProjectMonthlyMaintenanceDto
    {
        public string Customer { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int Amount { get; set; }
        public string Per { get; set; }
    }
}

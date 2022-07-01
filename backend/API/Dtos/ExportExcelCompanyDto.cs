namespace API.Dtos
{
    public class ExportExcelCompanyDto
    {
        public string CompanyName { get; set; }
        public string Domain { get; set; }
        public string MaintExpiry { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string HealthScore { get; set; }
        public string AccountTier { get; set; }
        public string RenewalDate { get; set; }
        public string Industry { get; set; }
    }
}

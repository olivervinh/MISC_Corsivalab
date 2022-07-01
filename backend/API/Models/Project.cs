using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Project : EntityBase
    {
        public string Title { get; set; }
        public string MaintainBy { get; set; }
        public string AMEmail { get; set; }
        public int Phase { get; set; }
        public int ProjectNature { get; set; }
        public string MaintCost { get; set; }
        public DateTime MaintStart { get; set; }
        public DateTime MaintExpire { get; set; }
        public int Forecast { get; set; }
        public string ForecastAmount { get; set; }
        public string ForecastStart { get; set; }
        public string Remark { get; set; }
        public string ShortLink { get; set; }
        public string Code { get; set; }
        [ForeignKey(nameof(FkCustomerId))]
        public int FkCustomerId { get; set; }
        [ForeignKey(nameof(FkEmailSystemId))]
        public int FkEmailSystemId { get; set; }
        [ForeignKey(nameof(FkDomainProviderId))]
        public int FkDomainProviderId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual EmailSystem EmailSystem { get; set; }
        public virtual DomainProvider DomainProvider { get; set; }
        public virtual ICollection<MaintenanceHourly> MaintenanceHourlies { get; set; }
        public virtual ICollection<MaintenanceLog> MaintenanceLogs { get; set; }
        public virtual ICollection<MaintenanceMontly> MaintenanceMontlies { get; set; }
        public virtual ICollection<MaintenanceReport> MaintenanceReports { get; set; }
        public virtual ICollection<ProjectBackUp> ProjectBackUps { get; set; }
        public virtual ICollection<ProjectCredential> ProjectCredentials { get; set; }
        public virtual ICollection<ProjectCredentialLog> ProjectCredentialLogs { get; set; }
        public virtual ICollection<ProjectDomain> ProjectDomains { get; set; }
        public virtual ICollection<ProjectEmailSystem> ProjectEmailSystems { get; set; }
        public virtual ICollection<ProjectHosting> ProjectHostings { get; set; }
        public virtual ICollection<ProjectHourlyMaintenance> ProjectHourlyMaintenances { get; set; }
        public virtual ICollection<ProjectMonthlyMaintenance> ProjectMonthlyMaintenances { get; set; }
        public virtual ICollection<StaffCredentialRequest> StaffCredentialRequests { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}

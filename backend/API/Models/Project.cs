using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_Project")]
    public class Project : EntityBase
    {
        [Column("Title", TypeName = "varchar(MAX)")]
        public string? Title { get; set; }
        [Column("Domain", TypeName = "varchar(MAX)")]
        public string? Domain { get; set; }
        [Column("MaintExpire", TypeName = "datetime2(7)")]
        public DateTime? MaintExpire { get; set; }
        [Column("ForecastStart", TypeName = "varchar(MAX)")]
        public string? ForecastStart { get; set; }
        [Column("Forecast", TypeName = "int")]
        public int? Forecast { get; set; }
        [Column("MaintStart", TypeName = "datetime2(7)")]
        public DateTime? MaintStart { get; set; }
        [Column("ForecastAmount", TypeName = "varchar(MAX)")]
        public string? ForecastAmount { get; set; }
        [Column("EmailSystemExpire", TypeName = "datetime2(7)")]
        public DateTime? EmailSystemExpire { get; set; }
        [Column("EmailSystemOwner", TypeName = "varchar(MAX)")]
        public string? EmailSystemOwner { get; set; }
        [Column("FK_CustomerId", TypeName = "int")]
        public int? FkCustomerId { get; set; }
        [Column("MaintainBy", TypeName = "varchar(MAX)")]
        public string? MaintainBy { get; set; }
        [Column("FK_EmailSystemId", TypeName = "int")]
        public int? FkEmailSystemId { get; set; }
        [Column("AMEmail", TypeName = "varchar(MAX)")]
        public string? AMEmail { get; set; }
        [Column("Phase", TypeName = "int")]
        public int? Phase { get; set; }
        [Column("ProjectNature", TypeName = "int")]
        public int? ProjectNature { get; set; }
        [Column("DomainCost", TypeName = "varchar(MAX)")]
        public string? DomainCost { get; set; }
        [Column("HostingCost", TypeName = "varchar(MAX)")]
        public string? HostingCost { get; set; }
        [Column("EmailCost", TypeName = "varchar(MAX)")]
        public string? EmailCost { get; set; }
        [Column("MaintCost", TypeName = "varchar(MAX)")]
        public string? MaintCost { get; set; }
        [Column("Remarks", TypeName = "varchar(MAX)")]
        public string? Remark { get; set; }
        [Column("Code", TypeName = "varchar(255)")]
        public string? Code { get; set; }
        [Column("ShortLink", TypeName = "varchar(MAX)")]
        public string? ShortLink { get; set; }
        //[ForeignKey(nameof(FkCustomerId))]
        //[ForeignKey(nameof(FkEmailSystemId))]
        //[ForeignKey(nameof(FkDomainProviderId))]
        [Column("FKDomainProvider", TypeName = "int")]
        public int? FkDomainProviderId { get; set; }
        [Column("CreatedAtDatetime", TypeName = "datetime2(7)")]
        public DateTime? CreatedAtDatetime { get; set; }
        [Column("MaintenanceShortLink", TypeName= "varchar(MAX)")]
        public string? MaintenanceShortLink { get; set; }
        [NotMapped]
        public Customer Customer { get; set; }
        [NotMapped]
        public ProjectBackUp BackUp { get; set; }
        [NotMapped]
        public ProjectCredential Credential { get; set; }
        [NotMapped]
        public MaintenanceMontly Maintenance { get; set; }
        [NotMapped]
        public MaintenanceReport report { get; set; }
        [NotMapped]
        public string Token { get; set; } // For API purposes
        [NotMapped]
        public string newId { get; set; } // For API purposes
        [NotMapped]
        public string Expiry { get; set; } // Get Expiry Date for Dashboard
        [NotMapped]
        public DateTime ExpiryDashboardView { get; set; } // Show Expiry date domain
        //public virtual Customer Customer { get; set; }
        //public virtual EmailSystem EmailSystem { get; set; }
        //public virtual DomainProvider DomainProvider { get; set; }
        //public virtual ICollection<MaintenanceHourly> MaintenanceHourlies { get; set; }
        //public virtual ICollection<MaintenanceLog> MaintenanceLogs { get; set; }
        //public virtual ICollection<MaintenanceMontly> MaintenanceMontlies { get; set; }
        //public virtual ICollection<MaintenanceReport> MaintenanceReports { get; set; }
        //public virtual ICollection<ProjectBackUp> ProjectBackUps { get; set; }
        //public virtual ICollection<ProjectCredential> ProjectCredentials { get; set; }
        //public virtual ICollection<ProjectCredentialLog> ProjectCredentialLogs { get; set; }
        //public virtual ICollection<ProjectDomain> ProjectDomains { get; set; }
        //public virtual ICollection<ProjectEmailSystem> ProjectEmailSystems { get; set; }
        //public virtual ICollection<ProjectHosting> ProjectHostings { get; set; }
        //public virtual ICollection<ProjectHourlyMaintenance> ProjectHourlyMaintenances { get; set; }
        //public virtual ICollection<ProjectMonthlyMaintenance> ProjectMonthlyMaintenances { get; set; }
        //public virtual ICollection<StaffCredentialRequest> StaffCredentialRequests { get; set; }
        //public virtual ICollection<Ticket> Tickets { get; set; }
        [NotMapped]
        public string CustomerName { get; set; }
    }
}

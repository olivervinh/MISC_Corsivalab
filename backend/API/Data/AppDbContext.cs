using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<ApiLog> ApiLogs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DomainProvider> DomainProviders { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<MaintenanceHourly> MaintenanceHourlies { get; set; }
        public DbSet<MaintenanceLog> MaintenanceLogs{ get; set; }
        public DbSet<MaintenanceMontly> MaintenanceMontlies { get; set; }
        public DbSet<MaintenanceReport> MaintenanceReports { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectBackUp> ProjectBackUps { get; set; }
        public DbSet<ProjectCredential> ProjectCredentials { get; set; }
        public DbSet<ProjectCredentialLog> ProjectCredentialLogs { get; set; }
        public DbSet<ProjectDomain> ProjectDomains { get; set; }
        public DbSet<ProjectEmailSystem> ProjectEmailSystems { get; set; }
        public DbSet<ProjectHosting> ProjectHostings { get; set; }
        public DbSet<ProjectHourlyMaintenance> ProjectHourlyMaintenances { get; set; }
        public DbSet<ProjectHourlyMaintenanceRecord> ProjectHourlyMaintenanceRecords { get; set; }
        public DbSet<ProjectMonthlyMaintenance> ProjectMonthlyMaintenances { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Quotation> Quotations { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffCredentialRequest> StaffCredentialRequests { get; set; }
        public DbSet<TechnologyUsed> TechnolodyUseds { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketImage> TicketImages { get; set; }
        public DbSet<TicketReply> TicketReplies { get; set; }
    }
}

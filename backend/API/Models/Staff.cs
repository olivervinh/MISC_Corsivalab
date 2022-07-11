using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_Staff")]
    public class Staff : EntityBase
    {
        [Column(name: "Username", TypeName = "varchar(MAX)")]
        public string Username { get; set; }
        [Column(name: "Password", TypeName = "nvarchar(MAX)")]
        public string Password { get; set; }
        [Column(name: "Role", TypeName = "int")]
        public int Role { get; set; }
        [Column(name: "CreatedAt", TypeName = "datetime2(7)(7)")]
        public DateTime CreatedAt { get; set; }
        [Column(name: "LastLogin", TypeName = "datetime2(7)(7)")]
        public DateTime LastLogin { get; set; }
        [NotMapped]
        public string Token { get; set; }
        //public virtual ICollection<MaintenanceLog> MaintenanceLogs { get; set; }
        //public virtual ICollection<MaintenanceReport> MaintenanceReports { get; set; }
        //public virtual ICollection<ProjectCredentialLog> ProjectCredentialLogs { get; set; }
        //public virtual ICollection<StaffCredentialRequest> StaffCredentialRequests { get; set; }
        //public virtual ICollection<Ticket> Tickets { get; set; }
    }
    public class StaffObject : EntityBase
    {
        public string Email { get; set; }
        public string AccessToken { get; set; }
        public string Team { get; set; }
        public virtual List<Auth2Response> Auth2Responses { get; set; }
    }
    public class Auth2Response
    {
        public string responseCode { get; set; }
        public string responseName { get; set; }
        public virtual StaffObject responseObject { get; set; }
    }
    public class Auth3Response
    {
        public string responseCode { get; set; }
        public string responseName { get; set; }
        public virtual List<StaffObject> responseObjects { get; set; }
    }
    public class TokenResponse
    {
        public string error;
        public string access_token;
        public string token_type;
        public string expires_in;
    }

    public class AuthResponse
    {
        public string responseCode;
        public string responseName;
        public string responseObject;
    }
}

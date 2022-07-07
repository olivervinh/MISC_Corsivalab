using API.Models.Base;

namespace API.Models
{
    public class Staff : EntityBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastLogin { get; set; }
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
        public virtual ICollection<Auth2Response> Auth2Responses { get; set; }
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
        public virtual ICollection<StaffObject> responseObjects { get; set; }
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

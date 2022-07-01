using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Customer :EntityBase
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastLogin { get; set; }
        public string Token { get; set; }
        public int NewId { get; set; }
        [ForeignKey(nameof(FkIndustryId))]
        public int FkIndustryId { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual ICollection<MaintenanceMontly> MaintenanceMontlies { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}

using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_Customer")]
    public class Customer :EntityBase
    {
        //table database
        [Column(name: "Username", TypeName = "varchar(MAX)")]
        public string Username { get; set; }
        [Column(name: "Company", TypeName = "varchar(MAX)")]
        public string Company { get; set; }
        [Column(name: "Email", TypeName = "varchar(MAX)")]
        public string Email { get; set; }
        [Column(name: "Password", TypeName = "nvarchar(MAX)")]
        public string Password { get; set; }
        [Column(name: "CreatedAt", TypeName = "datetime2(7)")]
        public DateTime CreatedAt { get; set; }
        [Column(name: "LastLogin", TypeName = "datetime2(7)")]
        public DateTime LastLogin { get; set; }
        [Column("FK_IndustryId")]
        public int FkIndustryId { get; set; }
        //table database
        [NotMapped]
        public string Token { get; set; }
        [NotMapped]
        public int NewId { get; set; }
        //[ForeignKey(nameof(FkIndustryId))]
       
        //public virtual Industry Industry { get; set; }
        //public virtual ICollection<MaintenanceMontly> MaintenanceMontlies { get; set; }
        //public virtual ICollection<Project> Projects { get; set; }
        //public virtual ICollection<Ticket> Tickets { get; set; }
    }
}

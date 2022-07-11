using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_DomainProvider")]
    public class DomainProvider:EntityBase
    {
        [Column(name: "Name", TypeName = "varchar(MAX)")]
        public string Name { get; set; }
        //public virtual ICollection<Project> Projects { get; set; }
    }
}

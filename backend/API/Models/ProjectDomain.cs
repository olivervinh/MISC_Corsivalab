using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class ProjectDomain : EntityBase
    {
        public string Domain { get; set; }
        public DateTime Expiry { get; set; }
        public string Cost { get; set; }
        public int Provider { get; set; }
        public int Owner { get; set; }
        [ForeignKey(nameof(FkProjectId))]
        public int FkProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}

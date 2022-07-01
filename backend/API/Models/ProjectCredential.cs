using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class ProjectCredential : EntityBase
    {
        public string CredentialInfo { get; set; }
        public DateTime LastUpdate { get; set; }
        [ForeignKey(nameof(FkProjectId))]
        public int FkProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}

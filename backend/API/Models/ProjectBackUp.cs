using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class ProjectBackUp : EntityBase
    {
        public DateTime UpdatedAt { get; set; }
        public string Link { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        public int FkProjectId { get; set; }
        //public virtual Project Project { get; set; }
    }
}

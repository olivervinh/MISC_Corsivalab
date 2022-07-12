using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_ProjectBackUp")]
    public class ProjectBackUp : EntityBase
    {
        [Column("UpdatedAt", TypeName = "datetime2(7)")]
        public DateTime UpdatedAt { get; set; }
        [Column("Link", TypeName = "varchar(MAX)")]
        public string Link { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        [Column("FK_ProjectId", TypeName = "int")]
        public int FkProjectId { get; set; }
        //public virtual Project Project { get; set; }
    }
}

using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_ProjectMonthlyMaintenance")]
    public class ProjectMonthlyMaintenance : EntityBase
    {
        [Column(name: "StartDate", TypeName = "datetime2(7)")]
        public DateTime StartDate { get; set; }
        [Column(name: "EndDate", TypeName = "datetime2(7)")]
        public DateTime EndDate { get; set; }
        [Column(name: "Amount", TypeName = "int")]
        public int Amount { get; set; }
        [Column(name: "Per", TypeName = "varchar(50)")]
        public string Per { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        [Column(name: "FkProjectId", TypeName = "int")]
        public int FkProjectId { get; set; }
        //public virtual Project Project { get; set; }
    }
}

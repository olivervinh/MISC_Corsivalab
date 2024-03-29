﻿using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Models
{
    [Table("CLM_ProjectCredentialLog")]
    public class ProjectCredentialLog : EntityBase
    {
        [Column(name: "FK_ProjectId", TypeName = "int")]
        public int FkProjectId { get; set; }
        [Column(name: "FK_StaffId", TypeName = "int")]
        public int FkStaffId { get; set; }
        [Column(name: "LastUpdate", TypeName = "datetime2(7)")]
        public DateTime LastUpdate { get; set; }
        [Column(name: "CreatedAt", TypeName = "datetime2(7)")]
        public DateTime CreatedAt { get; set; }
        //[ForeignKey(nameof(FkProjectId))]
        //[ForeignKey(nameof(FkStaffId))]
        [Column(name: "Remarks", TypeName = "varchar(MAX)")]
        public string Remark { get; set; }
        //public virtual Project Project { get; set; }
        //public virtual Staff Staff { get; set; }
    }
}

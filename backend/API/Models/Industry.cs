using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_Industry")]
    public class Industry : EntityBase
    {
        [Column("IndustryName", TypeName = "varchar(MAX)")]
        public string IndustryName { get; set; }
        //public virtual ICollection<Customer> Customers { get; set; }
    }
}
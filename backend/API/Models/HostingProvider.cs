using API.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("CLM_HostingProvider")]
    public class HostingProvider:EntityBase
    {
        public string Name { get; set; }
    }
}

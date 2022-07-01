using API.Models.Base;

namespace API.Models
{
    public class DomainProvider:EntityBase
    {
        public string Name { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}

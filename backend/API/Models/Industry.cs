using API.Models.Base;

namespace API.Models
{
    public class Industry : EntityBase
    {
        public string IndustryName { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}

using API.Models.Base;

namespace API.Models
{
    public class ApiLog: EntityBase
    {
        public string Description { get; set; }
        public string LogDateTime { get; set; }
    }
}

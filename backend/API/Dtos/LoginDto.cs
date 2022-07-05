using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class LoginDto
    {
        [StringLength(50)]
        public string username { get; set; }
        [StringLength(50)]
        public string password { get; set; }
    }
}

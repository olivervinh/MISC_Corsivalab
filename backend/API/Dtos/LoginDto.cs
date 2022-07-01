using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class LoginDto
    {
        [StringLength(10)]
        public string Username { get; set; }
        [StringLength(10)]
        public string Password { get; set; }
    }
}

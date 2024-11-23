using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Planify.Models
{

    public class User
    {
        public int Id { get; set; }

        [EmailAddress]
        public required string Email { get; set; }
        public required string HashPassword { get; set; }
        public Employee? Employee { get; set; }
        public ICollection<Role> Roles { get; set; } = new List<Role>();
    }

    public class UserRegisterDTO
    {
        [EmailAddress]
        public required string Email { get; set; }
        public required string Password { get; set; }
    }

}

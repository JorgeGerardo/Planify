using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Planify.Models
{

    public class User : DbBaseModel<int>
    {

        [EmailAddress]
        public required string Email { get; set; }
        public required string HashPassword { get; set; }
        public Employee? Employee { get; set; }
        public ICollection<Role> Roles { get; set; } = new List<Role>();
    }


    public class UserCreateDTO
    {
        [EmailAddress]
        public required string Email { get; set; }
        [MinLength(8, ErrorMessage = "The password must be 8 characters or more.")]
        [MaxLength(32, ErrorMessage = "Password must be 32 characters maximum.")]
        public required string Password { get; set; }

    }

    public class UserUpdateDTO
    {
        [EmailAddress]
        public string? Email { get; set; }

        [MinLength(8, ErrorMessage = "The password must be 8 characters or more.")]
        [MaxLength(32, ErrorMessage = "Password must be 32 characters maximum.")]
        public string? Password { get; set; }
        public string? NewPassword { get; set; }

        public int? EmployeeId { get; set; }

    }

}

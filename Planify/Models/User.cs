using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Planify.Models
{

    public class User : DbBaseModel<int>
    {

        [EmailAddress]
        [JsonPropertyOrder(-1)]
        public required string Email { get; set; }
        public required string HashPassword { get; set; }
        [JsonIgnore]
        public Employee? Employee { get; set; }

        [JsonIgnore]
        public ICollection<Role> Roles { get; set; } = new List<Role>();

    }


    public class UserCreateDTO
    {
        [EmailAddress(ErrorMessage = "El email proporcionado no es correcto.")]
        public required string Email { get; set; }
        [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        [MaxLength(32, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        public required string Password { get; set; }

    }

    public class UserUpdateDTO
    {
        [EmailAddress(ErrorMessage = "El email proporcionado no es correcto.")]
        public string? Email { get; set; }

        [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        [MaxLength(32, ErrorMessage = "La contraseña debe tener cómo máximo 32 caracteres.")]
        public required string Password { get; set; }
        public string? NewPassword { get; set; }
    }

}

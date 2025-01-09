using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Planify.Models
{
    public class Department : BaseModel<int>
    {
        [JsonIgnore]
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }

    public class DepartmentDTO
    {
        [MaxLength(25, ErrorMessage = "El límite para el nombre es de 25 caracteres.")]
        [MinLength(3, ErrorMessage = "El nombre de tener al menos 3 caracteres.")]
        public required string Name { get; set; }
    }
}

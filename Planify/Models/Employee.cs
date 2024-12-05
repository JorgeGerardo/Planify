using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Planify.Models
{
    public class Employee : BaseModel<int>
    {
        //TODO: Deberías agregar required? no lo se, averigualo
        [JsonIgnore]
        public User? User { get; set; }
        public int UserId { get; set; }
        public DateOnly HireDate { get; set; }
        [JsonIgnore]
        public Person? Person { get; set; }
        public int PersonId { get; set; }
        //TODO: Ignora todas las propiedades de navegación y verifica la API
        [JsonIgnore]
        public ICollection<Department> Departments { get; set; } = new List<Department>();
        [JsonIgnore]
        public ICollection<Project> Projects { get; set; } = new List<Project>();
        [JsonIgnore]
        public ICollection<ProjectTask> Tasks { get; set; } = new List<ProjectTask>();
    }

    public class EmployeeCreateDTO
    {
        public required int UserId { get; set; }
        public required int PersonId { get; set; }
        public required DateOnly HireDate { get; set; }
        public required string Name { get; set; }
    }

    public class EmployeeUpdateDTO
    {
        public int UserId { get; set; }
        public int PersonId { get; set; }
        public DateOnly? HireDate { get; set; }
        public string? Name { get; set; }
    }


}

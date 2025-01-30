using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Planify.Models
{
    public class Employee : BaseModel<int>
    {
        [JsonIgnore]
        public User? User { get; set; }
        public int UserId { get; set; }
        public DateOnly HireDate { get; set; }
        [JsonIgnore]
        public Person? Person { get; set; }
        public int PersonId { get; set; }
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
        //TODO: Se cambiaron a required
        public required int UserId { get; set; }
        public required int PersonId { get; set; }
        public DateOnly? HireDate { get; set; }
        public string? Name { get; set; }
    }


}

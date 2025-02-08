using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Planify.Models
{
    //TODO: Add gender field
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
        //TODO: Quita el nullable:
        public Gender? Gender { get; set; }
        //TODO: Quita el nullable:
        public string? UrlProfileImage { get; set; }
    }

    public class EmployeeCreateDTO
    {
        public required int UserId { get; set; }
        public required int PersonId { get; set; }
        public required DateOnly HireDate { get; set; }
        public required string Name { get; set; }
        public required Gender Gender { get; set; }
        //TODO: No debería existir, lo agregas tu desde el backend no desde el frontend
        //public required string UrlProfileImage { get; set; }
    }

    public class EmployeeUpdateDTO
    {
        public required int UserId { get; set; }
        public required int PersonId { get; set; }
        public DateOnly? HireDate { get; set; }
        public string? Name { get; set; }
        public Gender? Gender { get; set; }
        //public string? UrlProfileImage { get; set; }
    }

    public enum Gender
    {
        Male, Female
    }
}

using System;
using System.Collections.Generic;
namespace Planify.Models
{
    public class Employee : BaseModel<int>
    {
        //TODO: Deberías agregar required? no lo se, averigualo
        public User? User { get; set; }
        public int UserId { get; set; }
        public DateOnly HireDate { get; set; }
        public Person? Person { get; set; }
        public int PersonId { get; set; }
        public ICollection<Department> Departments { get; set; } = new List<Department>();
        public ICollection<Project> Projects { get; set; } = new List<Project>();
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

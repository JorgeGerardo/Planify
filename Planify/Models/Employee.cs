using System;
using System.Collections.Generic;
namespace Planify.Models
{
    public class Employee : BaseModel<int>
    {
        public required User User { get; set; }
        public int UserId { get; set; }
        public DateOnly HireDate { get; set; }
        public required Person Person { get; set; }
        public int PersonId { get; set; }
        public ICollection<Department> Departments { get; set; } = new List<Department>();
        public ICollection<Project> Projects { get; set; } = new List<Project>();
        public ICollection<ProjectTask> Tasks { get; set; } = new List<ProjectTask>();
    }
}

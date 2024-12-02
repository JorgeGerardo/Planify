using System.Collections.Generic;

namespace Planify.Models
{
    public class Project : BaseModel<int>
    {
        //TODO: Deberías cambiarlo a Required dado que deberías verificar si
        // existe el Employee y en otros modelos si no esta asignado a otros modelos.
        public Employee? Manager { get; set; }
        public int ManagerId { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<ProjectTask> Tasks { get; set; } = new List<ProjectTask>();
    }

    public class ProjectDTO
    {
        public required string Name { get; set; }
        public int ManagerId { get; set; }
    }
}

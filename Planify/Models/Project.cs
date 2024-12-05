using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Planify.Models
{
    public class Project : BaseModel<int>
    {
        //TODO: Deberías cambiarlo a Required dado que deberías verificar si
        // existe el Employee y en otros modelos si no esta asignado a otros modelos.
        [JsonIgnore]
        public Employee? Manager { get; set; }
        public int ManagerId { get; set; }
        [JsonIgnore]
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        [JsonIgnore]
        public ICollection<ProjectTask> Tasks { get; set; } = new List<ProjectTask>();
    }

    public class ProjectCreateDTO
    {
        public required string Name { get; set; }
        public required int ManagerId { get; set; }
    }

    public class ProjectUpdateDTO
    {
        public required string Name { get; set; }
        public int? ManagerId { get; set; }

    }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Planify.Models
{
    public class Project : BaseModel<int>
    {
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

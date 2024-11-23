using System.Collections.Generic;

namespace Planify.Models
{
    public class Project : BaseModel<int>
    {

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<ProjectTask> Tasks { get; set; } = new List<ProjectTask>();
    }
}

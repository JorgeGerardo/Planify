using System.Collections.Generic;

namespace Planify.Models
{
    public class Department : BaseModel
    {
        ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}

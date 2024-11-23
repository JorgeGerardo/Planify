using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Planify.Models
{
    public class Department : BaseModel<int>
    {
        [JsonIgnore]
        //public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Planify.Models
{
    public class Role : BaseModel<int>
    {
        [JsonIgnore]
        public ICollection<User> Users { get; set; } = new List<User>();
    }

    public class RoleDTO
    {
        public required string Name { get; set; }
    }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Planify.Models
{
    public class Permisions
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        [JsonIgnore]
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}

using System.Collections.Generic;

namespace Planify.Models
{
    public class SessionData
    {
        public required int id { get; set; }
        public required string Email { get; set; }
        public string? Name { get; set; }
        public IEnumerable<string> Roles { get; set; } = new List<string>();

    }
}

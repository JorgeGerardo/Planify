using System.Collections.Generic;

namespace Planify.Models
{
    public class Role : BaseModel
    {
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}

using System.Collections.Generic;

namespace Planify.Models
{
    public class Role : BaseModel<int>
    {
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}

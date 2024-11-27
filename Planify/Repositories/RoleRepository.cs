using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class RoleRepository : GenericRepository<Role, int>
    {
        public RoleRepository(ProjectContext context) : base(context) { }
    }
}

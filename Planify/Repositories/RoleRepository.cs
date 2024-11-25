using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class RoleRepository : GenericRepository<Role, int>
    {
        private ProjectContext _projectContext;
        public RoleRepository(ProjectContext context) : base(context)
        {
            _projectContext = context;
        }
    }
}

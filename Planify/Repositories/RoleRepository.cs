using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class RoleRepository : GenericRepository<Role, int>
    {
        private string[] NavProperties = [nameof(Role.Users)];
        public override string[] _NavigationProperties { get => NavProperties; }

        public RoleRepository(ProjectContext context) : base(context) { }
    }
}

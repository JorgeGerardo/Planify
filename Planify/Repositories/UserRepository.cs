using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class UserRepository : GenericRepository<User, int>
    {
        public UserRepository(ProjectContext context) : base(context) { }
    }
}

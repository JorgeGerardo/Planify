using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class UserRepository : GenericRepository<User, int>
    {
        private ProjectContext _projectContext;

        //public UserRepository(ProjectContext context) : base(context) { }

        public UserRepository(ProjectContext context) : base(context)
        {
            this._projectContext = context;
        }
    }
}

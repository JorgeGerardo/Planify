using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class PersonRepository : GenericRepository<Person, int>
    {
        private readonly ProjectContext _projectContext;
        public PersonRepository(ProjectContext context) : base(context) {
            _projectContext = context;
        }
    }
}

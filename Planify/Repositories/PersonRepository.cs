using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class PersonRepository : GenericRepository<Person, int>
    {
        public PersonRepository(ProjectContext context) : base(context) { }
    }
}

using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class PersonRepository : GenericRepository<Person, int>
    {
        private string[] NavProperties = [nameof(Employee)];
        public override string[] _NavigationProperties { get => NavProperties; }

        public PersonRepository(ProjectContext context) : base(context) { }
    }
}

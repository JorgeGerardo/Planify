using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee, int>
    {
        private string[] NavProperties = [nameof(Person), nameof(User)];
        public override string[] _NavigationProperties { get => NavProperties; }

        public EmployeeRepository(ProjectContext context) : base(context) { }
    }
}

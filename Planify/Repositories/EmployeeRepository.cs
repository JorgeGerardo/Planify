using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee, int>
    {

        private string[] NavProperties = [nameof(Employee.Person), nameof(Employee.User), nameof(Employee.Departments)];
        public override string[] _NavigationProperties { get => NavProperties; }

        public EmployeeRepository(ProjectContext context) : base(context) { }
    }
}

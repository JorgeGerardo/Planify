using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee, int>
    {
        public EmployeeRepository(ProjectContext context) : base(context) { }
    }
}

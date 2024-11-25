using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee, int>
    {
        private ProjectContext _projectContext;
        public EmployeeRepository(ProjectContext context) : base(context)
        {
            _projectContext = context;
        }
    }
}

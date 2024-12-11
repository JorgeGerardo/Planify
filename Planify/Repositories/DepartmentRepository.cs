using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class DepartmentRepository : GenericRepository<Department, int>
    {
        private string[] NavProperties = [nameof(Department.Employees)];

        public override string[] _NavigationProperties { get => NavProperties; }
        public DepartmentRepository(ProjectContext context) : base(context) { }
    }
}

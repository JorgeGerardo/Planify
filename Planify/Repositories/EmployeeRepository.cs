using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee, int>
    {
        private string[] includes = [nameof(Person), nameof(User)];
        public override string[] _Inclues { get => includes; set => _Inclues = value; }

        public EmployeeRepository(ProjectContext context) : base(context) { }
    }
}

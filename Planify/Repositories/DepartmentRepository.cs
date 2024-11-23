using Planify.Data;
using Planify.Models;
using System.Threading.Tasks;

namespace Planify.Repositories
{
    public class DepartmentRepository : GenericRepository<Department, int>
    {
        private ProjectContext _projectContext;
        public DepartmentRepository(ProjectContext context) : base(context)
        {
            _projectContext = context;
        }

        public async Task<int> save() =>
            await _projectContext.SaveChangesAsync();
    }
}

using Planify.Data;
using Planify.Models;
using System.Threading.Tasks;

namespace Planify.Repositories
{
    public class DepartmentRepository : GenericRepository<Department, int>
    {
        public DepartmentRepository(ProjectContext context) : base(context) { }
    }
}

using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class ProjectTaskComentaryRepository : GenericRepository<ProjectTaskComentary, int>
    {
        public ProjectTaskComentaryRepository(ProjectContext context) : base(context) { }
    }
}

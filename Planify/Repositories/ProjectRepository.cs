using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class ProjectRepository : GenericRepository<Project, int>
    {
        private string[] NavProperties = [nameof(Project.Employees), nameof(Project.Tasks)];
        public override string[] _NavigationProperties { get => NavProperties; }

        public ProjectRepository(ProjectContext context) : base(context) { }
    }
}

using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class ProjectTaskRepository : GenericRepository<ProjectTask, int>
    {
        private string[] NavProperties = [nameof(ProjectTask.Employees), nameof(ProjectTask.Project), nameof(ProjectTask.Comentaries)];
        public override string[] _NavigationProperties { get => NavProperties; }

        public ProjectTaskRepository(ProjectContext context) : base(context) { }
    }
}

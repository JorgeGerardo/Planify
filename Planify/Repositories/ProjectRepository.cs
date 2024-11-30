using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class ProjectRepository : GenericRepository<Models.Project, int>
    {
        private string[] NavProperties = [nameof(Models.Project.Employees), nameof(Models.Project.Tasks)];
        //private string[] NavProperties = ["Employees", "tasks"];
        public override string[] _NavigationProperties { get => NavProperties; }

        public ProjectRepository(ProjectContext context) : base(context)
        {
        }
    }
}

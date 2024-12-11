using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class ProjectTaskComentaryRepository : GenericRepository<ProjectTaskComentary, int>
    {
        private string[] NavProperties = [nameof(ProjectTaskComentary.ProjectTask), nameof(ProjectTaskComentary.Author)];
        public override string[] _NavigationProperties { get => NavProperties; }
        public ProjectTaskComentaryRepository(ProjectContext context) : base(context) { }
    }
}

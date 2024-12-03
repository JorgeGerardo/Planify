using Planify.Data;
using Planify.Models;
using System.Threading.Tasks;

namespace Planify.Repositories.UoW
{

    public class ProjectManagement_UoW : IProjectManagement_UoW
    {
        private readonly ProjectContext _Context;
        private readonly IGenericCRUDRepository<Project, int> _Projects;
        private readonly IGenericCRUDRepository<ProjectTask, int> _ProjectTasks;
        //TODO: No se si se necesitará
        //private readonly IGenericCRUDRepository<Employee, int> _Employees;

        public ProjectManagement_UoW(
            ProjectContext context,
            IGenericCRUDRepository<Project, int> projects,
            IGenericCRUDRepository<ProjectTask, int> projectTasks
            )
        {
            _Context = context;
            _Projects = projects;
            _ProjectTasks = projectTasks;
        }

        public IGenericCRUDRepository<Project, int> projects => _Projects;
        public IGenericCRUDRepository<ProjectTask, int> projectTasks => _ProjectTasks;

        public async Task<int> SaveAsync() =>
            await _Context.SaveChangesAsync();
    }
}

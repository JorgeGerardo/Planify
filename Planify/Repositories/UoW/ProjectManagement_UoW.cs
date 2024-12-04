using Planify.Data;
using Planify.Models;
using System.Threading.Tasks;

namespace Planify.Repositories.UoW
{

    public class ProjectManagement_UoW : IProjectManagement_UoW
    {
        private readonly ProjectContext _Context;
        private readonly IGenericCRUDRepository<Project, int> _Projects;
        private readonly IGenericCRUDRepository<ProjectTask, int> _Tasks;
        private readonly IGenericCRUDRepository<ProjectTaskComentary, int> _Comentaries;
        private readonly IGenericCRUDRepository<Employee, int> _Employees;

        public ProjectManagement_UoW(
            ProjectContext context,
            IGenericCRUDRepository<Project, int> projects,
            IGenericCRUDRepository<ProjectTask, int> projectTasks,
            IGenericCRUDRepository<ProjectTaskComentary, int> comentaries,
            IGenericCRUDRepository<Employee, int> employees)
        {
            _Context = context;
            _Projects = projects;
            _Tasks = projectTasks;
            _Comentaries = comentaries;
            _Employees = employees;

        }


        public IGenericCRUDRepository<Project, int> projects => _Projects;
        public IGenericCRUDRepository<ProjectTask, int> projectTasks => _Tasks;
        public IGenericCRUDRepository<ProjectTaskComentary, int> projectTasksComentaries => _Comentaries;
        public IGenericCRUDRepository<Employee, int> Employees => _Employees;


        public async Task<int> SaveAsync() =>
            await _Context.SaveChangesAsync();
    }
}

using Planify.Models;
using System.Threading.Tasks;

namespace Planify.Repositories.UoW
{
    public interface IProjectManagement_UoW
    {
        IGenericCRUDRepository<Project, int> projects { get; }
        IGenericCRUDRepository<ProjectTask, int> projectTasks { get; }
        IGenericCRUDRepository<ProjectTaskComentary, int> projectTasksComentaries { get; }
        IGenericCRUDRepository<Employee, int> Employees { get; }

        Task<int> SaveAsync();
    }
}

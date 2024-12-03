using Planify.Models;
using System.Threading.Tasks;

namespace Planify.Repositories.UoW
{
    public interface IProjectManagement_UoW
    {
        IGenericCRUDRepository<Project, int> projects { get; }
        IGenericCRUDRepository<ProjectTask, int> projectTasks { get; }

        Task<int> SaveAsync();
    }
}

using Planify.Models;
using System.Threading.Tasks;

namespace Planify.Repositories.UoW
{
    public interface IUserManagementUoW
    {
        IGenericCRUDRepository<User, int> Users { get; }
        IGenericCRUDRepository<Employee, int> Employees { get; }
        IGenericCRUDRepository<Person, int> Persons { get; }
        IGenericCRUDRepository<Department, int> Departmens { get; }

        Task<int> SaveAsync();
    }
}

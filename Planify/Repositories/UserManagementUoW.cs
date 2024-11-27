using Planify.Data;
using Planify.Models;
using System.Threading.Tasks;

namespace Planify.Repositories
{
    public class UserManagementUoW : IUserManagementUoW
    {
        private readonly ProjectContext _Context;
        private readonly IGenericCRUDRepository<User, int> _UserRepository;
        private readonly IGenericCRUDRepository<Employee, int> _EmployeRepository;
        private readonly IGenericCRUDRepository<Person, int> _PersonRepository;

        public UserManagementUoW(
            ProjectContext context,
            IGenericCRUDRepository<User, int> Users,
            IGenericCRUDRepository<Person, int> Persons,
            IGenericCRUDRepository<Employee, int> Employees)
        {
            _Context = context;
            _UserRepository = Users;
            _EmployeRepository = Employees;
            _PersonRepository = Persons;
        }

        public IGenericCRUDRepository<Person, int> Persons => _PersonRepository;
        public IGenericCRUDRepository<User, int> Users => _UserRepository;

        public IGenericCRUDRepository<Employee, int> Employees => _EmployeRepository;

        public Task<int> SaveAsync() =>
            _Context.SaveChangesAsync();
    }
}

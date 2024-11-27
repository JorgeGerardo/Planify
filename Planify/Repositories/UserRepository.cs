using Planify.Data;
using Planify.Models;
using System.Threading.Tasks;

namespace Planify.Repositories
{
    public class UserRepository : GenericRepository<User, int>
    {
        public UserRepository(ProjectContext context) : base(context) { }
    }

    //TODO: Change name
    public class UOW_Users : IUOW_Users_Employee
    {
        private readonly ProjectContext _Context;
        private readonly IGenericCRUDRepository<User, int> _UserRepository;
        private readonly IGenericCRUDRepository<Employee, int> _EmployeRepository;
        private readonly IGenericCRUDRepository<Person, int> _PersonRepository;

        public UOW_Users(
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

    public interface IUOW_Users_Employee
    {
        IGenericCRUDRepository<User, int> Users { get; }
        IGenericCRUDRepository<Employee, int> Employees { get; }
        IGenericCRUDRepository<Person, int> Persons { get; }

        Task<int> SaveAsync();
    }
}

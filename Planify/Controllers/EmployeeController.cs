using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planify.Models;
using Planify.Repositories;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : GenericController<Employee, EmployeeRepository>
    {
        public EmployeeController(IGenericCRUDRepository<Employee, int> department) : base(department) { }

    }
}

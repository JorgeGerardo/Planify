using Microsoft.AspNetCore.Mvc;
using Planify.Models;
using Planify.Repositories;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class DepartmentsController2 : GenericController<Department, DepartmentRepository>
    {
        public DepartmentsController2(IGenericCRUDRepository<Department, int> department) : base(department) { }

    }

    //POST & PUT
    public partial class DepartmentsController2
    {

    }

}

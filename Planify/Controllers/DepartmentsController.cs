using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Planify.Models;
using Planify.Repositories;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    //TODO: Haz una politica que pertenezca al departamento RH y sea administrador
    public class DepartmentsController :
        GenericController<Department, DepartmentRepository, DepartmentDTO, DepartmentDTO>
    {
        public DepartmentsController(IGenericCRUDRepository<Department, int> _Repository) :
            base(_Repository)
        { }

        protected override Department MapToEntity(DepartmentDTO dto) =>
            new Department { Name = dto.Name };

        protected override Department MapToUpdateEntity(Department currentState, DepartmentDTO dto)
        {
            currentState.Name = dto.Name;
            return currentState;
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Planify.Models;
using Planify.Repositories;
using Planify.Repositories.UoW;
using Planify.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class DepartmentsController :
        GenericController<Department, DepartmentRepository, DepartmentDTO, DepartmentDTO>
    {
        IUserManagementUoW _uow;
        public DepartmentsController(IUserManagementUoW uow) :
            base(uow.Departmens) => _uow = uow;

        protected override Department MapToEntity(DepartmentDTO dto) =>
            new Department { Name = dto.Name };

        protected override Department MapToUpdateEntity(Department currentState, DepartmentDTO dto)
        {
            currentState.Name = dto.Name;
            return currentState;
        }

    }

    // [MinimumRh]
    public partial class DepartmentsController
    {
        [Authorize(Policy = PolicyNames.MinimumRhOrViewer)]
        public override Task<IEnumerable<Department>> Get(int page = 0, int pageSize = 5) => 
            base.Get(page, pageSize);

        [Authorize(Policy = PolicyNames.MinimumRhOrViewer)]
        public override Task<ActionResult<Department>> GetById(int id) => 
            base.GetById(id);

        [Authorize(Policy = PolicyNames.MinimumRh)]
        public override Task<IActionResult> Update(int id, DepartmentDTO createDto) =>
            base.Update(id, createDto);

        [Authorize(Policy = PolicyNames.MinimumRh)]
        public override Task<IActionResult> Add([FromBody] DepartmentDTO createDto) =>
            base.Add(createDto);


    }


    // [MinimumRhAdmin]
    public partial class DepartmentsController
    {
        [Authorize(Policy = PolicyNames.MinimumRhAdmin)]
        public override Task<IEnumerable<Department>> GetWithoutFiltters(int page = 0, int pageSize = 5) =>
            base.GetWithoutFiltters(page, pageSize);

        [Authorize(Policy = PolicyNames.MinimumRhAdmin)]
        public override Task<IActionResult> Delete(int id) =>
            base.Delete(id);

    }

    //Add-remove employees [MinimumRhAdmin]
    public partial class DepartmentsController
    {
        [HttpPut("add-employees/{departmentId}")]
        [Authorize(Policy = PolicyNames.MinimumRhAdmin)]
        public async Task<ActionResult> AddEmployeesToDeparment(List<int> employeesId, int departmentId)
        {
            Department? dep = await _uow.Departmens.GetById(departmentId);
            if (dep is null)
                return NotFound("El departamento seleccionado no existe");

            foreach (var id in employeesId)
            {
                var emp = await _uow.Employees.GetById(id);
                if (emp is null)
                    return NotFound($"El usuario con el id {id} no existe.");

                dep.Employees.Add(emp);
            }

            await _uow.SaveAsync();
            return NoContent();
        }

        [HttpPut("remove-employees/{departmentId}")]
        [Authorize(Policy = PolicyNames.MinimumRhAdmin)]
        public async Task<ActionResult> RemoveEmployeesofDeparment(List<int> employeesId, int departmentId)
        {
            Department? dep = await _uow.Departmens.GetById(departmentId);

            if (dep is null)
                return NotFound("El departamento seleccionado no existe");

            foreach (var id in employeesId)
            {
                var emp = await _uow.Employees.GetById(id);
                if (emp is null)
                    return NotFound($"El usuario con el id {id} no existe.");

                dep.Employees.Remove(emp);
            }

            await _uow.SaveAsync();
            return NoContent();
        }

    }

}

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



    //[Authorize(Policy = PolicyNames.Rh_RhAdmin_Admin_SA)]
    public partial class DepartmentsController
    {
        [Authorize(Policy = PolicyNames.Rh_RhAdmin_Admin_SA)]
        public override Task<IEnumerable<Department>> Get() => 
            base.Get();

        [Authorize(Policy = PolicyNames.Rh_RhAdmin_Admin_SA)]
        public override Task<ActionResult<Department>> GetById(int id) => 
            base.GetById(id);

        [Authorize(Policy = PolicyNames.Rh_RhAdmin_Admin_SA)]
        public override Task<IActionResult> Update(int id, DepartmentDTO createDto) =>
            base.Update(id, createDto);

        [Authorize(Policy = PolicyNames.Rh_RhAdmin_Admin_SA)]
        public override Task<IActionResult> Add([FromBody] DepartmentDTO createDto) =>
            base.Add(createDto);

        [Authorize(Policy = PolicyNames.RhAdmin_Admin_SA)]
        public override Task<IActionResult> Delete(int id) => 
            base.Delete(id);

    }


    public partial class DepartmentsController
    {
        [Authorize(Policy = PolicyNames.RhAdmin_Admin_SA)]
        public override Task<IEnumerable<Department>> GetWithoutFiltters() =>
            base.GetWithoutFiltters();

    }

    //Add-remove employees
    //[Authorize(Policy = PolicyNames.Sa_Admin_RhAdmin)]
    public partial class DepartmentsController
    {
        [HttpPut("add-employees/{departmentId}")]
        [Authorize(Policy = PolicyNames.RhAdmin_Admin_SA)]
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
        [Authorize(Policy = PolicyNames.RhAdmin_Admin_SA)]
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

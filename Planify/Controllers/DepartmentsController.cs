using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories;
using Planify.Repositories.UoW;
using Planify.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    //TODO: Creo que se debería borrar el modelo y controlador Department
    // creo que no sirve para nada
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
        public override Task<IEnumerable<Department>> Get(int page = 0, int? pageSize = null) => 
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
        [HttpPatch("add-employees/{departmentId}")]
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

        [HttpPatch("remove-employees/{departmentId}")]
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

    //TODO: Get Users Deparment
    public partial class DepartmentsController
    {
        [HttpGet("user-deparments/{employeeId}")]
        [Authorize(Policy = PolicyNames.MinimumRhAdminOrViewer)]
        public async Task<ActionResult<List<Department>>> UserDepartments(int employeeId)
        {
            if (!(await _uow.Employees.Exist(employeeId)))
                return NotFound("El empleado no existe.");

            return await _uow.Departmens.GetAll()
                .Where(d => d.Employees.Any(e => e.Id == employeeId)).ToListAsync();
        }


        [HttpGet("my-deparments")]
        [Authorize]
        public async Task<ActionResult<List<Department>>> GetMyDeparments()
        {
            if (!(Int32.TryParse(HttpContext.User?.Identity?.Name, out int UserId)))
                return StatusCode(500);

            if (!(await _uow.Employees.Exist(UserId)))
                return NotFound("El empleado no existe.");

            return await _uow.Departmens.GetAll()
                .Where(d => d.Employees.Any(e => e.Id == UserId)).ToListAsync();
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories;
using Planify.Repositories.UoW;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    //TODO: Haz una politica que pertenezca al departamento RH y sea administrador
    //TODO: No se si se debería agregar todas las propiedades de navegación a los modelos
    public class DepartmentsController :
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

        [HttpPut("add-employees/{departmentId}")]
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

        /* TODO: Incluso aunque no cargue las propiedades se elimina, wow
        //Deberías buscar una forma de implementar las propiedades de navegación cuando se necesiten.
        //quiza cada repositorio deberia tener un metodo que las active y
        //cada UoW deberia tener un metodo que llame a ese metodo de todos sus repositorios
        //que por defecto esten activadas o desactivas
        */
        [HttpPut("remove-employees/{departmentId}")]
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

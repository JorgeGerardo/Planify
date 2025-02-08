using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Planify.Models;
using Planify.Repositories;
using Planify.Repositories.UoW;
using Planify.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public partial class EmployeesController : GenericController<Employee, EmployeeRepository, EmployeeCreateDTO, EmployeeUpdateDTO>
    {
        private readonly IUserManagementUoW UOW;
        public EmployeesController(IUserManagementUoW uow) : base(uow.Employees) =>
            UOW = uow;
    }

    //Maps
    public partial class EmployeesController : GenericController<Employee, EmployeeRepository, EmployeeCreateDTO, EmployeeUpdateDTO>
    {
        protected override Employee MapToEntity(EmployeeCreateDTO dto) =>
            MapToEntityAsync(dto).GetAwaiter().GetResult();

        protected async override Task<Employee> MapToEntityAsync(EmployeeCreateDTO dto)
        {
            Person? person = await UOW.Persons.GetById(dto.PersonId);
            if (person is null)
                throw new Exception("Persons not found");

            if (person.Employee is not null)
                throw new Exception("Esta persona ya esta asignada a un empleado");


            User? user = await UOW.Users.GetById(dto.UserId);
            if (user is null)
                throw new Exception("El usuario indicado no existe.");

            if (user.Employee is not null)
                throw new Exception("El usuario ya esta asigando a un empleado.");

            return new Employee()
            {
                Name = dto.Name,
                PersonId = dto.PersonId,
                Person = person,
                User = user,
                HireDate = dto.HireDate,
                UserId = dto.UserId,
                Gender = dto.Gender,
            };
        }

        protected async override Task<Employee> MapToUpdateEntityAsync(Employee currentState, EmployeeUpdateDTO dto)
        {
            if (currentState.PersonId != dto.PersonId)
            {
                Person? person = await UOW.Persons.GetById(dto.PersonId);
                if (person is null)
                    throw new Exception($"La persona no existe. Id: {dto.PersonId}.");

                if (person.Employee is not null)
                    throw new Exception("Esta persona ya esta asignado a un empleado.");

                currentState.Person = person;
                currentState.PersonId = dto.PersonId;
            }

            if (currentState.UserId != dto.UserId)
            {
                User? user = await UOW.Users.GetById(dto.UserId);
                if (user is null)
                    throw new Exception($"El usuario proporcionado no existe. Id : {dto.UserId}.");

                if (user.Employee is not null)
                    throw new Exception("Este usuario ya esta asignado a un empleado.");

                currentState.UserId = dto.UserId;
                currentState.User = user;
            }

            currentState.Name = dto.Name ?? currentState.Name;
            currentState.HireDate = dto.HireDate ?? currentState.HireDate;
            currentState.Gender = dto.Gender ?? currentState.Gender;

            return currentState;
        }

        protected override Employee MapToUpdateEntity(Employee currentState, EmployeeUpdateDTO dto) =>
            MapToUpdateEntityAsync(currentState, dto).GetAwaiter().GetResult();

    }

    public partial class EmployeesController
    {
        [Authorize(Policy = PolicyNames.MinimumRhOrViewer)]
        public override Task<IEnumerable<Employee>> Get(int page = 0, int? pageSize = null) =>
            base.Get(page, pageSize);

        [Authorize(Policy = PolicyNames.MinimumRhOrViewer)]
        public override Task<ActionResult<Employee>> GetById(int id) =>
            base.GetById(id);



        [Authorize(Policy = PolicyNames.MinimumRh)]
        public override Task<IActionResult> Update(int id, EmployeeUpdateDTO createDto) =>
            base.Update(id, createDto);

        [Authorize(Policy = PolicyNames.MinimumRh)]
        public override Task<IActionResult> Add([FromBody] EmployeeCreateDTO createDto) =>
            base.Add(createDto);

        [Authorize(Policy = PolicyNames.MinimumRhAdmin)]
        public override Task<IEnumerable<Employee>> GetWithoutFiltters(int page = 0, int? pageSize = null) =>
            base.GetWithoutFiltters(page, pageSize);

        [Authorize(Policy = PolicyNames.MinimumRhAdmin)]
        public override Task<IActionResult> Delete(int id) =>
            base.Delete(id);


    }
}

using Microsoft.AspNetCore.Mvc;
using Planify.Models;
using Planify.Repositories;
using Planify.Repositories.UoW;
using System;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class EmployeesController : GenericController<Employee, EmployeeRepository, EmployeeCreateDTO, EmployeeUpdateDTO>
    {
        private readonly IUserManagementUoW UOW;
        public EmployeesController(IUserManagementUoW uow) : base(uow.Employees) =>
            UOW = uow;
    }

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

            return currentState;
        }

        protected override Employee MapToUpdateEntity(Employee currentState, EmployeeUpdateDTO dto) =>
            MapToUpdateEntityAsync(currentState, dto).GetAwaiter().GetResult();

    }
}

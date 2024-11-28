using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories;
using System;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class EmployeeController : GenericController<Employee, EmployeeRepository, EmployeeCreateDTO, EmployeeUpdateDTO>
    {
        private readonly IUserManagementUoW UOW;
        public EmployeeController(IUserManagementUoW uow) : base(uow.Employees) =>
            UOW = uow;
    }

    public partial class EmployeeController : GenericController<Employee, EmployeeRepository, EmployeeCreateDTO, EmployeeUpdateDTO>
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

        protected override Task<Employee> MapToUpdateEntityAsync(Employee currentState, EmployeeUpdateDTO dto)
        {
            throw new NotImplementedException();
        }

        protected  override Employee MapToUpdateEntity(Employee currentState, EmployeeUpdateDTO dto) =>
            MapToUpdateEntityAsync(currentState, dto).GetAwaiter().GetResult();

    }
}

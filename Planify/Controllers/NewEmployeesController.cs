using Microsoft.AspNetCore.Mvc;
using Planify.Models;
using Planify.Repositories;
using System;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewEmployeesController : ControllerBase
    {
        private readonly IUserManagementUoW UOW;
        public NewEmployeesController(IUserManagementUoW uow)
        {
            UOW = uow;
        }

        [HttpPost("trywe")]
        public async Task<object> Publicar()
        {
            var user = new User
            {
                Email = "55tierra@gmail.com",
                HashPassword = "b88b88cd87cf54d08aabf61b73023cf35551850dc8da5a9d8ae410ef243f74ce",
            };

            var person = new Person
            {
                City = "55tierra",
                Country = "Mex",
                LastNames = "Lopez Dorigan",
                Name = "lejos",
                Sate = "Sinaloa",
                BornDate = DateOnly.FromDateTime(new DateTime(2001, 5, 1)),
                PhoneNumber = "1234567890",
            };

            var employee = new Employee
            {
                Name = "Carlitos",
                Person = person,
                User = user,
            };

            user.Employee = employee;
            employee.Person = person;

            await UOW.Users.Create(user);
            await UOW.Employees.Create(employee);
            await UOW.Persons.Create(person);


            return await UOW.Employees.Save();
            //return await UOW.SaveAsync();

            //TODO: Cómo creo el action sin el nombre del método?
            //return CreatedAtAction
        }
    }
}

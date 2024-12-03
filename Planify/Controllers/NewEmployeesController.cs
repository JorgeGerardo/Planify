using Microsoft.AspNetCore.Mvc;
using Planify.Models;
using Planify.Repositories.UoW;
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
            //person id 3:
            //User id 4:

            //TODO: Prueba con el debuger si se asigana automaticamente la propiedad UserId
            User? user4 = await UOW.Users.GetById(4);
            Person? person3 = await UOW.Persons.GetById(3);

            if (user4 == null || person3 is null)
                return "Valio verga";


            var employee = new Employee
            {
                Name = "Carlitos",
            };

            //employee.Person = person3;
            employee.PersonId = person3.Id;
            //employee.User = user4;
            employee.UserId = user4.Id;



            //var user = new User
            //{
            //    Email = "carlitosfeliz@gmail.com",
            //    HashPassword = "67274c77b1d97147090cac43704024931a434bd1d4618c436115b691b99548f8",
            //};

            //var person = new Person
            //{
            //    City = "Monterrey",
            //    Country = "Mexico",
            //    LastNames = "Lopez Lopez",
            //    Name = "Carlos",
            //    Sate = "Nuevo Leon",
            //    BornDate = DateOnly.FromDateTime(new DateTime(2001, 5, 1)),
            //    PhoneNumber = "1234567890",
            //};

            //var employee = new Employee
            //{
            //    Name = "Carlitos",
            //    Person = person,
            //    User = user,
            //};

            //user.Employee = employee;
            //employee.Person = person;

            //await UOW.Users.Create(user);
            await UOW.Employees.Create(employee);
            //await UOW.Persons.Create(person);


            return await UOW.SaveAsync();
            //return await UOW.SaveAsync();

            //TODO: Cómo creo el action sin el nombre del método?
            //return CreatedAtAction
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Planify.Models;
using Planify.Repositories;
using System;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : GenericController<Employee, EmployeeRepository, EmployeeCreateDTO, EmployeeUpdateDTO>
    {
        private readonly IGenericCRUDRepository<Person, int> _PersonRepository;
        private readonly IGenericCRUDRepository<User, int> _UserRepository;
        public EmployeeController(
            IGenericCRUDRepository<Employee, int> _employeRep,
            IGenericCRUDRepository<User, int> _userRep,
            IGenericCRUDRepository<Person, int> _personRep
        ) : base(_employeRep)
        {
            _UserRepository = _userRep;
            _PersonRepository = _personRep;
        }

        protected override Employee MapToEntity(EmployeeCreateDTO dto) =>
            MapToEntityAsync(dto).GetAwaiter().GetResult();

        protected async override Task<Employee> MapToEntityAsync(EmployeeCreateDTO dto)
        {
            //TODO: No se si tengo que consultarlo o solamente poner el campo:
            Person? person = await _PersonRepository.GetById(dto.PersonId);
            //User? user = await _UserRepository.GetById(dto.PersonId);

            //TODO: Implementa un try catch en el controlador generico
            //justo al mapear la entidad
            if (person is null)
                throw new Exception("Persons not found");
            //if (user is null)
            //    throw new Exception("User not found");

            //Employee res = new Employee()
            //{
            //    Name = dto.Name,
            //    PersonId = dto.PersonId,
            //    Person = person,
            //    User = user,


            //};

            throw new NotImplementedException();
            //return res;
        }

        protected override Employee MapToUpdateEntity(Employee currentState, EmployeeUpdateDTO dto)
        {
            throw new System.NotImplementedException();
        }
    }
}

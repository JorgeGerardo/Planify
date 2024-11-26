using Microsoft.AspNetCore.Mvc;
using Planify.Models;
using Planify.Repositories;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : GenericController<Person, PersonRepository, PersonDTO>
    {
        public PersonsController(IGenericCRUDRepository<Person, int> _Repository) :
            base(_Repository)
        { }

        protected override Person MapToEntity(PersonDTO dto)
        {
            return new Person
            {
                City = dto.City,
                Country = dto.Country,
                FirstNames = dto.FirstNames,
                LastNames = dto.LastNames,
                Name = dto.Name,
                Sate = dto.Sate,
                BornDate = dto.BornDate,
                PhoneNumber = dto.PhoneNumber,
            };
        }

        protected override Person MapToUpdateEntity(Person currentState, PersonDTO dto)
        {
            throw new System.NotImplementedException();
        }
    }
}

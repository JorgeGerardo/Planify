using Microsoft.AspNetCore.Mvc;
using Planify.Models;
using Planify.Repositories;
using System;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : GenericController<Person, PersonRepository, PersonDTO, PersonUpdateDTO>
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
                LastNames = dto.LastNames,
                Name = dto.Name,
                Sate = dto.Sate,
                BornDate = dto.BornDate,
                PhoneNumber = dto.PhoneNumber,
            };

        }

        protected override Person MapToUpdateEntity(Person currentState, PersonUpdateDTO dto)
        {
            currentState.Name = dto.Name ?? currentState.Name;
            currentState.BornDate = dto.BornDate ?? currentState.BornDate;
            currentState.LastNames = dto.LastNames ?? currentState.LastNames;
            currentState.City = dto.City ?? currentState.City;
            currentState.Sate = dto.Sate ?? currentState.Sate;
            currentState.Country = dto.Country ?? currentState.Country;
            currentState.PhoneNumber = dto.PhoneNumber ?? currentState.PhoneNumber;

            return currentState;
        }

    }
}

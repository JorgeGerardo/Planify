using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Planify.Models;
using Planify.Repositories;
using Planify.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public partial class PersonsController : GenericController<Person, PersonRepository, PersonDTO, PersonUpdateDTO>
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


    public partial class PersonsController
    {
        [Authorize(Policy = PolicyNames.MinimumRhOrViewer)]
        public override Task<IEnumerable<Person>> Get() =>
            base.Get();

        [Authorize(Policy = PolicyNames.MinimumRhOrViewer)]
        public override Task<ActionResult<Person>> GetById(int id) =>
            base.GetById(id);

        [Authorize(Policy = PolicyNames.MinimumRh)]
        public override Task<IActionResult> Update(int id, PersonUpdateDTO createDto) =>
            base.Update(id, createDto);

        [Authorize(Policy = PolicyNames.MinimumRh)]
        public override Task<IActionResult> Add([FromBody] PersonDTO createDto) =>
            base.Add(createDto);

    }

    public partial class PersonsController
    {
        [Authorize(Policy = PolicyNames.MinimumRhAdmin)]
        public override Task<IEnumerable<Person>> GetWithoutFiltters() =>
            base.GetWithoutFiltters();

        [Authorize(Policy = PolicyNames.MinimumRhAdmin)]
        public override Task<IActionResult> Delete(int id) =>
            base.Delete(id);

    }
}

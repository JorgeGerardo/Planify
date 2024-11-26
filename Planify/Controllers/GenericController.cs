using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories;
using Planify.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    public abstract partial class GenericController<T, TRepository, TCreateDto> : ControllerBase
        where T : BaseModel<int>
        where TRepository : IGenericCRUDRepository<T, int>
    {
        protected readonly IGenericCRUDRepository<T, int> _Repository;
        public GenericController(IGenericCRUDRepository<T, int> context) =>
            _Repository = context;

        [HttpGet]
        public async Task<IEnumerable<T>> Get() =>
            await _Repository.GetAll().ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<T>> GetById(int id)
        {
            T? res = await _Repository.GetById(id);
            return res is not null ? res : NotFound();
        }



    }


    //POST & PUT
    public abstract partial class GenericController<T, TRepository, TCreateDto>
    {
        protected abstract T MapToEntity(TCreateDto dto);
        protected abstract T MapToUpdateEntity(T currentState, TCreateDto dto);

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, TCreateDto createDto)
        {
            var entity = await _Repository.GetById(id);
            if (entity is null)
                return NotFound();

            MapToUpdateEntity(entity, createDto);
            _Repository.Updated(entity);

            ConcurrencyState state = await Concurrency.Check(() => _Repository.Save());

            if (state == ConcurrencyState.ConcurrencyDetected)
                return Conflict(new { message = Concurrency.ConflictMessage() });

            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> Add(TCreateDto createDto)
        {
            T newEntity = MapToEntity(createDto);
            await _Repository.Create(newEntity);
            await _Repository.Save();
            if (newEntity is null)
                return StatusCode(500, "Error creating entity.");

            return CreatedAtAction(nameof(GetById), new { newEntity.Id }, newEntity);
        }

       

    }

    //DELETE:
    public partial class GenericController<T, TRepository, TCreateDto>
    {
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool res = await _Repository.SoftDelete(id);
            await _Repository.Save();

            return res ? NoContent() : NotFound();
        }

        [HttpDelete("hardDelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            bool res = await _Repository.HardDelete(id);
            await _Repository.Save();

            return res ? NoContent() : NotFound();
        }
    }

}

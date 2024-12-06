using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories;
using Planify.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Authorize]
    public abstract partial class GenericController<T, TRepository, TCreateDto, TUpdateDTO> : ControllerBase
        where T : DbBaseModel<int>
        where TRepository : IGenericCRUDRepository<T, int>
    {
        protected readonly IGenericCRUDRepository<T, int> _Repository;
        public GenericController(IGenericCRUDRepository<T, int> context) =>
            _Repository = context;

        [HttpGet]
        public virtual async Task<IEnumerable<T>> Get() =>
            await _Repository.GetAll().ToListAsync();

        [HttpGet("No-filtters")]
        public virtual async Task<IEnumerable<T>> GetWithoutFiltters() =>
            await _Repository.GetAllNoFilters().ToListAsync();

        [HttpGet("delete")]
        public virtual async Task<IEnumerable<T>> GetEntitiesDeleted() =>
            await _Repository.GetDeletedEntities().ToListAsync();



        [HttpGet("{id}")]
        public virtual async Task<ActionResult<T>> GetById(int id)
        {
            T? res = await _Repository.GetById(id);
            return res is not null ? res : NotFound();
        }

    }


    //Map entity
    public abstract partial class GenericController<T, TRepository, TCreateDto, TUpdateDTO>
    {
        //Create
        protected abstract T MapToEntity(TCreateDto dto);
        protected virtual Task<T> MapToEntityAsync(TCreateDto dto) =>
            Task.FromResult(MapToEntity(dto));

        //Update
        protected abstract T MapToUpdateEntity(T currentState, TUpdateDTO dto);
        protected virtual Task<T> MapToUpdateEntityAsync(T currentState, TUpdateDTO dto) =>
            Task.FromResult(MapToUpdateEntity(currentState, dto));

    }

    //POST & PUT

    public abstract partial class GenericController<T, TRepository, TCreateDto, TUpdateDTO>
    {

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update(int id, TUpdateDTO createDto)
        {
            var entity = await _Repository.GetById(id);
            if (entity is null)
                return NotFound();

            try { MapToUpdateEntity(entity, createDto); }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            _Repository.Updated(entity);

            ConcurrencyState state = await Concurrency.Check(() => _Repository.Save());

            if (state == ConcurrencyState.ConcurrencyDetected)
                return Conflict(new { message = Concurrency.ConflictMessage() });

            return NoContent();
        }


        [HttpPost]
        public virtual async Task<IActionResult> Add([FromBody] TCreateDto createDto)
        {
            try {
                T newEntity = MapToEntity(createDto);
                await _Repository.Create(newEntity);
                await _Repository.Save();

                if (newEntity is null)
                    return StatusCode(500, "Error creating entity.");

                return CreatedAtAction(nameof(GetById), new { newEntity.Id }, newEntity);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



    }

    //DELETE:
    public partial class GenericController<T, TRepository, TCreateDto, TUpdateDTO>
    {
        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            bool res = await _Repository.SoftDelete(id);
            await _Repository.Save();

            return res ? NoContent() : NotFound();
        }

        [HttpPut("restore/{id}")]
        public virtual async Task<IActionResult> RemoveSoftDelete(int id)
        {
            bool res = await _Repository.RemoveSoftDelete(id);
            await _Repository.Save();

            return res ? NoContent() : NotFound();
        }

        [HttpDelete("hard/{id}")]
        public virtual async Task<IActionResult> HardDelete(int id)
        {
            bool res = await _Repository.HardDelete(id);
            await _Repository.Save();

            return res ? NoContent() : NotFound();
        }
    }

}

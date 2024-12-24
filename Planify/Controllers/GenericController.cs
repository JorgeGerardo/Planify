using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories;
using Planify.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planify.Controllers
{

    public abstract partial class GenericController<T, TRepository, TCreateDto, TUpdateDTO> : ControllerBase
        where T : DbBaseModel<int>
        where TRepository : IGenericCRUDRepository<T, int>
    {
        protected readonly IGenericCRUDRepository<T, int> _Repository;
        public GenericController(IGenericCRUDRepository<T, int> context) =>
            _Repository = context;


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


    //[Get's]
    public abstract partial class GenericController<T, TRepository, TCreateDto, TUpdateDTO>
    {
        [HttpGet(), Authorize]
        //TODO: Add paginación
        public virtual async Task<IEnumerable<T>> Get(int page = 0, int pageSize = 5) =>
            await _Repository.GetAll().Skip(page * pageSize).Take(pageSize).ToListAsync();

        [HttpGet("No-filtters")]
        [Authorize(Policy = PolicyNames.MinimumAdmin)]
        //TODO: Add paginación
        public virtual async Task<IEnumerable<T>> GetWithoutFiltters() =>
            await _Repository.GetAllNoFilters().ToListAsync();

        [HttpGet("deleted-entities")]
        [Authorize(Policy = PolicyNames.MinimumAdmin)]
        //TODO: Add paginación
        public virtual async Task<IEnumerable<T>> GetEntitiesDeleted() =>
            await _Repository.GetDeletedEntities().ToListAsync();


        [HttpGet("{id}"), Authorize]
        public virtual async Task<ActionResult<T>> GetById(int id)
        {
            T? res = await _Repository.GetById(id);
            return res is not null ? res : NotFound();
        }

    }

    //POST & PUT
    public abstract partial class GenericController<T, TRepository, TCreateDto, TUpdateDTO>
    {

        [HttpPut("{id}"), Authorize]
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


        [HttpPost, Authorize]
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

    //DELETE'S [SA, NA]
    public partial class GenericController<T, TRepository, TCreateDto, TUpdateDTO>
    {
        [HttpDelete("{id}"), Authorize]
        public virtual async Task<IActionResult> Delete(int id)
        {
            bool res = await _Repository.SoftDelete(id);
            await _Repository.Save();

            return res ? NoContent() : NotFound();
        }

        [HttpPut("restore/{id}")]
        [Authorize(Policy = PolicyNames.SA)]
        public virtual async Task<IActionResult> RemoveSoftDelete(int id)
        {
            bool res = await _Repository.RemoveSoftDelete(id);
            await _Repository.Save();

            return res ? NoContent() : NotFound();
        }

        [HttpDelete("hard/{id}")]
        [Authorize(Policy = PolicyNames.SA)]
        public virtual async Task<IActionResult> HardDelete(int id)
        {
            bool res = await _Repository.HardDelete(id);
            await _Repository.Save();

            return res ? NoContent() : NotFound();
        }
    }

}

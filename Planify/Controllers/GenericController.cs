using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories;
using Planify.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    //TODO: Creo que vas a tener que cambiar el modelo T BaseModel
    // por una interfaz que implemente eso en caso de que no funcione con
    // otros tipos
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

        [HttpPost]
        public async Task<IActionResult> Add(TCreateDto createDto)
        {
            T newEntity = MapToEntity(createDto);  // Convertir DTO a entidad
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


















    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Implementación para los modelos que solo pueden cambiar su nombre
    // y su DTO solo tiene el nombre
    public class GenericControllerOnlyChangeName<T, TRepository, TCreateDto> : GenericController<T, TRepository, TCreateDto>
        where T : BaseModel<int>
        where TRepository : IGenericCRUDRepository<T, int>
    {

        public GenericControllerOnlyChangeName(IGenericCRUDRepository<T, int> _Repository) : base(_Repository) { }


        [HttpPut("{id}")]
        public virtual async Task<IActionResult> UpdateName(int id, T deparmentChanges)
        {
            var dep = await _Repository.GetById(id);
            if (dep is null)
                return NotFound();

            dep.Name = deparmentChanges.Name;
            _Repository.Updated(dep);

            ConcurrencyState state = await Concurrency.Check(() => _Repository.Save());

            if (state == ConcurrencyState.ConcurrencyDetected)
                return Conflict(new { message = Concurrency.ConflictMessage() });

            return NoContent();
        }

        //TODO: check that
        protected override T MapToEntity(TCreateDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}

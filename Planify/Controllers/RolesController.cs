using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planify.Models;
using Planify.Repositories;
using Planify.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Planify.Services.Concurrency;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //GET's
    public partial class RolesController : ControllerBase
    {
        private readonly IGenericCRUDRepository<Role, int> _RoleRepository;
        public RolesController(IGenericCRUDRepository<Role, int> context) =>
            _RoleRepository = context;

        [HttpGet]
        public async Task<IEnumerable<Role>> Get() =>
            await _RoleRepository.GetAll().ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Role>> GetById(int id)
        {
            Role? res = await _RoleRepository.GetById(id);
            return res is not null ? res : NotFound();
        }
    }

    //POST & PUT
    public partial class RolesController
    {
        [HttpPost]
        public async Task<IActionResult> Add(RoleDTO newRole)
        {
            Role? NewRole = await _RoleRepository
                .Create(new Role { Name = newRole.Name });

            await _RoleRepository.Save();

            if (NewRole is null)
                return StatusCode(500);

            return CreatedAtAction(nameof(Get), new { NewRole.Id }, NewRole);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, RoleDTO roleChanges)
        {
            var rol = await _RoleRepository.GetById(id);
            if (rol is null)
                return NotFound();

            rol.Name = roleChanges.Name;
            _RoleRepository.Updated(rol);

            ConcurrencyState state = await Concurrency.Check(() => _RoleRepository.Save());

            if (state == ConcurrencyState.ConcurrencyDetected)
                return Conflict(new { message = ConflictMessage() });

            return NoContent();
        }
    }


    //Delete:
    public partial class RolesController
    {
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool res = await _RoleRepository.SoftDelete(id);
            await _RoleRepository.Save();

            return res ? NoContent() : NotFound();
        }

        [HttpDelete("hardDelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            bool res = await _RoleRepository.HardDelete(id);
            await _RoleRepository.Save();

            return res ? NoContent() : NotFound();
        }
    }

}

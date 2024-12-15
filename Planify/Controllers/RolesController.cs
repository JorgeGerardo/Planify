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
    public partial class RolesController : GenericController<Role, RoleRepository, RoleDTO, RoleDTO>
    {
        private readonly IGenericCRUDRepository<User, int> _UsersRepository;
        public RolesController(IGenericCRUDRepository<Role, int> _Repository,
            IGenericCRUDRepository<User, int> userRepository) : base(_Repository) {
            _UsersRepository = userRepository;
        }


        protected override Role MapToEntity(RoleDTO dto) =>
            new Role() { Name = dto.Name };

        protected override Role MapToUpdateEntity(Role currentState, RoleDTO dto)
        {
            currentState.Name = dto.Name;
            return currentState;
        }

    }

    public partial class RolesController
    {
        [Authorize(Policy = PolicyNames.MinimumAdmin)]
        public override Task<IEnumerable<Role>> Get() =>
            base.Get();

        [Authorize(Policy = PolicyNames.MinimumAdmin)]
        public override Task<ActionResult<Role>> GetById(int id) =>
            base.GetById(id);


        


        [Authorize(Policy = PolicyNames.SA)]
        public override Task<IActionResult> Update(int id, RoleDTO createDto) =>
            base.Update(id, createDto);

        [Authorize(Policy = PolicyNames.SA)]
        public override Task<IActionResult> Add([FromBody] RoleDTO createDto) =>
            base.Add(createDto);


        [Authorize(Policy = PolicyNames.SA)]
        public override Task<IEnumerable<Role>> GetWithoutFiltters() =>
            base.GetWithoutFiltters();

        [Authorize(Policy = PolicyNames.SA)]
        public override Task<IActionResult> Delete(int id) =>
            base.Delete(id);


    }


    // Own Enpoints [SA]
    public partial class RolesController
    {
        [HttpPost("asign-role/{userId}")]
        [Authorize(Policy = PolicyNames.SA)]
        public async Task<ActionResult> AsignRole(int userId, List<int> rolesId)
        {
            User? user = await _UsersRepository.GetById(userId);

            if (user is null)
                return NotFound("El usuario no existe.");

            foreach (var roleId in rolesId)
            {
                Role? role = await _Repository.GetById(roleId);

                if (role is null)
                    return NotFound("Un role especificado no existe, actualice la página e intente de nuevo.");

                user.Roles.Add(role);
            }

            await _UsersRepository.Save();
            return Ok();
        }

        [HttpPost("unasign-role/{userId}")]
        [Authorize(Policy = PolicyNames.SA)]
        public async Task<ActionResult> UnasignRole(int userId, List<int> rolesId)
        {
            User? user = await _UsersRepository.GetById(userId);

            if (user is null)
                return NotFound("El usuario no existe.");

            foreach (var roleId in rolesId)
            {
                Role? role = await _Repository.GetById(roleId);

                if (role is null)
                    return NotFound("Un role especificado no existe, actualice la página e intente de nuevo.");

                user.Roles.Remove(role);
            }

            await _UsersRepository.Save();
            return Ok();
        }

    }

}

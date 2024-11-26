using Microsoft.AspNetCore.Mvc;
using Planify.Models;
using Planify.Repositories;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //GET's
    public partial class RolesController : GenericController<Role, RoleRepository, RoleDTO, RoleDTO>
    {
        public RolesController(IGenericCRUDRepository<Role, int> _Repository) : base(_Repository) { }


        protected override Role MapToEntity(RoleDTO dto) =>
            new Role() { Name = dto.Name };

        protected override Role MapToUpdateEntity(Role currentState, RoleDTO dto)
        {
            currentState.Name = dto.Name;
            return currentState;
        }
    }

}

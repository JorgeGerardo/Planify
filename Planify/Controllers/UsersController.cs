using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Planify.Data;
using Planify.Models;
using Planify.Repositories;
using Planify.Repositories.UoW;
using Planify.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class UsersController : GenericController<User, UserRepository, UserCreateDTO, UserUpdateDTO>
    {
        private readonly IConfiguration _configuration;
        private readonly ProjectContext _context;
        private readonly IUserManagementUoW _userManagement_uow;

        public UsersController(
            IGenericCRUDRepository<User, int> _Repository,
            IConfiguration configuration,
            ProjectContext context,
            IUserManagementUoW userManagement_uow)
        : base(_Repository)
        {
            _configuration = configuration;
            _context = context;
            _userManagement_uow = userManagement_uow;
        }
    }

    //Map models
    public partial class UsersController : GenericController<User, UserRepository, UserCreateDTO, UserUpdateDTO>
    {
        //Create:
        protected override User MapToEntity(UserCreateDTO dto) =>
            MapToEntityAsync(dto).GetAwaiter().GetResult();

        protected async override Task<User> MapToEntityAsync(UserCreateDTO dto)
        {
            bool emailIsRegistered = await _Repository.ExistAsync(u => u.Email.Equals(dto.Email));

            if (emailIsRegistered)
                throw new Exception("El email ya ha sido registrado en otra cuenta.");

            return new User
            {
                Email = dto.Email,
                HashPassword = AuthService.EncrypBySHA256(dto.Password),
            };
        }


        //Update:
        protected override User MapToUpdateEntity(User currentState, UserUpdateDTO dto) =>
            MapToUpdateEntityAsync(currentState, dto).GetAwaiter().GetResult();

        protected async override Task<User> MapToUpdateEntityAsync(User currentState, UserUpdateDTO dto)
        {
            bool CredentialsCorrect = await CheckCredentials(currentState.Id, dto.Password);

            if (!CredentialsCorrect)
                throw new Exception("Credenciales incorrectas.");

            if (dto.NewPassword is not null)
                currentState.HashPassword = AuthService.EncrypBySHA256(dto.NewPassword);

            if (dto.Email is not null)
            {
                bool emailIsRegistered = await _Repository.ExistAsync(u => u.Email.Equals(dto.Email));

                if (emailIsRegistered)
                    throw new Exception("El email ya ha sido registrado en otra cuenta.");

                currentState.Email = dto.Email;
            }

            return currentState;
        }

    }

    //Login
    public partial class UsersController : GenericController<User, UserRepository, UserCreateDTO, UserUpdateDTO>
    {
        [HttpPost("/Login")]
        [AllowAnonymous]
        public async Task<ActionResult<string>> Login(UserCreateDTO credentials)
        {
            string hashPassword = AuthService.EncrypBySHA256(credentials.Password);
            User? existingUser = await _context.Users.Include(p => p.Roles)
                .FirstOrDefaultAsync(u => u.Email == credentials.Email && u.HashPassword == hashPassword);

            if (existingUser is null)
                return NotFound();

            JWTConfig? jwt = _configuration.GetSection("JWT").Get<JWTConfig>();


            //if (jwt is null)
            //    return StatusCode(500, new { message = "JWT configuration is missing" });

            //string token = AuthService.GenerateToken(existingUser, jwt);
            //return Ok(new { token });
            return jwt is not null ?
                Ok(AuthService.GenerateToken(existingUser, jwt)) :
                StatusCode(500);
        }


        [HttpGet("my-credentials"), Authorize]
        public async Task<ActionResult<SessionData?>> getCredentials()
        {
            if (!(Int32.TryParse(HttpContext.User?.Identity?.Name, out int UserId)))
                return StatusCode(500);
            
            User? user = await _userManagement_uow.Users.GetById(UserId);
            Employee? employe = await _userManagement_uow.Employees.GetById(UserId);
            
            if (user is null)
                return NotFound();

            return new SessionData {
                id = user.Id,
                Email = user.Email,
                Name = employe?.Name ?? null,
                Roles = user.Roles.Select(r => r.Name)
            };
        }
    }

    public partial class UsersController
    {
        [AllowAnonymous]
        public override Task<IActionResult> Add([FromBody] UserCreateDTO createDto) =>
            base.Add(createDto);

        [Authorize]
        public override Task<IActionResult> Update(int id, UserUpdateDTO createDto) =>
            base.Update(id, createDto);

        [Authorize(Policy = PolicyNames.MinimumAdmin)]
        public override Task<IEnumerable<User>> Get(int page = 0, int? pageSize = null) =>
            base.Get(page, pageSize);

        [Authorize(Policy = PolicyNames.MinimumAdmin)]
        public override Task<ActionResult<User>> GetById(int id) =>
            base.GetById(id);

        [Authorize(Policy = PolicyNames.MinimumAdmin)]
        public override Task<IEnumerable<User>> GetWithoutFiltters(int page = 0, int? pageSize = null) =>
            base.GetWithoutFiltters(page, pageSize);

        [Authorize(Policy = PolicyNames.MinimumAdmin)]
        public override Task<IActionResult> Delete(int id) =>
            base.Delete(id);

        
    }


    //Extra tools
    public partial class UsersController
    {
        private async Task<bool> CheckCredentials(int id, string password)
        {
            Console.WriteLine(AuthService.EncrypBySHA256(password));

            string hashPassword = AuthService.EncrypBySHA256(password);

            User? existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == id && u.HashPassword == hashPassword);

            return existingUser is null ? false : true;
        }
    }



}

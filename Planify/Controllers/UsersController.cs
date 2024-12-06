using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Planify.Data;
using Planify.Models;
using Planify.Repositories;
using Planify.Services;
using System;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class UsersController : GenericController<User, UserRepository, UserCreateDTO, UserUpdateDTO>
    {
        //private readonly IGenericCRUDRepository<User, int> _repository;
        private readonly IConfiguration _configuration;
        private readonly ProjectContext _context;

        public UsersController(
            IGenericCRUDRepository<User, int> _Repository,
            IConfiguration configuration,
            ProjectContext context)
        : base(_Repository)
        {
            //_repository = _Repository;
            _configuration = configuration;
            _context = context;
        }
    }

    //Maps
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
                HashPassword = AuthService.EncrypBySHA256(dto.Password)
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

        private async Task<bool> CheckCredentials(int id, string password)
        {
            Console.WriteLine(AuthService.EncrypBySHA256(password));

            string hashPassword = AuthService.EncrypBySHA256(password);

            User? existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == id && u.HashPassword == hashPassword);

            return existingUser is null ? false : true;
        }
    }

    //Login
    public partial class UsersController : GenericController<User, UserRepository, UserCreateDTO, UserUpdateDTO>
    {
        [HttpPost("/Login")]
        public async Task<IActionResult> Login(UserCreateDTO credentials)
        {
            string hashPassword = AuthService.EncrypBySHA256(credentials.Password);
            User? existingUser = await _context.Users.Include(p => p.Roles)
                .FirstOrDefaultAsync(u => u.Email == credentials.Email && u.HashPassword == hashPassword);

            if (existingUser is null)
                return NotFound();

            JWTConfig? jwt = _configuration.GetSection("JWT").Get<JWTConfig>();

            return jwt is not null ?
                Ok(AuthService.GenerateToken(existingUser, jwt)) :
                StatusCode(500);
        }
    }


}

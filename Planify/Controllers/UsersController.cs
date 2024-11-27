using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Planify.Data;
using Planify.Models;
using Planify.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class UsersController : ControllerBase
    {
        private readonly ProjectContext _context;
        private readonly IConfiguration _configuration;

        public UsersController(ProjectContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
    }
    //TODO:
    //No tiene actualizar
    // No tiene soft delete


    public partial class UsersController : ControllerBase
    {

        [HttpPost("/Login")]
        public async Task<IActionResult> Login(UserCreateDTO credentials)
        {
            string hashPassword = AuthService.EncrypBySHA256(credentials.Password);
            User? existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == credentials.Email && u.HashPassword == hashPassword);

            if (existingUser is null)
                return NotFound();

            JWTConfig? jwt = _configuration.GetSection("JWT").Get<JWTConfig>();
            if (jwt is null)
                return StatusCode(500);

            return Ok(AuthService.GenerateToken(existingUser, jwt));
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUser(UserCreateDTO user)
        {
            User newUser = new User()
            { Email = user.Email, HashPassword = AuthService.EncrypBySHA256(user.Password) };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { newUser.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}

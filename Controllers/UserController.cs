using ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ecommerce.Models;
using ecommerce.Dtos.Requests;
using BCrypt.Net;
namespace ecommerce.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public UsersController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET: api/User
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = dbContext.Users.ToList();
            return Ok(users);
        }


        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);
            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                PasswordHash = passwordHash
            };
            dbContext.Users.Add(user);
            await dbContext.SaveChangesAsync();
            return Ok(new { message = "User successfully created", Data = user });
        }
    }    
}
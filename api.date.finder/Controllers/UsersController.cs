using System.Collections.Generic;
using data.date.finder;
using Microsoft.AspNetCore.Mvc;
using model.date.finder;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace api.date.finder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
            return await _context.Users.ToListAsync<AppUser>();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id){
            return await _context.Users.FindAsync(id);
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wfm_DBContext.Models;
using Wfm_Models.Models;

namespace Wfm_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly EFContext _context;

        public UsersController(EFContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
        {
            return await _context.users.ToListAsync();
        }

      
        

      
        [HttpPost]
        public async Task<ActionResult<Users>> PostUsers(Users users)
        {
           _context.users.Add(users);
            await _context.SaveChangesAsync();

            return users;
        }


 
    }
}


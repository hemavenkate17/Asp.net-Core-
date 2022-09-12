using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wfm_DBContext.Models;
using Wfm_Models.Models;

namespace Wfm_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoftlocksController : ControllerBase
    {
        private readonly EFContext _context;

        public SoftlocksController(EFContext context)
        {
            _context = context;
        }

        // GET: api/Softlocks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Softlock>>> Getsoftlock()
        {
            return await _context.softlock.ToListAsync();
        }

        // GET: api/Softlocks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Softlock>> GetSoftlock(int id)
        {
            var softlock = await _context.softlock.FindAsync(id);

            if (softlock == null)
            {
                return NotFound();
            }

            return softlock;
        }

        // PUT: api/Softlocks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSoftlock(int id, Softlock softlock)
        {
            if (id != softlock.lockid)
            {
                return BadRequest();
            }

            _context.Entry(softlock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SoftlockExists(id))
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

        // POST: api/Softlocks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Softlock>> PostSoftlock(Softlock softlock)
        {
            _context.softlock.Add(softlock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSoftlock", new { id = softlock.lockid }, softlock);
        }

        // DELETE: api/Softlocks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Softlock>> DeleteSoftlock(int id)
        {
            var softlock = await _context.softlock.FindAsync(id);
            if (softlock == null)
            {
                return NotFound();
            }

            _context.softlock.Remove(softlock);
            await _context.SaveChangesAsync();

            return softlock;
        }

        private bool SoftlockExists(int id)
        {
            return _context.softlock.Any(e => e.lockid == id);
        }
    }
}

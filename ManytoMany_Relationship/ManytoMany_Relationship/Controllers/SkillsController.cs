using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ManytoMany_Relationship.Model;

namespace ManytoMany_Relationship.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly Db_Context _context;

        public SkillsController(Db_Context context)
        {
            _context = context;
        }

        // GET: api/Skills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Skills_Employees>>> GetSkills()
        {
            var result = await _context.Skills.Include(x => x.Skillmaps).ThenInclude(x => x.Skills).Select(x => new Skills_Employees
            {
                skillid = x.skillid,
                name = x.name,
                Employees = x.Skillmaps.Select(y => y.Employees.name).ToList()
            }).ToListAsync();
            return result;
        }

    }
}

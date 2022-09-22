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
    public class EmployeesController : ControllerBase
    {
        private readonly Db_Context _context;

        public EmployeesController(Db_Context context)
        {
            _context = context;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employees_Skills>>> GetEmployees()
        {
            // return await _context.Employees.Include(s => s.Skillmaps).ToListAsync();
            var result = await _context.Employees.Include(x => x.Skillmaps).ThenInclude(x => x.Skills).Select(x => new Employees_Skills
            {
                employee_id = x.employee_id,
                name = x.name,
                status = x.status,
                manager = x.manager,
                wfm_manager = x.wfm_manager,
                email = x.email,
                experience = x.experience,
                lockstatus = x.lockstatus,
                Skills = x.Skillmaps.Select(y => y.Skills.name).ToList()
            }).ToListAsync();

            return result;
        }
    }

}

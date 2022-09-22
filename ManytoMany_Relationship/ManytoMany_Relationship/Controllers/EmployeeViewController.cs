using ManytoMany_Relationship.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ManytoMany_Relationship.Controllers
{
    public class EmployeeViewController : Controller
    {
        private readonly EmployeesController _employees;

        public EmployeeViewController(EmployeesController employees)
        {
            _employees = employees;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _employees.GetEmployees();
            return View(result);

            
        }
    }
}

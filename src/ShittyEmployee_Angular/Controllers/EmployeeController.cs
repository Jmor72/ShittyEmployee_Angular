using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ShittyEmployee_Angular.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ShittyEmployee_Angular.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeContext _context { get; set; }

        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }
        
        //Place one of these before each API Method...
        [Route("api/[controller]")]

        // GET: api/employee
        //**NOTE** If you want to test API via PostMan, disable Angular routing in both Startup.cs & app.config.js (otherwise)
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _context.Employees.ToList();
        }

        // GET api/employee/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _context.Employees.FirstOrDefault(s => s.Id == id);
        }

        [Route("api/[controller]")]
        // POST api/employee
        [HttpPost]
        public void Post([FromBody]Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        // PUT api/employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }

        // DELETE api/employee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var employee = _context.Employees.FirstOrDefault(t => t.Id == id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }
    }
}
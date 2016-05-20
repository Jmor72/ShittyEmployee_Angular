using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ShittyEmployee_Angular.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ShittyEmployee_Angular.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        // GET: api/values
        [HttpGet]
        public Employee[] Get()
        {
            var employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, Name = "Person 1", Department = "Sales1", Employed = 3, Supervisor = "supervisor 1", Salary = 35000, Address = "1234 Fake St." });
            employees.Add(new Employee { Id = 2, Name = "Person 2", Department = "Sales2", Employed = 2, Supervisor = "supervisor 2", Salary = 535000, Address = "12fdsf4 Fake St." });
            employees.Add(new Employee { Id = 3, Name = "Person 3", Department = "Sales3", Employed = 11, Supervisor = "supervisor 3", Salary = 35000, Address = "fdsf34 Fake St." });

            return employees.ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return Get().Where(r => r.Id == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core3Angular8.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Core3Angular8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            List<Student> oStudents = new List<Student>()
            {
                new Student(){Id=1,Name="Anil",Roll=1001},
                new Student(){Id=2,Name="Uday",Roll=1002},
                new Student(){Id=3,Name="Gaurav",Roll=1003}
            };

            return oStudents;
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

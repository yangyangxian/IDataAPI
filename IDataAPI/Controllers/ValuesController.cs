using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IDataAPI.Services.Calculators;
using Microsoft.AspNetCore.Mvc;

namespace IDataAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World" };
        }

        [Route("EggPuzzle")]
        [HttpGet]
        public IEnumerable<string> EggPuzzle()
        {
            Puzzles puzzles = new Puzzles();
            return new string[] { "result", puzzles.EggPuzzle().ToString() };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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

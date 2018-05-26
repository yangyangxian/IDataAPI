using IDataAPI.Interfaces.Calculators;
using IDataAPI.Interfaces.Counters;
using IDataAPI.Services.Counters;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IDataAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        IPuzzles puzzles;
        TestDILifeTimeService testDILifeTimeService;

        private IScopedCounter scopedCounter;
        private ITransientCounter transientCounter;
        private ISingletonCounter singletonCounter;

        public ValuesController(IPuzzles puzzles,
            TestDILifeTimeService testDILifeTimeService,
            IScopedCounter scopedCounter,
            ITransientCounter transientCounter,
            ISingletonCounter singletonCounter)
        {
            this.puzzles = puzzles;
            this.testDILifeTimeService = testDILifeTimeService;
            this.scopedCounter = scopedCounter;
            this.transientCounter = transientCounter;
            this.singletonCounter = singletonCounter;
        }

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
            return new string[] { "result", this.puzzles.EggPuzzle().ToString() };
        }

        [Route("TestDILifeTime")]
        [HttpGet]
        public IEnumerable<string> TestDILifeTime()
        {
            this.testDILifeTimeService.AddCounts();

            this.scopedCounter.Add();
            this.transientCounter.Add();
            this.singletonCounter.Add();

            IList<string> results = this.testDILifeTimeService.ReturnCounts();
            results.Add("ScopedCounter in controller:" + this.scopedCounter.GetCount());
            results.Add("TransientCounter in controller:" + this.transientCounter.GetCount());
            results.Add("SingleCounter in controller:" + this.singletonCounter.GetCount());

            return results;
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

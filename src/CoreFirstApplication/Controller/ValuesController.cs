using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreFirstApplication.Controller
{
    [Route("api/[controller]")]
    public class ValuesController
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id:int}")]
        public string Get([FromQuery]int  id, string query)
        {
            return $"value {id} query={ query}";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Value value)
        {
            if (!ModelState.IsValid)
            {

            }
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
        public class Value
        {

            public int Id { get; set; }
            [MinLength(3)]
            public string Text { get; set; }
        }
    }
}

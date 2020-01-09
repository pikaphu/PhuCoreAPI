using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PhuCoreAPI.Controllers {

    [ApiController]
    [Route("[controller]")] // /phu/api/
    public class PhuController: ControllerBase { // GET: api/Phu

        public struct UserLogin
        {
            string name;
            string password;
            public UserLogin(string _name, string _password)
            {
                name = _name;
                password = _password;
            }
        }

        [HttpGet] public IEnumerable<string> Get(string name, string password) {
            return new string[]{"Phu", "API", name, password};
        }

        // GET: api/Phu/5
        [HttpGet("{id:int}", Name = "Get")] public string Get(int id) {
            return "value_int:" + id;
        }
        
        [HttpGet("{name}", Name = "Get2")] public string Get(string name) {
            return "value_str:" + name;
        }

        [HttpGet("testlogin")]
        public string Get(string name, string password, string somevar)
        {
            return $"{name}:{password}:{somevar}";
        }


        [HttpGet("testlogin2/{name}/{password}/{someint}")]
        public string Get(string name, string password, int someint)
        {
            return $"{name}:{password}:{someint}";
        }





        // POST: api/Phu
        [HttpPost] public void Post([FromBody] string value) {}

        // PUT: api/Phu/5
        [HttpPut("{id}")] public void Put(int id, [FromBody] string value) {}

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")] public void Delete(int id) {}
    }
}

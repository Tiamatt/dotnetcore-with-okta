using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetcore_with_okta.Controllers
{
    [EnableCors("AllowAll")]
    [Produces("application/json")] // important!  [Produces] forces all apis to return JSON-formatted responses
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly ILogger<MainController> _logger;

        public MainController(ILogger<MainController> logger)
        {
            _logger = logger;
        }

        // GET: api/main
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "MainValue1", "MainValue2" };
        }

        // GET api/main/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "MainValue" + id.ToString();
        }

        // GET api/main/names
        [HttpGet("Names")]
        public IEnumerable<string> GetNames()
        {
            return new string[] { "MainName1", "MainName2" };
        }

        // GET api/main/name/5
        [HttpGet("Name/{id}")]
        public string GetName(int id)
        {
            return "MainName" + id.ToString();
        }

        // POST api/main
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/main/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/main/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

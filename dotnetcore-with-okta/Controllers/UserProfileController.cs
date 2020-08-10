using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotnetcore_with_okta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly ILogger<UserProfileController> _logger;

        public UserProfileController(ILogger<UserProfileController> logger)
        {
            _logger = logger;
        }

        // GET: api/<UserProfileController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "UserProfileValue1", "UserProfileValue2" };
        }

        // GET api/<UserProfileController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "UserProfileValue";
        }

        // POST api/<UserProfileController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserProfileController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserProfileController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetcore_with_okta.Controllers
{
    [Authorize]
    [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly ILogger<UserProfileController> _logger;

        public UserProfileController(ILogger<UserProfileController> logger)
        {
            _logger = logger;
        }

        // GET: api/userProfile
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "UserProfileValue1", "UserProfileValue2" };
        }

        // GET api/userProfile/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "UserProfileValue" + id.ToString();
        }

        // GET api/userProfile/names
        [HttpGet("Names")]
        public IEnumerable<string> GetNames()
        {
            return new string[] { "UserProfileName1", "UserProfileName2" };
        }

        // GET api/userProfile/name/5
        [HttpGet("Name/{id}")]
        public string GetName(int id)
        {
            return "UserProfileName" + id.ToString();
        }

        // POST api/userProfile
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/userProfile/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/userProfile/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

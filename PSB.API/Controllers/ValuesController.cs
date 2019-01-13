using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RAPS.SMS.BLL;
using RAPS.SMS.DLL.DLL.Models;
using RAPS.SMS.DLL.DLL.Repositories;

namespace PSB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IPeopleService _peopleService;


        public ValuesController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<People>> Get()
        {
            return _peopleService.GetAllPeople();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [Authorize]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeWendys.Business;
using PrimeWendys.Models.DataModels;

namespace PrimeWendys.Controllers
{
    [Produces("application/json")]
    [Route("api/Doors")]
    public class DoorsController : Controller
    {
        private readonly DoorsRepository repo;

        public DoorsController(DoorsRepository repo)
        {
            this.repo = repo;
        }
        /* Adding doors */
        [HttpPost("AddDoors")]
        public IActionResult AddDoors([FromBody] DoorDto door)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repo.addDoor(door);
                    return Ok(string.Format("Successfull added Category {0}", door.Door_Type));

                }
                catch (Exception e)
                {
                    return Ok(e.Message);
                }
            }
            return Ok("Failed try again");
        }
        /* Get all the doors */
        [HttpGet("GetDoors")]
        public IActionResult GetDoors()
        {
            var doors = repo.GetDoors();
            return Ok(doors);
        }
    }

    /*
    // GET: api/Doors
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET: api/Doors/5
    [HttpGet("{id}", Name = "Get")]
    public string Get(int id)
    {
        return "value";
    }

    // POST: api/Doors
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT: api/Doors/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
    */
}

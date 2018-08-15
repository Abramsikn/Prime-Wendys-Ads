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
    [Route("api/[controller]")]
    public class WendiesController : Controller
    {
        private readonly WendiesRepository repo;

        public WendiesController(WendiesRepository repo)
        {
            this.repo = repo;
        }
        /* Get all the wendies */
        [HttpGet("GetWendies")]
        public IActionResult GetWendies()
        {
            return Ok(repo.GetWendies());
        }
        /* Adding a wendy using a post method */
        [HttpPost("AddWendy")]
        public IActionResult AddCategory([FromBody] WendyDto wendy)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repo.AddWendy(wendy);
                    return Ok(string.Format("Successfully added a wendy house."));

                }
                catch (Exception e)
                {
                    return Ok(e.Message);
                }
            }
            return Ok("Failed to add a wendy, try again");
        }
    }

    /*
    [Produces("application/json")]
    [Route("api/Wendys")]
    public class WendysController : Controller
    {
        // GET: api/Wendys
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Wendys/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Wendys
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Wendys/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    */
}

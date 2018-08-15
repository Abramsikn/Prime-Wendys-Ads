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
    [Route("api/Woods")]
    public class WoodsController : Controller
    {
        private readonly WoodsRepository repo;

        public WoodsController(WoodsRepository repo)
        {
            this.repo = repo;
        }
        /* Adding woods */
        [HttpPost("AddWoods")]
        public IActionResult AddWoods([FromBody] WoodDto wood)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repo.addWood(wood);
                    return Ok(string.Format("Successfull added Category {0}", wood.Wood_Type));

                }
                catch (Exception e)
                {
                    return Ok(e.Message);
                }
            }
            return Ok("Failed try again");
        }
        /* Get all the woods */
        [HttpGet("GetWoods")]
        public IActionResult GetWoods()
        {
            var woods = repo.GetWoods();
            return Ok(woods);
        }
    }

    /*
    [Produces("application/json")]
    [Route("api/Woods")]
    public class WoodsController : Controller
    {
        // GET: api/Woods
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Woods/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Woods
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Woods/5
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

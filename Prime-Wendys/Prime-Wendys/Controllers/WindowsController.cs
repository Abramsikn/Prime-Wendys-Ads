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
    [Route("api/Windows")]
    public class WindowsController : Controller
    {
        private readonly WindowsRepository repo;

        public WindowsController(WindowsRepository repo)
        {
            this.repo = repo;
        }
        /* Adding windows */
        [HttpPost("AddWindows")]
        public IActionResult AddWindows([FromBody] WindowDto window)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repo.addWindow(window);
                    return Ok(string.Format("Successfull added Category {0}", window.Win_Type));

                }
                catch (Exception e)
                {
                    return Ok(e.Message);
                }
            }
            return Ok("Failed try again");
        }
        /* Get all the windows */
        [HttpGet("GetWindows")]
        public IActionResult GetWindows()
        {
            var windows = repo.GetWindows();
            return Ok(windows);
        }
    }

    /*
    // GET: api/Windows
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET: api/Windows/5
    [HttpGet("{id}", Name = "Get")]
    public string Get(int id)
    {
        return "value";
    }

    // POST: api/Windows
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT: api/Windows/5
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

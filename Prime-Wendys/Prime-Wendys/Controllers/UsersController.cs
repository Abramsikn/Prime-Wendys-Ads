using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeWendys.Models;
using PrimeWendys.Models.DataModels;
using PrimeWendys.Business;

namespace PrimeWendys.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private readonly UsersRepository repo;
        public UsersController(UsersRepository repo)
        {
            this.repo = repo;
        }
        /* Adding a user */
        [HttpPost("AddUser")]
        public IActionResult AddUser([FromBody] UserDto user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repo.AddUser(user);

                    return Ok(string.Format("Successfully added {0} {1}", user.First_Name, user.Last_Name));

                }
                catch (Exception e)
                {
                    return Ok(e.Message);
                }
            }
            else
            {
                return Ok("Form data correctly given");
            }
        }
        /* Getting all the users */
        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    return Ok(repo.GetUsers());
                }
                catch (Exception e)
                {
                    return Ok(e.Message);
                }
            }
            else
            {
                return Ok("Form data correctly given");
            }
        }

        /*
        // GET: api/Users
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        // POST: api/Users
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Users/5
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
}

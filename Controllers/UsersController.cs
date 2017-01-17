using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FesbBoardBackend.Models;
using FesbBoardBackend.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FesbBoardBackend.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private IUserRepository _users;
        public UsersController(IUserRepository users)
        {
            _users = users;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _users.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _users.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]User user)
        {
            _users.Add(user);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

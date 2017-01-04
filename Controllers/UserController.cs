using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FesbBoard.Domain.Queries;
using entities = FesbBoard.Domain.Entities;

namespace FesbBoard.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        public UserController(IUserRepository users)
        {
            Users = users;
        }
        public IUserRepository Users { get; set; }
        
        [Route("all")]
        [HttpGet]
        public IReadOnlyCollection<entities.User> GetAll()
        {
            return Users.GetAll();
        }
    }
}

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FesbBoard.Domain.Queries;
using entities = FesbBoard.Domain.Entities;

namespace FesbBoard.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        public UserController(IUserQueries users)
        {
            Users = users;
        }
        public IUserQueries Users { get; set; }
        
        [Route("all")]
        [HttpGet]
        public IReadOnlyCollection<entities.User> GetAll()
        {
            return Users.GetAll();
        }
    }
}

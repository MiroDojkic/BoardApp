using System;
using System.Collections.Generic;
using System.Linq;
using FesbBoardBackend.Models;

namespace FesbBoardBackend.Repositories
{
    public class UserRepository : IUserRepository
    {
        private FesbBoardDbContext _context;
        public UserRepository(FesbBoardDbContext context)
        {
            _context = context;
        }
        public void Add(User user)
        {
            _context.Users.Add(user);
            var numberOfChanges = _context.SaveChanges();
            Console.WriteLine("{0} records saved to database", numberOfChanges);
        }
        public IReadOnlyCollection<User> GetAll()
        {
            return _context.Users.ToList();
        }
        public User GetById(int id)
        {
            return _context.Users.Where(user => user.Id == id).SingleOrDefault();
        }
    }
}

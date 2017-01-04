using System;
using System.Collections.Generic;
using System.Linq;
using FesbBoard.Domain.Entities;

namespace FesbBoard.Domain.Queries
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
            Add(new Entities.User(username: "staff"));
        }

        public void Add(Entities.User user)
        {
            using (var db = new UserContext())
            {
                db.Users.Add(user);
                var numberOfChanges = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", numberOfChanges);
            }
        }

        public IReadOnlyCollection<Entities.User> GetAll()
        {
            using (var db = new UserContext())
            {
                return db.Users.Select(user => user).ToList();
            }
        }
    }
}

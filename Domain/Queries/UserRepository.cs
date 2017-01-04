using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FesbBoard.Domain.Entities;

namespace FesbBoard.Domain.Queries
{
    public class UserRepository : IUserRepository
    {
        private static ConcurrentDictionary<string, Entities.User> _users =
            new ConcurrentDictionary<string, Entities.User>();
        public UserRepository()
        {
            Add(new Entities.User { Username = "staff" });
        }

        public void Add(Entities.User user)
        {
            user.Key = Guid.NewGuid().ToString();
            _users.TryAdd(user.Key, user);
        }

        public IReadOnlyCollection<Entities.User> GetAll()
        {
            return _users.Values.ToList();
        }
    }
}

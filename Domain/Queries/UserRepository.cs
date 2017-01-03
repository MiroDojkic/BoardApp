using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FesbBoard.Domain.Entities;

namespace FesbBoard.Domain.Queries
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
        }

        IReadOnlyCollection<Entities.User> IUserRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

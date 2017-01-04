using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FesbBoard.Domain.Entities;

namespace FesbBoard.Domain.Queries
{
    public interface IUserRepository
    {
        void Add(Entities.User user);
        IReadOnlyCollection<Entities.User> GetAll();
    }
}

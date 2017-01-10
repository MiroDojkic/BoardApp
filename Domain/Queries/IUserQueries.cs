using System.Collections.Generic;
using FesbBoard.Domain.Entities;

namespace FesbBoard.Domain.Queries
{
    public interface IUserQueries
    {
        void Add(User user);
        IReadOnlyCollection<User> GetAll();
    }
}

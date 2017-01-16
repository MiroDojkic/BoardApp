using System.Collections.Generic;
using FesbBoardBackend.Models;

namespace FesbBoardBackend.Repositories
{
    public interface IUserRepository
    {
        void Add(User user);
        IReadOnlyCollection<User> GetAll();
    }
}

using System.Collections.Generic;
using FesbBoardBackend.Models;

namespace FesbBoardBackend.Repositories
{
    public interface ICommentRepository
    {
        void Add(Comment comment);
        IReadOnlyCollection<Comment> GetAll();
    }
}

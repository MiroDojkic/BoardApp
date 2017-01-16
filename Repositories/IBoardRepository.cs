using System.Collections.Generic;
using FesbBoardBackend.Models;

namespace FesbBoardBackend.Repositories
{
    public interface IBoardRepository
    {
        void Add(Board board);
        IReadOnlyCollection<Board> GetAll();
    }
}

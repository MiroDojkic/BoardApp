using System.Collections.Generic;
using FesbBoard.Domain.Entities;

namespace FesbBoard.Domain.Queries
{
    public interface IBoardQueries
    {
        void Add(Board board);
        IReadOnlyCollection<Board> GetAll();
    }
}

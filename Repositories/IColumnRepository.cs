using System.Collections.Generic;
using FesbBoardBackend.Models;

namespace FesbBoardBackend.Repositories
{
    public interface IColumnRepository
    {
        void Add(Column column);
        IReadOnlyCollection<Column> GetAll();
    }
}

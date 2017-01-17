using System.Collections.Generic;
using FesbBoardBackend.Models;

namespace FesbBoardBackend.Repositories
{
    public interface ICardRepository
    {
        void Add(Card card);
        IReadOnlyCollection<Card> GetAll();
    }
}

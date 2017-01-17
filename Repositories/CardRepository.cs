using System;
using System.Collections.Generic;
using System.Linq;
using FesbBoardBackend.Models;

namespace FesbBoardBackend.Repositories
{
    public class CardRepository : ICardRepository
    {
        private FesbBoardDbContext _context;
        public CardRepository(FesbBoardDbContext context)
        {
            _context = context;
        }
        public void Add(Card card)
        {
            _context.Cards.Add(card);
            var numberOfChanges = _context.SaveChanges();
            Console.WriteLine("{0} records saved to database", numberOfChanges);
        }
        public IReadOnlyCollection<Card> GetAll()
        {
            return _context.Cards.ToList();
        }
    }
}

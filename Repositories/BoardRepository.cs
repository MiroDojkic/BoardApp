using System;
using System.Collections.Generic;
using System.Linq;
using FesbBoardBackend.Models;

namespace FesbBoardBackend.Repositories
{
    public class BoardRepository : IBoardRepository
    {
        private FesbBoardDbContext _context;
        public BoardRepository(FesbBoardDbContext context)
        {
            _context = context;
        }
        public void Add(Board board)
        {
           _context.Boards.Add(board);
           var numberOfChanges = _context.SaveChanges();
           Console.WriteLine("{0} records saved to database", numberOfChanges);
        }

        public IReadOnlyCollection<Board> GetAll()
        {
           return _context.Boards.ToList();
        }
    }
}

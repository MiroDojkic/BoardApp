using System;
using System.Collections.Generic;
using System.Linq;
using FesbBoard.Data.Models;
using FesbBoard.Domain.Mappers;

namespace FesbBoard.Domain.Queries
{
    public class BoardQueries : IBoardQueries
    {
        private FesbBoardDbContext _context;
        public BoardQueries(FesbBoardDbContext context)
        {
            _context = context;
        }
        public void Add(Entities.Board board)
        {
           _context.Boards.Add(BoardMappers.entityToDto(board));
           var numberOfChanges = _context.SaveChanges();
           Console.WriteLine("{0} records saved to database", numberOfChanges);
        }

        public IReadOnlyCollection<Entities.Board> GetAll()
        {
           return _context.Boards.Select(BoardMappers.dtoToEntity).ToList();
        }
    }
}

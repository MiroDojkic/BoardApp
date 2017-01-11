using System;
using System.Collections.Generic;
using System.Linq;
using FesbBoard.Data.Models;
using FesbBoard.Domain.Mappers;

namespace FesbBoard.Domain.Queries
{
    public class BoardQueries : IBoardQueries
    {
        public BoardQueries()
        {
        }
        public void Add(Entities.Board board)
        {
            using (var db = new FesbBoardDbContext())
            {
                db.Boards.Add(BoardMappers.entityToDto(board));
                var numberOfChanges = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", numberOfChanges);
            }
        }

        public IReadOnlyCollection<Entities.Board> GetAll()
        {
            using (var db = new FesbBoardDbContext())
            {
                return db.Boards.Select(BoardMappers.dtoToEntity).ToList();
            }
        }
    }
}

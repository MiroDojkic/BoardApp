using System;
using System.Collections.Generic;
using System.Linq;
using FesbBoardBackend.Models;

namespace FesbBoardBackend.Repositories
{
    public class ColumnRepository : IColumnRepository
    {
        private FesbBoardDbContext _context;
        public ColumnRepository(FesbBoardDbContext context)
        {
            _context = context;
        }
        public void Add(Column column)
        {
            _context.Columns.Add(column);
            var numberOfChanges = _context.SaveChanges();
            Console.WriteLine("{0} records saved to database", numberOfChanges);
        }

        public IReadOnlyCollection<Column> GetAll()
        {
            return _context.Columns.ToList();
        }
    }
}

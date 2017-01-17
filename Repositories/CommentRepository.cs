using System;
using System.Collections.Generic;
using System.Linq;
using FesbBoardBackend.Models;

namespace FesbBoardBackend.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private FesbBoardDbContext _context;
        public CommentRepository(FesbBoardDbContext context)
        {
            _context = context;
        }
        public void Add(Comment comment)
        {
            _context.Comments.Add(comment);
            var numberOfChanges = _context.SaveChanges();
            Console.WriteLine("{0} records saved to database", numberOfChanges);
        }
        public IReadOnlyCollection<Comment> GetAll()
        {
            return _context.Comments.ToList();
        }
    }
}

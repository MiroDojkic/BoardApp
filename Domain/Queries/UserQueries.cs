using System;
using System.Collections.Generic;
using System.Linq;
using FesbBoard.Data.Models;
using FesbBoard.Domain.Mappers;

namespace FesbBoard.Domain.Queries
{
    public class UserQueries : IUserQueries
    {
        private FesbBoardDbContext _context;
        public UserQueries(FesbBoardDbContext context)
        {
            _context = context;
        }
        public void Add(Entities.User user)
        {
            _context.Users.Add(UserMappers.entityToDto(user));
            var numberOfChanges = _context.SaveChanges();
            Console.WriteLine("{0} records saved to database", numberOfChanges);
        }

        public IReadOnlyCollection<Entities.User> GetAll()
        {
            return _context.Users.Select(UserMappers.dtoToEntity).ToList();
        }
    }
}

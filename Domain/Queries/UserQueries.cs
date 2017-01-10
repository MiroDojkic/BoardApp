using System;
using System.Collections.Generic;
using System.Linq;
using FesbBoard.Data.Models;
using FesbBoard.Domain.Mappers;

namespace FesbBoard.Domain.Queries
{
    public class UserQueries : IUserQueries
    {
        public UserQueries()
        {
        }
        public void Add(Entities.User user)
        {
            using (var db = new FesbBoardDbContext())
            {
                // To implement - mapper from dto to entity and vice versa
                db.Users.Add(UserMappers.entityToDto(user));
                var numberOfChanges = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", numberOfChanges);
            }
        }

        public IReadOnlyCollection<Entities.User> GetAll()
        {
            using (var db = new FesbBoardDbContext())
            {
                return db.Users.Select(user => user).Select(UserMappers.dtoToEntity).ToList();
            }
        }
    }
}

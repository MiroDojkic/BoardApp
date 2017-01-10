using dtos = FesbBoard.Data.Models;
using entities = FesbBoard.Domain.Entities;

namespace FesbBoard.Domain.Mappers
{
    public static class UserMappers
    {
        public static dtos.User entityToDto(entities.User user)
        {
            return new dtos.User
            {
                Id = user.Id,
                Username = user.Username
            };
        }

        public static entities.User dtoToEntity(dtos.User user)
        {
            return new entities.User
            (
                id: user.Id,
                username: user.Username
            );
        }
    }
}

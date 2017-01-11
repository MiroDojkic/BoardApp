using dtos = FesbBoard.Data.Models;
using entities = FesbBoard.Domain.Entities;

namespace FesbBoard.Domain.Mappers
{
    public class BoardMappers
    {
        public static dtos.Board entityToDto(entities.Board board)
        {
            return new dtos.Board
            {
                Id = board.Id,
                Name = board.Name
            };
        }

        public static entities.Board dtoToEntity(dtos.Board board)
        {
            return new entities.Board
            (
                id: board.Id,
                name: board.Name
            );
        }
    }
}

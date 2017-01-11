namespace FesbBoard.Domain.Entities
{
    public class Board
    {
        public Board
        (
          int id,
          string name  
        )
        {
            this.Id = id;
            this.Name = name;
        }
        public int Id { get; }
        public string Name { get; }
    }
}

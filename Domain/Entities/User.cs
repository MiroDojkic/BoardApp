namespace FesbBoard.Domain.Entities
{
    public class User
    {
        public User
        (
            int id,
            string username
        )
        {
            this.Id = id;
            this.Username = username;
        }
        
        public int Id { get; }
        public string Username { get; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace FesbBoard.Data.Models
{
    public class FesbBoardDbContext : DbContext
    {
        public FesbBoardDbContext(DbContextOptions<FesbBoardDbContext> options)
            :base(options)
        {
        }
        public DbSet<User>  Users  { get; set; }
        public DbSet<Board> Boards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserBoard>()
                .HasKey(userBoard => new { userBoard.UserId, userBoard.BoardId });

            modelBuilder.Entity<UserBoard>()
                .HasOne(userBoard => userBoard.User)
                .WithMany(user => user.UserBoards)
                .HasForeignKey(userBoard => userBoard.UserId);

            modelBuilder.Entity<UserBoard>()
                .HasOne(userBoard => userBoard.Board)
                .WithMany(board => board.UserBoards)
                .HasForeignKey(userBoard => userBoard.BoardId);
        }
    }
}

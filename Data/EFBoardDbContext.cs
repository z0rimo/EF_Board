using EF_Board.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Board.Data
{
    public class EFBoardDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Post> Posts { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFBoardDb;Trusted_Connection=True;");
            }
        }
    }
}

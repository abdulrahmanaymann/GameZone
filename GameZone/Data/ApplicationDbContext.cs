using GameZone.Models;

namespace GameZone.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        public DbSet<Device> Devices { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<GameDevice> GameDevices { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action" },
                new Category { Id = 2, Name = "Adventure" },
                new Category { Id = 3, Name = "Racing" },
                new Category { Id = 4, Name = "Sports" },
                new Category { Id = 5, Name = "Fighting" },
                new Category { Id = 6, Name = "Film" },
                new Category { Id = 7, Name = "Strategy" },
                new Category { Id = 8, Name = "Puzzle" },
                new Category { Id = 9, Name = "Horror" },
                new Category { Id = 10, Name = "RPG" }
            );

            modelBuilder.Entity<Device>().HasData(
                new Device { Id = 1, Name = "Xbox", Icon = "xbox.png" },
                new Device { Id = 2, Name = "PlayStation", Icon = "playstation.png" },
                new Device { Id = 3, Name = "Nintendo", Icon = "nintendo.png" },
                new Device { Id = 4, Name = "PC", Icon = "pc.png" },
                new Device { Id = 5, Name = "Mobile", Icon = "mobile.png" }
            );

            modelBuilder.Entity<GameDevice>().HasKey(e => new { e.GameId, e.DeviceId });
            base.OnModelCreating(modelBuilder);
        }
    }
}

using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Data;

public class FootballLeagueDbContext : DbContext
{
    public DbSet<Team> Teams { get; set; }
    public DbSet<Coach> Coaches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Using SQL Server LocalDB
        //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;" +
        //                         "Initial Catalog=FootballLeague_EfCore;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        optionsBuilder.UseSqlite($"Data Source=FootballLeague_EfCore.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
	    modelBuilder.Entity<Team>().HasData(
	                new Team
	                {
	                        TeamId = 1,
	                        Name = "Tivoli Gardens FC",
	                        CreatedDate = DateTimeOffset.Parse("2025-09-30 14:49:00 +02:00").DateTime
                    },
	                new Team
	                {
			                TeamId = 2,
			                Name = "Waterhouse F.C.",
			                CreatedDate = DateTimeOffset.Parse("2025-09-30 14:50:00 +02:00").DateTime
                    },
	                new Team
	                {
			                TeamId = 3,
			                Name = "Humble Lions F.C.",
			                CreatedDate = DateTimeOffset.Parse("2025-09-30 14:51:00 +02:00").DateTime
                    }

                );
    }
}

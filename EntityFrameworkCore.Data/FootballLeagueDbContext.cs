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

}

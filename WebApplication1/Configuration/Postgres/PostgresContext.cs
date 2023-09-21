using Microsoft.EntityFrameworkCore;

namespace XTickets.Configuration.Postgres;


public class PostgresContext : DbContext
{
    public PostgresContext(DbContextOptions<PostgresContext> options) : base(options) { }

    public DbSet<YourEntity> Users { get; set; }
}

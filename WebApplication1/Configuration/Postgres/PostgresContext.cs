using Microsoft.EntityFrameworkCore;

namespace XTickets.Configuration.Postgres;


public class YourEntity
{

}

public class PostgresContext : DbContext
{
    public DbSet<YourEntity> SomeEntities { get; set; }

    public PostgresContext(DbContextOptions<PostgresContext> options) : base(options) { }

}

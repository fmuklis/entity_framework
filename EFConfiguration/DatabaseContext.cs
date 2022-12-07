using Microsoft.EntityFrameworkCore;

namespace Milan_EFConfiguration;

public class DatabaseContext : DbContext
{
	public DatabaseContext(DbContextOptions<DatabaseContext> options)
		:base(options)
	{

	}
    public DbSet<Category> Categories { get; set; } 
}

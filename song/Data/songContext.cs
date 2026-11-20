using Microsoft.EntityFrameworkCore;

public class songContext(DbContextOptions<songContext> options) : DbContext(options)
{
    public DbSet<song.Models.Genre> Genre { get; set; } = default!;
    public DbSet<song.Models.Movie> Movie { get; set; } = default!;
}

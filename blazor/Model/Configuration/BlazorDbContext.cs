using Microsoft.EntityFrameworkCore;

namespace Model.Configuration;

public class BlazorDbContext : DbContext
{
    public BlazorDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}
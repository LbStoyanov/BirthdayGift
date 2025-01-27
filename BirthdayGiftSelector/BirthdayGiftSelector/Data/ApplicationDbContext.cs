using BirthdayGiftSelector.Models;
using Microsoft.EntityFrameworkCore;

namespace BirthdayGiftSelector.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Gift> Gifts { get; set; }
    public DbSet<Vote> Votes { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Seed predefined data
        DbSeeder.Seed(modelBuilder);
    }
}


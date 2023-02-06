using Charity.Domain;
using Microsoft.EntityFrameworkCore;

namespace Charity.RepositoryEf;

public class DonationContext : DbContext
{
    public DonationContext(DbContextOptions<DonationContext> options) : base(options)
    { }

    public virtual DbSet<Donation> Donations { get; set; } = null!;
    public virtual DbSet<Donator> Donators { get; set; } = null!;
    public virtual DbSet<Category> Categories { get; set; } = null!;
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("dbo");
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DonationContext).Assembly);
    }
}
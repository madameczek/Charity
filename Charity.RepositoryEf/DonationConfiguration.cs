using Charity.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Charity.RepositoryEf;

public class DonationConfiguration : IEntityTypeConfiguration<Donation>
{
    public void Configure(EntityTypeBuilder<Donation> builder)
    {
        builder.ToTable("Donations");
        
        builder.HasKey(e => e.Id)
            .IsClustered();
        
        builder.HasIndex(e => e.Id)
            .IsUnique();

        builder.Property(e => e.Quantity)
            .IsRequired();

        builder.Property(e => e.Comment)
            .HasMaxLength(500);
        
        builder.HasMany(e => e.Categories)
            .WithMany(e => e.Donations)
            .UsingEntity<Dictionary<string, object>>(
                "DonationCategory",
                b => b.HasOne<Category>().WithMany().HasForeignKey("IdCategory"),
                b => b.HasOne<Donation>().WithMany().HasForeignKey("IdDonation"));
    }
}
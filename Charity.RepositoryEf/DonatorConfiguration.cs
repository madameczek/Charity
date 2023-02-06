using Charity.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Charity.RepositoryEf;

public class DonatorConfiguration : IEntityTypeConfiguration<Donator>
{
    public void Configure(EntityTypeBuilder<Donator> builder)
    {
        builder.ToTable("Donators");

        builder.HasKey(e => e.Id)
            .IsClustered();

        builder.Property(e => e.Street)
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(e => e.City)
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(e => e.ZipCode)
            .HasMaxLength(10)
            .IsRequired();
        
        builder.Property(e => e.ContactPerson)
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(e => e.PhoneNumber)
            .HasMaxLength(30)
            .IsRequired();
    }
}
using Domain.Destinations;
using Domain.DestinationTouristPackage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class DestinationConfiguration : IEntityTypeConfiguration<Destination>
{
    public void Configure(EntityTypeBuilder<Destination> builder)
    {
        builder.ToTable("Destination");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).HasConversion(
            DestinationId => DestinationId.Value,Value => new DestinationId(Value));

        builder.Property(c => c.Name).HasMaxLength(50);

        builder.Property(c => c.Location).HasMaxLength(100);

        builder.HasMany(d => d.TouristPackages)
               .WithMany(d => d.Destinations)
               .UsingEntity<DestinationTouristPackage>();
    }
}

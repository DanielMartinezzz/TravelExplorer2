

using Domain.DestinationTouristPackage;
using Domain.TouristPackages;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class TouristPackageConfiguration : IEntityTypeConfiguration<TouristPackage>
{
    public void Configure(EntityTypeBuilder<TouristPackage> builder)
    {
        builder.ToTable("TourstPackages");

        builder.HasKey(x => x.Id);
        builder.Property(c => c.Id).HasConversion(
            TouristPackageId => TouristPackageId.Value,
            value => new TouristPackageId(value));

        builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
        builder.Property(c => c.Description).IsRequired();
        builder.Property(c => c.StartDate).IsRequired();
        builder.Property(c => c.EndDate).IsRequired();
        builder.Property(c => c.Price).IsRequired();
        builder.HasMany(d => d.Destinations)
                .WithMany(t => t.TouristPackages)
                .UsingEntity<DestinationTouristPackage>();
    }
}

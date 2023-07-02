

using Domain.DestinationTouristPackage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class DestinationTouristPackageConfiguration : IEntityTypeConfiguration<DestinationTouristPackage>
{
    public void Configure(EntityTypeBuilder<DestinationTouristPackage> builder)
    {
        builder.HasKey(dt => new {dt.DestinationId, dt.TouristPackageId});
    }
}

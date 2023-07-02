

using Domain.Destinations;
using Domain.TouristPackages;

namespace Domain.DestinationTouristPackage;

public class DestinationTouristPackage
{
    public DestinationId DestinationId { get; set; }
    public TouristPackageId TouristPackageId { get; set; }
    public Destination Destination { get; set; } = null!;
    public TouristPackage TouristPackage { get; set; } = null!;
}

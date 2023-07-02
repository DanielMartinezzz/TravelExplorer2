using Domain.Primitives;
using Domain.TouristPackages;

namespace Domain.Destinations;

    
   public sealed class Destination : AggregateRoot
{
    public DestinationId Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Location { get; private set; } = string.Empty;

    public ICollection<TouristPackage> TouristPackages { get; private set; } =new List<TouristPackage>();

    public Destination() 
    {
    
    }


    public Destination(DestinationId id, string name, string location)
    {
        Id = id;
        Name = name;
        Location = location;
    }

    public static Destination UpdateDestination(Guid id, string name, string location) 
    {
      return new Destination(new DestinationId(id), name, location);
    }
}    
    
   


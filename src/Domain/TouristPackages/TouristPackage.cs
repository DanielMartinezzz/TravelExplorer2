

using Domain.Destinations;
using Domain.Primitives;

namespace Domain.TouristPackages
{
    public sealed class TouristPackage : AggregateRoot
    {
        public TouristPackageId Id { get; private set; }

        public string Name { get; private set; } = string.Empty;

        public string Description { get; private set; } = string.Empty;

        public DateTime StartDate { get; private set; } 
        public DateTime EndDate { get; private set;}
        public double Price { get; private set; }

        public ICollection<Destination> Destinations { get; private set; } = new List<Destination>();

        public TouristPackage() { 
        
        }

        public TouristPackage(TouristPackageId id, string name, string description, DateTime startDate, DateTime endDate, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
        }

        public static TouristPackage UpdateTouristPackage(Guid id, string name, string description, DateTime startDate, DateTime endDate, double price)
        {
            return new TouristPackage(new TouristPackageId(id), name, description, startDate, endDate, price);
        }
    }
}

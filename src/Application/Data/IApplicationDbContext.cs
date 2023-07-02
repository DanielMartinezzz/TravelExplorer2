using Domain.Customers;
using Domain.Destinations;
using Domain.DestinationTouristPackage;
using Domain.TouristPackages;
using Microsoft.EntityFrameworkCore;

namespace Application.Data;

public interface IApplicationDbContext
{
    DbSet<Customer> Customers { get; set; }
    DbSet<Destination> Destinations { get; set; }

    DbSet<TouristPackage> touristPackages { get; set; }
    DbSet<DestinationTouristPackage> destinationTouristPackages { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

   
}
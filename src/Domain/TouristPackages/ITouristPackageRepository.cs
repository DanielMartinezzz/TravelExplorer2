

namespace Domain.TouristPackages;

public interface ITouristPackageRepository
{
    Task<List<TouristPackage>> GetAll();
    Task<TouristPackage?> GetByIdAsync(TouristPackageId id);

    void Add(TouristPackage touristpackage);
    void Update(TouristPackage touristpackage);
    void Delete(TouristPackage touristpackage);
}

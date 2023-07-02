using Domain.Destinations;

namespace Infrastructure.Persistence.Repositories;

public class DestinationRepository : IDestinationRepository
{
    private readonly ApplicationDbContext _context;

    public DestinationRepository(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public void Add(Destination destination) => _context.Destinations.Add(destination);
    public void Delete(Destination destination) => _context.Destinations.Remove(destination);
    public void Update(Destination destination) => _context.Destinations.Update(destination);
    public async Task<bool> ExistsAsync(DestinationId id) => await _context.Destinations.AnyAsync(destination => destination.Id == id);
    public async Task<Destination?> GetByIdAsync(DestinationId id) => await _context.Destinations.SingleOrDefaultAsync(c => c.Id == id);
    public async Task<List<Destination>> GetAll() => await _context.Destinations.ToListAsync();
}

using Barbershop.Data;

namespace Barbershop.Repository;

public interface IBarberAvailabilityRepository{
    public Task<bool> CheckBarberAvailability(int barberId, DateTime start, DateTime end);
    public Task<bool> CloseBarberAvailability(int barberId, DateTime start, DateTime end);
    public Task<bool> OpenBarberAvailability(int barberId, DateTime start, DateTime end);
}


public class BarberAvailabilityRespository : IBarberAvailabilityRepository
{
    private readonly AppDbContext _context;
    public BarberAvailabilityRespository(AppDbContext context){
        _context = context;
    }

    public Task<bool> CheckBarberAvailability(int barberId, DateTime start, DateTime end)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CloseBarberAvailability(int barberId, DateTime start, DateTime end)
    {
        throw new NotImplementedException();
    }

    public Task<bool> OpenBarberAvailability(int barberId, DateTime start, DateTime end)
    {
        throw new NotImplementedException();
    }
}
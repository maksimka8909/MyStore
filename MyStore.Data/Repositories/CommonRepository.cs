using MyStore.Domain.Interfaces;

namespace MyStore.Data.Repositories;

public class CommonRepository : ICommonRepository
{
    private readonly ApplicationContext _db;

    public CommonRepository(ApplicationContext db)
    {
        _db = db;
    }

    public async Task<bool> SaveChanges() => (await _db.SaveChangesAsync()) > 0;
}
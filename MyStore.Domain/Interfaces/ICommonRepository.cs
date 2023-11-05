namespace MyStore.Domain.Interfaces;

public interface ICommonRepository
{
    public Task<bool> SaveChanges();
}
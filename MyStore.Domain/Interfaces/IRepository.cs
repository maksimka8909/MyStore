using MyStore.Domain.Entities;
using MyStore.Domain.Entities.Products;

namespace MyStore.Domain.Interfaces;

public interface IRepository<T>
    where T : class
{
    public Task<IReadOnlyList<Product>> GetItems();

    public Task<T?> GetItemById(int id);

    public Task Add(T item);

}
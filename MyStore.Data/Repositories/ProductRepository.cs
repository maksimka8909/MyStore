using Microsoft.EntityFrameworkCore;
using MyStore.Domain.Entities;
using MyStore.Domain.Entities.Products;
using MyStore.Domain.Interfaces;

namespace MyStore.Data.Repositories;

public class ProductRepository : IRepository<Product>
{
    private readonly ApplicationContext _db;

    public ProductRepository(ApplicationContext db)
    {
        _db = db;
    }

    public async Task<IReadOnlyList<Product>> GetItems() => await _db.Products.ToListAsync();

    public async Task<Product?> GetItemById(int id) => await _db.Products.FindAsync(id);

    public async Task Add(Product item) => await _db.Products.AddAsync(item);
}
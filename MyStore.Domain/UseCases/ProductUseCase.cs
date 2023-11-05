using MyStore.Domain.Entities;
using MyStore.Domain.Entities.Products;
using MyStore.Domain.Interfaces;

namespace MyStore.Domain.UseCases;

public class ProductUseCase
{
    private readonly IRepository<Product> _repository;

    public ProductUseCase(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public Task<IReadOnlyList<Product>> GetProducts()
    {
        return _repository.GetItems();
    }
}
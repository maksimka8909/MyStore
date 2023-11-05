using MyStore.Domain.Entities;
using MyStore.Domain.Entities.Products;

namespace MyStore.ViewModels;

public class CatalogProductViewModel
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public CatalogProductViewModel(Product product)
    {
        Id = product.Id;
        Name = product.Name;
        Price = product.Price;
    }
}
using MyStore.Domain.Entities;
using MyStore.Domain.UseCases;
using MyStore.ViewModels;

namespace MyStore.Services;

public class ProductService
{
    private readonly ProductUseCase _productUseCase;

    public ProductService(ProductUseCase productUseCase)
    {
        _productUseCase = productUseCase;
    }

    public async Task<ListOfItemsViewModel> GetProducts()
    {
        var products = await _productUseCase.GetProducts();
        List<CatalogProductViewModel> viewProducts = new List<CatalogProductViewModel>();
        foreach (var product in products)
        {
            viewProducts.Add(new CatalogProductViewModel(product));
        }

        return new ListOfItemsViewModel(viewProducts);
    }
}
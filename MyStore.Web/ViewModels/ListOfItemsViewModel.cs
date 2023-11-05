namespace MyStore.ViewModels;

public class ListOfItemsViewModel
{
    public IReadOnlyList<CatalogProductViewModel> CatalogProducts { get; set; }

    public ListOfItemsViewModel(IReadOnlyList<CatalogProductViewModel> catalogProducts)
    {
        CatalogProducts = catalogProducts;
    }
}
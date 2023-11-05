using Microsoft.AspNetCore.Mvc;
using MyStore.Services;

namespace MyStore.Controllers;

public class CatalogController : Controller
{
    private readonly ProductService _productService;

    public CatalogController(ProductService productService)
    {
        _productService = productService;
    }

    [Route("/catalog")]
    public async Task<IActionResult> Index()
    {
        return View(await _productService.GetProducts());
    }
}
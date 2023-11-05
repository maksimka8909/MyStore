using Microsoft.AspNetCore.Mvc;
using MyStore.Services;

namespace MyStore.Controllers;

public class HomeController : Controller
{
    private readonly ProductService _productService;

    public HomeController(ProductService productService)
    {
        _productService = productService;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _productService.GetProducts()!);
    }
}
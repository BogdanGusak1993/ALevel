using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductsController : ControllerBase
{
    private static readonly string[] Brands = new[]
    {
        "Gucci", "Prada", "Louis Vuitton", "Chanel", "Ralph Lauren", "Adidas",
        "Hermès", "Versace", "Nike"
    };
    private static readonly string[] Sizes = new[]
    {
        "S", "M", "L", "XL", "XXL", "XXXL",
    };
    private static readonly string[] Products = new[]
    {
        "Trouthes", "Jacket", "Shirt", "Socks", "Briefs", "T-Shirt",
        "Blazer", "Blouse", "Skirt", "Pants"
    };

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Products> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Products
        {
            Size = Sizes[Random.Shared.Next(Sizes.Length)],
            Cost = Random.Shared.Next(20, 100),
            Brand = Brands[Random.Shared.Next(Brands.Length)],
            Name = Brands[Random.Shared.Next(Brands.Length)] + ", " + Brands[Random.Shared.Next(Brands.Length)]
        })
            .ToList();
    }
}
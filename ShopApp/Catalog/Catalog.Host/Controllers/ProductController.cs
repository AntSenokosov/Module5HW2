using Catalog.Host.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly Product[] _products;
    public ProductController()
    {
        _products = GetProducts();
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return _products.ToArray();
    }

    private Product[] GetProducts()
    {
        var products = new Product[]
        {
            new Product
            {
                Id = 1,
                Name = "Product1",
                Price = 1500
            },
            new Product
            {
                Id = 2,
                Name = "Product2",
                Price = 2500
            },
            new Product
            {
                Id = 3,
                Name = "Product3",
                Price = 3500
            },
            new Product
            {
                Id = 4,
                Name = "Product4",
                Price = 4500
            },
            new Product
            {
                Id = 5,
                Name = "Product5",
                Price = 5500
            }
        };

        return products;
    }
}
using Microsoft.AspNetCore.Mvc;
using Product.Module.Models;
using System.Text.Json;

namespace Product.Module.Application;

[ApiController]
[Route("api/[controller]")]
public class ProductController : Controller
{
    public ProductController()
    {

    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ProductViewModel>> Get(int id)
    {
        var product = new ProductViewModel(Name: "Sabonete", Price: 7.59M);
        return Ok(product);
    }
}

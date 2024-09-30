using Microsoft.AspNetCore.Mvc;
using Payment.Module.Models;
using System.Text.Json;

namespace Payment.Module.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CartController : Controller
{
    public CartController()
    {
        
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<CartViewModel>> Get(int id)
    {
        // Search the Products through Product Module
        var products = new ProductViewModel[]
        {
            new(1, "Product 1", 10.0m, 2),
            new(2, "Product 2", 20.0m, 1)
        };
        // Search the User through User Module
        var user = new UserViewModel(1);

        var cart = new CartViewModel(1, products, user);

        return Ok(JsonSerializer.Serialize(cart, AppJsonSerializerContext.Default.CartViewModel));
    }
}

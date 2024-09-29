using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using User.Module.Models;

namespace User.Module.Application;

[ApiController]
[Route("api/[controller]")]
public class UserController : Controller
{
    public UserController()
    {

    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<UserViewModel>> Get(int id)
    {
        var options = new JsonSerializerOptions
        {
            TypeInfoResolver = AppJsonSerializerContext.Default
        };
        var user = new UserViewModel(Name: "Teste", Email: "teste@teste.com");
        return Ok(JsonSerializer.Serialize(user, options));
    }
}
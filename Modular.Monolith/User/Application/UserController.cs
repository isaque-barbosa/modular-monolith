using Microsoft.AspNetCore.Mvc;
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
        await Task.Delay(160);
        return Ok(new UserViewModel(id));
    }
}


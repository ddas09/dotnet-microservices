using Microsoft.AspNetCore.Mvc;

namespace AMS.Identity.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Ping()
    {
        return Ok("Identity server is healthy.");
    }
}

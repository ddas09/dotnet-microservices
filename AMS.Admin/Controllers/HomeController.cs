using Microsoft.AspNetCore.Mvc;

namespace AMS.Admin.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Ping()
    {
        return Ok("Admin server is healthy.");
    }
}
